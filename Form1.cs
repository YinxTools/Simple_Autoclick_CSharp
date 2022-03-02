using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Autoclick_CSharp
{
    public partial class AutoClicker : Form
    {
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        private Random rand = new Random();
        private bool enable;
        public AutoClicker()
        {
            InitializeComponent();
        }

        private void AutoClicker_Load(object sender, EventArgs e)
        {
        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = siticoneTrackBar1.Value.ToString();
        }

        private void enabled_Click(object sender, EventArgs e)
        {
            if (enabled.Text == "enable")
            {
                enabled.Text = "disable";
                enabled.FillColor = Color.FromArgb(200, 153, 230);
                autoclick.Start();
                enable = true;
            }
            else
            {
                enabled.Text = "enable";
                enabled.FillColor = Color.FromArgb(120,73,150);
                autoclick.Stop();
                enable = false;
            }
        }

        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }
        IntPtr hWnd;
        private async void autoclick_Tick(object sender, EventArgs e)
        {
            autoclick.Interval = 1000 / siticoneTrackBar1.Value;
            try
            {
                hWnd = FindWindow(null, Process.GetProcessesByName(comboBox1.Text).FirstOrDefault().MainWindowTitle);
            }
            catch (Exception exception)
            {
                
            }
            string currentwindow = getActiveWindowName();
            if (currentwindow == null)
            {
                return;
            }
            if (currentwindow.Contains(comboBox1.Text))
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    PostMessage(hWnd, 0x0201, 0, 0);
                    await Task.Delay(20);
                    PostMessage(hWnd, 0x0202, 0, 0);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            comboBox1.Items.Clear();
            Process[] MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
                names.Add(MyProcess[i].ProcessName);
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                comboBox1.Items.Add(names[i]);
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            bindBtn.Text = "...";
        }
        KeysConverter Key = new KeysConverter();
        private void KeyBind_Tick(object sender, EventArgs e)
        {
            if (bindBtn.Text != "none" && bindBtn.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(bindBtn.Text.Replace("...", ""));
                if (GetAsyncKeyState(binding) < 0)
                {

                    while (GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(20);
                    }
                    if (enabled.Text.Contains("enable"))
                    {
                        enabled.Text = "disable";
                        enabled.FillColor = Color.FromArgb(200, 153, 230);
                        autoclick.Start();
                        enable = true;
                    }
                    else if (enabled.Text.Contains("disable"))
                    {
                        enabled.Text = "enable";
                        enabled.FillColor = Color.FromArgb(120, 73, 150);
                        autoclick.Stop();
                        enable = false;
                    }

                    return;
                }
            }
        }

        private void bindBtn_KeyDown(object sender, KeyEventArgs e)
        {

            string keydata = e.KeyData.ToString();
            if (!keydata.Contains("Alt"))
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    bindBtn.Text = "none";
                }
                else
                {
                    bindBtn.Text = keydata;
                }
            }

            KeysConverter Key = new KeysConverter();
        }
    }
}
