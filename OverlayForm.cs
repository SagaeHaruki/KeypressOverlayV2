using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeypressOverlayV2
{
    public partial class OverlayForm : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private static LowLevelKeyboardProc _proc;
        private static IntPtr _hookID = IntPtr.Zero;

        private Stopwatch stopwatch = new Stopwatch();

        public int CharLength;
        public OverlayForm()
        {
            InitializeComponent();
            _proc = HookCallback;
            _hookID = SetHook(_proc);
            outpt_txt.Text = "";

            Timer clearLabelTimer = new Timer();
            clearLabelTimer.Interval = 2500;
            clearLabelTimer.Tick += ClearLabelTimer_Tick;
            clearLabelTimer.Start();
        }

        private void OverlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            UnhookWindowsHookEx(_hookID);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private void ClearLabelTimer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds > 1800)
            {
                if (outpt_txt.Text == "")
                {

                }
                else
                {
                    this.Size = new Size(200, 125);
                    outpt_txt.Text = "";
                    Console.WriteLine("Label cleared due to inactivity.");
                }
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            Console.WriteLine(outpt_txt.Size.Width);
            Console.WriteLine(outpt_txt.Text.Length);
            string output = outpt_txt.Text;
            this.Size = new Size (outpt_txt.Size.Width + 60, outpt_txt.Height + 60);

            if(output.Length % CharLength == 0 && output.Length > 0)
            {
                outpt_txt.Text += Environment.NewLine;
            }

            if (output.Length >= CharLength + CharLength)
            {
                outpt_txt.Text = "";
            }

            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                Dictionary<string, string> keyMappings = new Dictionary<string, string>
                {
                    {"LControlKey", "︽"},
                    {"RControlKey", "︽"},
                    {"LShiftKey", "⇧"},
                    {"RShiftKey", "⇧"},
                    {"LWin", "⌘"},
                    {"RWin", "⌘"},
                    {"Back", "⌫"},
                    {"Apps", "❆"},
                    {"Return", "➠"},
                    {"Oem1", ";"},
                    {"Oem5", "\\"},
                    {"Oem6", "]"},
                    {"Oem7", "'"},
                    {"OemOpenBrackets", "["},
                    {"OemQuestion", "/"},
                    {"Oemcomma", ","},
                    {"Oemtilde", "`"},
                    {"OemPeriod", "."},
                    {"OemMinus", "-"},
                    {"Oemplus", "+"},
                    {"Capital", "[Caps]"},
                    {"Tab", "[⇄]"},
                    {"Win", "[⇄]"},
                    {"Escape", "[Esc]"},
                    {"PrintScreen", "[PrtSc]"},
                    {"Scroll", "[Scrl]"},
                    {"Insert", "[Ins]"},
                    {"Home", "🏚"},
                    {"Pause", "⏸"},
                    {"PageUp", "[PgUp]"},
                    {"Delete", "[Del]"},
                    {"Next", "[PgDn]"},
                    {"End", "[End]"},
                    {"Up", "⇧"},
                    {"Right", "⇨"},
                    {"Down", "⇩"},
                    {"Left", "⇦"},
                    {"Space", "_"},
                };

                string keyString = key.ToString();
                if (keyMappings.ContainsKey(keyString))
                {
                    outpt_txt.Text += keyMappings[keyString];
                }
                else if (keyString.Length == 2 && keyString[0] == 'D' && char.IsDigit(keyString[1]))
                {
                    outpt_txt.Text += keyString[1];
                }
                else
                {
                    outpt_txt.Text += keyString.ToLower();
                }
                stopwatch.Restart();
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn,
            IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
