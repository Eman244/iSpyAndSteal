
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Logic
/// </summary>
public class Logic
{
    public static bool AddHardwareInformation(SYSTEM_INFORMATION hrd)
    {
        try
        {
            using (var db = new iSpyDb())
            {
                var sys = db.SYSTEM_INFORMATION.Where(x => x.USERID == hrd.USERID && x.MAC_ADDRESS == hrd.MAC_ADDRESS && x.COMPANY_ID == hrd.COMPANY_ID).FirstOrDefault();

                if (sys == null)
                {
                    db.SYSTEM_INFORMATION.Add(hrd);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    sys.LAST_BOOT_TIME = hrd.LAST_BOOT_TIME;
                    db.SaveChanges();
                    return true;
                }

            }
        }
        catch (Exception)
        {
            return false;
        }
    }


    public static bool AddTicket(SUPPORT sp)
    {
        try
        {
            using (var db = new iSpyDb())
            {
                db.SUPPORTs.Add(sp);
                db.SaveChanges();
                return true;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }


    public static bool AddPrivs(PRIV priv, string userid, string mac)
    {
        using (var db = new iSpyDb())
        {
            db.PRIVS.Add(priv);
            db.SaveChanges();
            //Log.Add("Priv has been add  priv ID ." + priv.PRIVID, LogType.Success, mac, userid);
            return true;
        }
    }



    public static bool AddRole(ROLE role, List<ROLEPRIV> privlegeses, string userid, string mac)
    {
        using (var db = new iSpyDb())
        {
            db.ROLES.Add(role);
            db.SaveChanges();
            //Log.Add("Role has been add  Role ID ." + role.ROLEID, LogType.Success, mac, userid);
        }
        foreach (var priv in privlegeses)
        {
            var privs = new ROLEPRIV
            {
                PRIVID = priv.PRIVID,
                ROLEID = role.ROLEID,
            };
            AddPrivsToRole(privs, userid, mac);
        }
        return true;
    }

    private static void AddPrivsToRole(ROLEPRIV privs, string userid, string mac)
    {
        using (var db = new iSpyDb())
        {
            db.ROLEPRIVS.Add(privs);
            db.SaveChanges();
            // Log.Add("Priv ID." + privs.PRIVID + " has been add to Role ID ." + privs.ROLEID, LogType.Success, mac, userid);
        }
    }


    public static void AssingRoleToUser(USERROLE userrole, string userid, string mac)
    {
        using (var db = new iSpyDb())
        {
            db.USERROLES.Add(userrole);
            db.SaveChanges();
            //Log.Add("Role " + userrole.ROLEID + "has been Assigned to UserID ." + userrole.ID, LogType.Success, mac, userid);
        }
    }




    public static void AssingRolesToMultiUser(List<USERROLE> userrole, string userid, string mac)
    {
        foreach (var urole in userrole)
        {
            AssingRoleToUser(urole, userid, mac);
        }
    }


    public static bool RevokeRoleFromUser(int roleId, string userId, string mac)
    {
        using (var db = new iSpyDb())
        {
            int userid = int.Parse(userId);
            var role = db.USERROLES.FirstOrDefault(r => r.ROLEID == roleId && r.USERID == userid);
            db.USERROLES.Remove(role);
            db.SaveChanges();
            return true;
        }
    }

    public static bool RevokeMultiRoleFromUser(List<USERROLE> list, string userId, string mac)
    {
        foreach (var role in list)
        {
            RevokeRoleFromUser(role.ROLEID, role.USERID.ToString(), mac);
        }
        return true;
    }

    public static bool RevokePrivsFromRole(int privId, int roleId, string userId, string mac)
    {
        using (var db = new iSpyDb())
        {
            var privs = db.ROLEPRIVS.FirstOrDefault(r => r.PRIVID == privId && r.ROLEID == roleId);
            db.ROLEPRIVS.Remove(privs);
            db.SaveChanges();
            return true;
        }
    }

    public static bool RevokeMiltiPrivsFromRole(List<ROLEPRIV> list, string userId, string mac)
    {
        foreach (var privs in list)
        {
            RevokePrivsFromRole(privs.PRIVID, privs.ROLEID, userId, mac);
        }
        return true;
    }




    public static List<USER_LOGIN> GetUsers()
    {
        using (var db = new iSpyDb())
        {
            var user = db.USER_LOGIN.ToList();
            return user;
        }
    }



    public static V_USER_LOGIN_DETAIL AuthenticateUser(string userid, string password, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_USER_LOGIN_DETAIL.Where(x =>  x.EMAIL == userid && x.PASSWORD==password).FirstOrDefault();
        }
    }

    public static V_USER_LOGIN_DETAIL AuthenticateUser( string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_USER_LOGIN_DETAIL.Where(x => x.MAC_ADDRESS == mac).FirstOrDefault();
        }
    }

    public static bool ChnagePassword(string userId, string oldPassword, string newPassword)
    {
        try
        {
            using (var db = new iSpyDb())
            {

                var usr = db.USER_LOGIN.FirstOrDefault(x => x.USER_ID.ToString() == userId && x.PASSWORD == oldPassword);
                if (usr != null)
                {
                    usr.PASSWORD = newPassword;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        catch (Exception)
        {
            return false;
        }

    }

    public static bool AddActiveWindows(List<WINDOW_ACTIVE> win, string userid, string mac)
    {
        using (var db = new iSpyDb())
        {
            foreach (var w in win)
            {
                var ww = db.WINDOW_ACTIVE.FirstOrDefault(x => x.WINDOW_TITLE == w.WINDOW_TITLE);
                if (ww != null)
                {
                    ww.VISIT_COUNT = ww.VISIT_COUNT + 1;
                    ww.UPDATE_DATE = DateTime.Now;
                    db.SaveChanges();
                }
                else
                {
                    db.WINDOW_ACTIVE.Add(w);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static bool AddVolume(List<SYSTEM_VOLUME> sv)
    {
        try
        {
            using (var db = new iSpyDb())
            {
                foreach (var d in sv)
                {
                    db.SYSTEM_VOLUME.Add(d);
                    db.SaveChanges();
                }
                return true;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool AddSystemMemory(List<SYSTEM_MEMORY> sv)
    {
        try
        {
            using (var db = new iSpyDb())
            {
                foreach (var d in sv)
                {
                    var sm = db.SYSTEM_MEMORY.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.SERIAL_NO == d.SERIAL_NO).FirstOrDefault();
                    if (sm == null)
                    {
                        db.SYSTEM_MEMORY.Add(d);
                        db.SaveChanges();
                    }
                }
                return true;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool CreateLoginHistory(ACTIVITYLOG log)
    {

        using (var ll = new iSpyDb())
        {
            ll.ACTIVITYLOGs.Add(log);
            ll.SaveChanges();
            return true;
        }
    }


    public static bool AddSystemPointingDevice(List<SYSTEM_POINTING_DEVICE> dev)
    {

        using (var db = new iSpyDb())
        {
            foreach (var d in dev)
            {
                var sm = db.SYSTEM_POINTING_DEVICE.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.DEVICE_ID == d.DEVICE_ID).FirstOrDefault();
                if (sm == null)
                {
                    db.SYSTEM_POINTING_DEVICE.Add(d);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static bool AddSystemPortConnector(List<SYSTEM_PORT_CONNECTOR> port)
    {

        using (var db = new iSpyDb())
        {
            foreach (var d in port)
            {
                var sm = db.SYSTEM_PORT_CONNECTOR.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.TAG == d.TAG).FirstOrDefault();
                if (sm == null)
                {
                    db.SYSTEM_PORT_CONNECTOR.Add(d);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static bool AddSystemPrinters(List<SYSTEM_PRINTER> printer)
    {

        using (var db = new iSpyDb())
        {
            foreach (var d in printer)
            {
                var sm = db.SYSTEM_PRINTER.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.DEVICE_ID == d.DEVICE_ID).FirstOrDefault();
                if (sm == null)
                {
                    db.SYSTEM_PRINTER.Add(d);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static bool AddSystemSoundDeices(List<SYSTEM_SOUND_DEVICE> sound)
    {

        using (var db = new iSpyDb())
        {
            foreach (var d in sound)
            {
                var sm = db.SYSTEM_SOUND_DEVICE.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.DEVICE_ID == d.DEVICE_ID).FirstOrDefault();
                if (sm == null)
                {
                    db.SYSTEM_SOUND_DEVICE.Add(d);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static bool AddSystemVideoConroller(List<SYSTEM_VIDEO_CONTROLLER> video)
    {

        using (var db = new iSpyDb())
        {
            foreach (var d in video)
            {
                var sm = db.SYSTEM_VIDEO_CONTROLLER.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.DEVICE_ID == d.DEVICE_ID).FirstOrDefault();
                if (sm == null)
                {
                    db.SYSTEM_VIDEO_CONTROLLER.Add(d);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static bool AddSystemNetworkInfo(List<SYSTEM_NETWORK> video)
    {

        using (var db = new iSpyDb())
        {
            foreach (var d in video)
            {
                var sm = db.SYSTEM_NETWORK.Where(x => x.SYSTEM_ID == d.SYSTEM_ID && x.NAME == d.NAME).FirstOrDefault();
                if (sm == null)
                {
                    db.SYSTEM_NETWORK.Add(d);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static List<V_SYSTEM_ACTIVE_WINDOW> GetSystemActiveWindow(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_ACTIVE_WINDOW.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_MEMORY> GetSystemMemory(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_MEMORY.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_NETWORK> GetSystemNetwork(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_NETWORK.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_POINTING_DEVICE> GetSystemPointingDevice(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_POINTING_DEVICE.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_PORTS_CONNECTOR> GetSystemPorts(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_PORTS_CONNECTOR.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_PRINTER_INFORMATION> GetSystemPrinter(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_PRINTER_INFORMATION.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_SOUND> GetSystemSound(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_SOUND.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_VIDEO_CONTROLLER> GetSystemVideoControllers(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_VIDEO_CONTROLLER.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_VOLUME> GetSystemVolume(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_VOLUME.Where(x => x.SYETEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static bool AddSystemMemoryUsage(SYSTEM_MEMORY_USAGE sv)
    {
        try
        {
            using (var db = new iSpyDb())
            {

                db.SYSTEM_MEMORY_USAGE.Add(sv);
                db.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool AddSystemProcessorUsage(SYSTEM_PROCESSOR_USAGE sv)
    {
        try
        {
            using (var db = new iSpyDb())
            {

                db.SYSTEM_PROCESSOR_USAGE.Add(sv);
                db.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static List<V_SYSTEM_MEMORY_USAGE> GetSystemMemoryUsage(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_MEMORY_USAGE.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static List<V_SYSTEM_PROCESSOR_USAGE> GetSystemProcessorUsage(long systemId, string mac)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_PROCESSOR_USAGE.Where(x => x.SYSTEM_ID == systemId && x.MAC_ADDRESS == mac).ToList();
        }
    }

    public static bool AddChromeHistory(List<BROWSER_HISTORY> hist)
    {
        using (var db = new iSpyDb())
        {

            foreach (var h in hist)
            {
                var hh = db.BROWSER_HISTORY.Where(x => x.SYSTEM_ID == h.SYSTEM_ID && x.URL == h.URL && x.BROSWER_ID == h.BROSWER_ID).FirstOrDefault();

                if (hh == null)
                {
                    db.BROWSER_HISTORY.Add(h);
                    db.SaveChanges();
                }
                else
                {
                    hh.VISIT_COUNT = h.VISIT_COUNT;
                    hh.LAST_VISIT_TIME = h.LAST_VISIT_TIME;
                    hh.LAST_VISIT_DATE = h.LAST_VISIT_DATE;
                    db.SaveChanges();
                }
            }
            return true;
        }
    }


    public static bool AddSystemInstalledApps(List<SYSTEM_INSTALLED_APPLICATION> apps)
    {
        using (var db = new iSpyDb())
        {

            foreach (var h in apps)
            {
                var hh = db.SYSTEM_INSTALLED_APPLICATION.Where(x => x.SYSTEM_ID == h.SYSTEM_ID && x.APP_NAME == h.APP_NAME).FirstOrDefault();

                if (hh == null)
                {
                    db.SYSTEM_INSTALLED_APPLICATION.Add(h);
                    db.SaveChanges();
                }
                else
                {
                    hh.APP_NAME = h.APP_NAME;
                    hh.SIZE = h.SIZE;
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

    public static string GetUniqueKey(int size)
    {

        char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        byte[] data = new byte[4 * size];
        using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
        {
            crypto.GetBytes(data);
        }
        StringBuilder result = new StringBuilder(size);
        for (int i = 0; i < size; i++)
        {
            var rnd = BitConverter.ToUInt32(data, i * 4);
            var idx = rnd % chars.Length;

            result.Append(chars[idx]);
        }

        return result.ToString().ToUpper();
    }

    public static string Key(int size, bool upperCase)
    {
        StringBuilder builder = new StringBuilder();
        Random random = new Random();
        char ch;
        for (int i = 0; i < size; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }
        if (upperCase)
            return builder.ToString().ToUpper();
        return builder.ToString();
    }

    //public static bool AuthenticatePortal(string email,string password)
    //{
    //    try
    //    {
    //        using (var db = new iSpyDb())
    //        {
    //            var user = new // ar let me copy code again its not copy properly... you can work now when done i will let you know

    //        }
    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //    }
    //}




    private static string GenerateLicenceCode()
    {
        var pKey = "";
        while (pKey.Length < 16)
        {
            pKey += new Random().Next(0, 10);
        }
        pKey = pKey.Substring(0, 16);
        return pKey;
    }


    //public static UserPortalEntity loginUser(string userName, string Password)
    //{
    //    try
    //    {
    //        using (var db = new iSpyDb())
    //        {
    //            var user = db.SYSTEM_USERS.Where(s => s.EMAIL == userName && s.PASSWORD == Password).Select(x => new UserPortalEntity()
    //            {
    //                USER_ID = x.USER_ID,
    //                USER_NAME = x.USER_NAME,
    //                EMAIL = x.EMAIL,
    //                PASSWORD = x.PASSWORD,
    //                RESET_HASH = x.RESET_HASH,
    //                RESET_HASH_EXPIRY = x.RESET_HASH_EXPIRY,
    //                PROFILE_IMAGE = x.PROFILE_IMAGE,
    //                FK_LICENSE__ID = x.FK_LICENSE__ID,
    //                PURCHASE_DATE = x.PURCHASE_DATE,
    //                EXPIRY_DATE = x.EXPIRY_DATE

    //            }).FirstOrDefault();

    //            return user;
    //        }
    //    }
    //    catch (Exception)
    //    {

    //        return null;
    //    }


    //}

    //public static bool registerUser(UserPortalEntity user)
    //{

    //    try
    //    {
    //        var dbuser = new USER();
    //        dbuser.USER_NAME = user.USER_NAME;
    //        dbuser.EMAIL = user.EMAIL;
    //        dbuser.PASSWORD = user.PASSWORD;
    //        dbuser.RESET_HASH = "#";
    //        dbuser.RESET_HASH_EXPIRY = false;
    //        dbuser.PROFILE_IMAGE = "n/a";

    //        using (var db = new iSpyDb())
    //        {



    //            db.USERS.Add(dbuser);
    //            db.SaveChanges();
    //            return true;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        return false;
    //    }

    //}

    public static List<V_BrowserHistory> getBrowserHistoryAll(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_BrowerHistoryAll.Where(x => x.SYSTEM_ID == sysId).Select(x => new V_BrowserHistory()
            {
                Brower = x.Brower,
                URL = x.URL,
                TITLE = x.TITLE,
                VISIT_COUNT = x.VISIT_COUNT,
                LAST_VISIT_TIME = x.LAST_VISIT_TIME,
                LAST_VISIT_DATE = x.LAST_VISIT_DATE
            }).ToList();
        }
    }


    public static List<SYSTEM_INFORMATION> GetRegisteredSystems(int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.SYSTEM_INFORMATION.ToList();
        }
    }
    public static List<V_SYSTEM_REGISTERED_APPS> GetInstalledApps(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_REGISTERED_APPS.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }

    public static List<V_SYSTEM_ACTIVE_WINDOWS> GetSysActiveWindows(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_ACTIVE_WINDOWS.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId && x.WINDOW_TITLE != null).ToList();
        }
    }

    public static List<V_SYSTEM_VIDEO_CONTROLLERS> GetSystemVideoControllersNew(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_VIDEO_CONTROLLERS.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }

    public static List<V_SYSTEM_SOUND_DEVICES> GetSystemSoundDevicesPortal(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_SOUND_DEVICES.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }


    public static List<V_SYSTEM_NETWOR_DEVICES> GetSystemNetworkDevicePortal(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_NETWOR_DEVICES.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }

    public static List<V_SYSTEM_POINTING_DEVICE> GetSystemPointingDevicePortal(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_POINTING_DEVICE.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }

    public static List<V_SYSTEM_PORTS_CONNECTOR> GetSystemPortsDevicePortal(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_PORTS_CONNECTOR.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }
    public static List<V_SYSTEM_PRINTER_INFORMATION> GetSystemPrintDevicePortal(int sysId, int companyId)
    {
        using (var db = new iSpyDb())
        {
            return db.V_SYSTEM_PRINTER_INFORMATION.Where(x => x.SYSTEM_ID == sysId && x.USERID == companyId).ToList();
        }
    }

}