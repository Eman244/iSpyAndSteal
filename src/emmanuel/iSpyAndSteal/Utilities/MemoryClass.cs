using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Microsoft.Win32;

namespace Utilities
{
    public static class MemoryClass
    {
        public static List<ListView> GetHardwareInformation(string Key, ref ListView lst, bool DontInsertNull)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);


            List<ListView> list = new List<ListView>();
            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    ListViewGroup grp;

                    try
                    {
                        grp = lst.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = lst.Groups.Add(share.ToString(), share.ToString());
                    }

                    if (share.Properties.Count <= 0)
                    {

                    }

                    foreach (PropertyData PC in share.Properties)
                    {

                        ListViewItem item = new ListViewItem(grp);
                        if (lst.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else
                            item.BackColor = Color.WhiteSmoke;

                        item.Text = PC.Name;

                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                item.SubItems.Add("No Information available");
                            else
                                continue;
                        }
                        lst.Items.Add(item);
                    }

                    list.Add(lst);
                }
                foreach (ListViewItem item in lst.Items)
                    if (item.SubItems[1].Text == "No Information available")
                        item.Remove();
                return list;
            }


            catch (Exception)
            {
                return null;
            }
        }

        public static List<SystemMemoryEntity> GetSystemMemory()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");

                List<SystemMemoryEntity> list = new List<SystemMemoryEntity>();

                foreach (ManagementObject share in searcher.Get())
                {
                    SystemMemoryEntity m = new SystemMemoryEntity();
                    if (share["Name"] != null)
                        m.NAME = share["Name"].ToString();
                    if (share["Name"] != null)
                        m.ATTRIBUTES = share["Name"].ToString();
                    if (share["BankLabel"] != null)
                        m.BANK_LABEL = share["BankLabel"].ToString();
                    if (share["Capacity"] != null)
                        m.CAPACITY = long.Parse("0" + share["Capacity"].ToString());
                    if (share["Caption"] != null)
                        m.CAPTION = share["Caption"].ToString();
                    if (share["ConfiguredClockSpeed"] != null)
                        m.CONFIGURE_CLOCL_SPEED = long.Parse("0" + share["ConfiguredClockSpeed"].ToString());
                    if (share["Name"] != null)
                        m.CREATION_CLASS_NAME = share["Name"].ToString();
                    if (share["DataWidth"] != null)
                        m.DATA_WIDTH = int.Parse("0" + share["DataWidth"].ToString());
                    if (share["Description"] != null)
                        m.DESCRIPTION = share["Description"].ToString();
                    if (share["Description"] != null)
                        m.DEVICE_LOCATOR = share["DeviceLocator"].ToString();
                    if (share["FormFactor"] != null)
                        m.FORM_FACTOR = int.Parse("0" + share["FormFactor"].ToString());
                    if (share["InterleaveDataDepth"] != null)
                        m.INTER_LEAVE_DATA_DEPTH = int.Parse("0" + share["InterleaveDataDepth"].ToString());
                    if (share["InterleavePosition"] != null)
                        m.INTER_LEAVE_POSITION = share["InterleavePosition"].ToString();
                    if (share["Manufacturer"] != null)
                        m.MANUFACTURER = share["Manufacturer"].ToString();
                    if (share["MemoryType"] != null)
                        m.MEMORY_TYPE = int.Parse("0" + share["MemoryType"].ToString());
                    if (share["PartNumber"] != null)
                        m.PART_NUMBER = share["PartNumber"].ToString();
                    if (share["PositionInRow"] != null)
                        m.POSITION_IN_ROW = int.Parse("0" + share["PositionInRow"].ToString());
                    if (share["SerialNumber"] != null)
                        m.SERIAL_NO = share["SerialNumber"].ToString();
                    if (share["SMBIOSMemoryType"] != null)
                        m.SMBIOS_MEMORY_TYPE = int.Parse("0" + share["SMBIOSMemoryType"].ToString());
                    if (share["Speed"] != null)
                        m.SPEED = share["Speed"].ToString();
                    m.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    if (share["TotalWidth"] != null)
                        m.TOTAL_WIDTH = int.Parse("0" + share["TotalWidth"].ToString());
                    if (share["TypeDetail"] != null)
                        m.TYPE_DETAIL = int.Parse("0" + share["TypeDetail"].ToString());

                    list.Add(m);

                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }


        }

        public static List<SystemPointingDevice> GetSystemPointingDevices()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PointingDevice");

                List<SystemPointingDevice> list = new List<SystemPointingDevice>();

                foreach (ManagementObject share in searcher.Get())
                {
                    SystemPointingDevice m = new SystemPointingDevice();

                    m.CAPTION = share["Caption"].ToString();
                    m.DESCRIPTION = share["Description"].ToString();
                    m.DEVICE_ID = share["DeviceID"].ToString();
                    m.DEVICE_INTERFACE = share["DeviceInterface"].ToString();
                    m.HARDWARE_TYPE = share["HardwareType"].ToString();
                    m.MANUFACTURER = share["Manufacturer"].ToString();
                    m.NAME = share["Name"].ToString();
                    m.NUMBER_OF_BUTTONS = int.Parse("0" + share["NumberOfButtons"].ToString());
                    m.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    m.SYSTEM_NAME = share["SystemName"].ToString();

                    list.Add(m);

                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<SystemPortConnectorEntity> GetSystemPorts()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PortConnector");

                List<SystemPortConnectorEntity> list = new List<SystemPortConnectorEntity>();

                foreach (ManagementObject share in searcher.Get())
                {
                    SystemPortConnectorEntity m = new SystemPortConnectorEntity();

                    m.CAPTION = share["Caption"].ToString();
                    m.DESCRIPTION = share["ExternalReferenceDesignator"].ToString();
                    m.CONNECTOR_TYPE = share["PortType"].ToString();
                    m.TAG = share["Tag"].ToString();
                    m.NAME = share["Name"].ToString();
                    m.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    list.Add(m);

                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<SystemPrinterEntity> GetSystemPrinters()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Printer");

                List<SystemPrinterEntity> list = new List<SystemPrinterEntity>();

                foreach (ManagementObject share in searcher.Get())
                {
                    SystemPrinterEntity m = new SystemPrinterEntity();

                    m.CAPTION = share["Caption"].ToString();
                    m.NAME = share["Name"].ToString();
                    m.AVERAGE_PAGES_PER_MINUTE = int.Parse("0" + share["AveragePagesPerMinute"].ToString());
                    var cab = (string[])share["CapabilityDescriptions"];
                    string dsc = "";
                    for (int i = 0; i < cab.Length; i++)
                    {
                        dsc += cab[i] + " ";
                    }
                    m.CAPABILITY_DESCRIPTION = dsc;

                    var name = (string[])share["PrinterPaperNames"];
                    string nam = "";
                    for (int i = 0; i < name.Length; i++)
                    {
                        nam += name[i] + " ";
                    }
                    m.PRINTER_PAPER_NAME = nam;

                    var size = (ushort[])share["PaperSizesSupported"];
                    string siz = "";
                    for (int i = 0; i < size.Length; i++)
                    {
                        siz += size[i] + " ";
                    }

                    m.PAPER_SIZE_SUPPORTED = siz;

                    m.DEVICE_ID = share["DeviceID"].ToString();
                    m.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    m.HORIZONTAL_RESOLUTION = int.Parse("0" + share["HorizontalResolution"].ToString());
                    m.VERTICAL_RESOLUTION = int.Parse("0" + share["VerticalResolution"].ToString());
                    m.SYSTEM_NAME = share["SystemName"].ToString();
                    m.STATUS = share["Status"].ToString();
                    if (share["SpoolEnabled"].ToString() == "True")
                        m.SPOOL_ENABLED = true;
                    else
                        m.SPOOL_ENABLED = false;
                    m.PRINT_PROCESSOR = share["PrintProcessor"].ToString();
                    if (share["Network"].ToString() == "True")
                        m.NETWORK = true;
                    else
                        m.NETWORK = false;
                    list.Add(m);

                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<SystemSoundDevicesEntity> GetSystemSoundDevices()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_SoundDevice");

                List<SystemSoundDevicesEntity> list = new List<SystemSoundDevicesEntity>();

                foreach (ManagementObject share in searcher.Get())
                {
                    SystemSoundDevicesEntity m = new SystemSoundDevicesEntity();

                    m.CAPTION = share["Caption"].ToString();
                    m.DESCRIPTION = share["Description"].ToString();
                    m.DEVICE_ID = share["DeviceID"].ToString();
                    m.MANUFACTURER = share["Manufacturer"].ToString();
                    m.STATUS_INFO = share["StatusInfo"].ToString();
                    m.SYSTEM_NAME = share["SystemName"].ToString();
                    m.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    m.NAME = share["Name"].ToString();
                    list.Add(m);

                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<SystemVideoControllerEntity> GetSystemVideoControllers()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController");

                List<SystemVideoControllerEntity> list = new List<SystemVideoControllerEntity>();

                foreach (ManagementObject share in searcher.Get())
                {
                    SystemVideoControllerEntity m = new SystemVideoControllerEntity();


                    m.ADAPTER_COMPATIABILITY = share["AdapterCompatibility"].ToNullStr();
                    m.ADAPTER_AVAILABILITY = share["Availability"].ToNullStr();
                    m.ADAPTER_DAC_TYPE = share["AdapterDACType"].ToNullStr();
                    m.CAPTION = share["Caption"].ToNullStr();
                    m.DESCRIPTION = share["Description"].ToNullStr();
                    m.DEVICE_ID = share["DeviceID"].ToNullStr();
                    m.SYSTEM_ID = LoginManagment.SYSTEM_ID;
                    var date = share["DriverDate"].ToString().Substring(0, 8);
                    date = date.Substring(0, 4) + "-" + date.Substring(4, 2) + "-" + date.Substring(6, 2);
                    m.DRIVER_DATE = Convert.ToDateTime(date);
                    m.DRIVER_VERSION = share["DriverVersion"].ToNullStr();
                    m.NAME = share["Name"].ToNullStr();
                    m.VIDEO_ARCHITECTURE = share["VideoArchitecture"].ToNullStr();
                    m.VIDEO_MEMORY_TYPE = share["VideoMemoryType"].ToNullStr();
                    m.VIDEO_PROCESSOR = share["VideoProcessor"].ToNullStr();
                    list.Add(m);

                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static List<Browser> GetBrowsers()
        {
            RegistryKey browserKeys;
            browserKeys = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Clients\StartMenuInternet");
            if (browserKeys == null)
                browserKeys = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet");
            string[] browserNames = browserKeys.GetSubKeyNames();
            List<Browser> browsers = new List<Browser>();
            for (int i = 0; i < browserNames.Length; i++)
            {
                Browser browser = new Browser();
                RegistryKey browserKey = browserKeys.OpenSubKey(browserNames[i]);
                browser.Name = (string)browserKey.GetValue(null);
                RegistryKey browserKeyPath = browserKey.OpenSubKey(@"shell\open\command");
                browser.Path = browserKeyPath.GetValue(null).ToString().Trim('"');
                browsers.Add(browser);
                if (browser.Path != null)
                    browser.Version = FileVersionInfo.GetVersionInfo(browser.Path).FileVersion;
                else
                    browser.Version = "unknown";
            }

            Browser edgeBrowser = GetEdgeVersion();
            if (edgeBrowser != null)
            {
                browsers.Add(edgeBrowser);
            }
            return browsers;
        }

        public static Browser GetEdgeVersion()
        {
            RegistryKey edgeKey =
                Registry.CurrentUser.OpenSubKey(
                    @"SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppModel\SystemAppData\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\Schemas");
            if (edgeKey != null)
            {
                string version = edgeKey.GetValue("PackageFullName").ToString().Trim('"');
                Match result = Regex.Match(version, "(((([0-9.])\\d)+){1})");
                if (result.Success)
                {
                    return new Browser
                    {
                        Name = "MicrosoftEdge",
                        Version = result.Value
                    };
                }
            }
            return null;
        }
    }
}
