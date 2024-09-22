using Bunifu.UI.WinForms;
using Memory;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PvZTrainer
{
    public partial class MainForm : Form
    {
        public Mem mem = new();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            mem.OpenProcess("PlantsVsZombies");
            byte[] fontData = Resources.pvzfont;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Resources.pvzfont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.pvzfont.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
            lblForm.Font = new Font(fonts.Families[0], 24F, FontStyle.Regular);
            label1.Font = new Font(fonts.Families[0], 14F, FontStyle.Regular);
            label2.Font = new Font(fonts.Families[0], 14F, FontStyle.Regular);
            label3.Font = new Font(fonts.Families[0], 14F, FontStyle.Regular);
            label4.Font = new Font(fonts.Families[0], 14F, FontStyle.Regular);
            label5.Font = new Font(fonts.Families[0], 14F, FontStyle.Regular);
        }
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(
            IntPtr hProcess,
            UIntPtr lpAddress,
            UIntPtr dwSize,
            uint dwFreeType
            );

        public static byte[] ReadCEBytes(string hexString)
        {
            // Remove any spaces or other non-hex characters
            hexString = hexString.Replace(" ", "");

            // Ensure the string has an even number of characters
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException("Hex string must have an even number of characters.");
            }

            // Create a byte array to hold the result
            byte[] byteArray = new byte[hexString.Length / 2];

            // Convert each pair of characters to a byte
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return byteArray;
        }
        nuint cCaveHead = 0;
        nuint cCaveHand = 0;
        nuint cCaveBody = 0;

        private void OneHit(object sender, EventArgs e)
        {

            if (sender is BunifuToggleSwitch2 checkBox)
            {
                if (checkBox.Checked)
                {
                    cCaveHead = mem.CreateCodeCave("PlantsVsZombies.exe+1419F4", ReadCEBytes("29 C9 E9 00 00 00 00"), 6, 2048); // Head
                    cCaveHand = mem.CreateCodeCave("PlantsVsZombies.exe+141651", ReadCEBytes("29 C0 E9 00 00 00 00"), 6, 2048); // Hand
                    cCaveBody = mem.CreateCodeCave("PlantsVsZombies.exe+141CDA", ReadCEBytes("29 ED E9 00 00 00 00"), 6, 2048); // Body

                }
                else
                {
                    mem.WriteBytes("PlantsVsZombies.exe+1419F4", ReadCEBytes("2B C8 89 74 24 0C"));
                    mem.WriteBytes("PlantsVsZombies.exe+141651", ReadCEBytes("29 86 DC 00 00 00"));
                    mem.WriteBytes("PlantsVsZombies.exe+141CDA", ReadCEBytes("2B 6C 24 20 89 44 24 10"));
                    VirtualFreeEx(mem.mProc.Handle, cCaveHead, 0, 0x8000);
                    VirtualFreeEx(mem.mProc.Handle, cCaveHand, 0, 0x8000);
                    VirtualFreeEx(mem.mProc.Handle, cCaveBody, 0, 0x8000);
                }
            }
        }

        private void InfiniteSun(object sender, EventArgs e)
        {
            if (sender is BunifuToggleSwitch2 checkBox)
            {
                Debug.WriteLine(checkBox.Checked);
                if (checkBox.Checked)
                {
                    mem.FreezeValue("PlantsVsZombies.exe+00329670,0x868,0x5578", "int", "99999");
                }
                else
                {
                    mem.UnfreezeValue("PlantsVsZombies.exe+00329670,0x868,0x5578");
                }
            }

        }

        private void NoCooldown(object sender, EventArgs e)
        {
            if (sender is BunifuToggleSwitch2 checkBox)
            {
                if (checkBox.Checked)
                {
                    mem.WriteBytes("PlantsVsZombies.exe+91E4F", ReadCEBytes("90 90 90"));
                }
                else
                {
                    mem.WriteBytes("PlantsVsZombies.exe+91E4F", ReadCEBytes("8B 47 24"));
                }
            }
        }

        private void NoDamagePlant(object sender, EventArgs e)
        {
            if (sender is BunifuToggleSwitch2 checkBox)
            {
                if (checkBox.Checked)
                {
                    mem.WriteBytes("PlantsVsZombies.exe+140680", ReadCEBytes("90 90 90 90"));
                }
                else
                {
                    mem.WriteBytes("PlantsVsZombies.exe+140680", ReadCEBytes("83 46 40 FC"));
                }
            }
        }

        private void AutoCollect(object sender, EventArgs e)
        {
            if (sender is BunifuToggleSwitch2 checkBox)
            {
                if (checkBox.Checked)
                {
                    mem.WriteBytes("PlantsVsZombies.exe+342F2", ReadCEBytes("EB 09"));
                }
                else
                {
                    mem.WriteBytes("PlantsVsZombies.exe+342F2", ReadCEBytes("75 09"));
                }
            }
        }

    }
}
