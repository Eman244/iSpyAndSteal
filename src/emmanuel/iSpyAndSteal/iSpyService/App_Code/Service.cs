using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{

    public bool AddHardwareInformation(SYSTEM_INFORMATION hrd)
    {
        return Logic.AddHardwareInformation(hrd);
    }

    public bool AddTicket(SUPPORT sp)
    {
        return Logic.AddTicket(sp);
    }

    public bool AddPrivs(PRIV priv, string userid, string mac)
    {
        return Logic.AddPrivs(priv, userid, mac);
    }

    

    public bool AddRole(ROLE role, List<ROLEPRIV> privlegeses, string userid, string mac)
    {
        return Logic.AddRole(role, privlegeses, userid, mac);
    }
   

    public void AssingRolesToMultiUser(List<USERROLE> userrole, string userid, string mac)
    {
        Logic.AssingRolesToMultiUser(userrole, userid, mac);
    }
    public bool RevokeMultiRoleFromUser(List<USERROLE> list, string userId, string mac)
    {
        return Logic.RevokeMultiRoleFromUser(list, userId, mac);
    }

    public V_USER_LOGIN_DETAIL AuthenticateUser(string userid, string password, string mac)
    {
        return Logic.AuthenticateUser(userid, password, mac);
    }

    public bool ChnagePassword(string userId, string oldPassword, string newPassword)
    {
        return Logic.ChnagePassword(userId, oldPassword, newPassword);
    }

    public bool AddActiveWindows(List<WINDOW_ACTIVE> win, string userid, string mac)
    {
        return Logic.AddActiveWindows(win, userid, mac);
    }

    public bool AddVolume(List<SYSTEM_VOLUME> sv)
    {
        return Logic.AddVolume(sv);
    }

    public bool AddSystemMemory(List<SYSTEM_MEMORY> sv)
    {
        return Logic.AddSystemMemory(sv);
    }

    public bool CreateLoginHistory(ACTIVITYLOG log)
    {
        return Logic.CreateLoginHistory(log);
    }

    public bool AddSystemPointingDevice(List<SYSTEM_POINTING_DEVICE> dev)
    {
        return Logic.AddSystemPointingDevice(dev);
    }

    public bool AddSystemPortConnector(List<SYSTEM_PORT_CONNECTOR> port)
    {
        return Logic.AddSystemPortConnector(port);
    }

    public bool AddSystemPrinters(List<SYSTEM_PRINTER> printer)
    {
        return Logic.AddSystemPrinters(printer);
    }

    public bool AddSystemSoundDeices(List<SYSTEM_SOUND_DEVICE> sound)
    {
        return Logic.AddSystemSoundDeices(sound);
    }

    public bool AddSystemVideoConroller(List<SYSTEM_VIDEO_CONTROLLER> video)
    {
        return Logic.AddSystemVideoConroller(video);
    }

    public bool AddSystemNetworkInfo(List<SYSTEM_NETWORK> video)
    {
        return Logic.AddSystemNetworkInfo(video);
    }


    public List<V_SYSTEM_ACTIVE_WINDOW> GetSystemActiveWindow(long systemId, string mac)
    {
        return Logic.GetSystemActiveWindow(systemId, mac);
    }

    public List<V_SYSTEM_MEMORY> GetSystemMemory(long systemId, string mac)
    {
        return Logic.GetSystemMemory(systemId, mac);
    }

    public List<V_SYSTEM_NETWORK> GetSystemNetwork(long systemId, string mac)
    {
        return Logic.GetSystemNetwork(systemId, mac);
    }

    public List<V_SYSTEM_POINTING_DEVICE> GetSystemPointingDevice(long systemId, string mac)
    {
        return Logic.GetSystemPointingDevice(systemId, mac);
    }

    public List<V_SYSTEM_PORTS_CONNECTOR> GetSystemPorts(long systemId, string mac)
    {
        return Logic.GetSystemPorts(systemId, mac);
    }

    public List<V_SYSTEM_PRINTER_INFORMATION> GetSystemPrinter(long systemId, string mac)
    {
        return Logic.GetSystemPrinter(systemId, mac);
    }

    public List<V_SYSTEM_SOUND> GetSystemSound(long systemId, string mac)
    {
        return Logic.GetSystemSound(systemId, mac);
    }
    public List<V_SYSTEM_VIDEO_CONTROLLER> GetSystemVideoControllers(long systemId, string mac)
    {
        return Logic.GetSystemVideoControllers(systemId, mac);
    }
    public List<V_SYSTEM_VOLUME> GetSystemVolume(long systemId, string mac)
    {
        return Logic.GetSystemVolume(systemId, mac);
    }

    public List<V_SYSTEM_MEMORY_USAGE> GetSystemMemoryUsage(long systemId, string mac)
    {
        return Logic.GetSystemMemoryUsage(systemId, mac);
    }

    public List<V_SYSTEM_PROCESSOR_USAGE> GetSystemProcessorUsage(long systemId, string mac)
    {
        return Logic.GetSystemProcessorUsage(systemId, mac);
    }

    public bool AddSystemMemoryUsage(SYSTEM_MEMORY_USAGE sv)
    {
        return Logic.AddSystemMemoryUsage(sv);
    }

    public bool AddSystemProcessorUsage(SYSTEM_PROCESSOR_USAGE sv)
    {
        return Logic.AddSystemProcessorUsage(sv);
    }

    public bool AddChromeHistory(List<BROWSER_HISTORY> hist)
    {
        return Logic.AddChromeHistory(hist);
    }

  

    public bool AddSystemInstalledApps(List<SYSTEM_INSTALLED_APPLICATION> hist)
    {
        return Logic.AddSystemInstalledApps(hist);
    }

 
    public List<V_BrowserHistory> getBrowserHistoryAll(int sysId, int companyId)
    {
        return Logic.getBrowserHistoryAll(sysId, companyId);
    }

    public List<SYSTEM_INFORMATION> GetRegisteredSystems(int companyId)
    {
        return Logic.GetRegisteredSystems(companyId);
    }

    public List<V_SYSTEM_REGISTERED_APPS> GetInstalledApps(int sysId, int companyId)
    {
        return Logic.GetInstalledApps(sysId, companyId);
    }
    public List<V_SYSTEM_ACTIVE_WINDOWS> GetSysActiveWindows(int sysId, int companyId)
    {
        return Logic.GetSysActiveWindows(sysId, companyId);
    }

    public List<V_SYSTEM_VIDEO_CONTROLLERS> GetSystemVideoControllersNew(int sysId, int companyId)
    {
        return Logic.GetSystemVideoControllersNew(sysId, companyId);
    }

    public List<V_SYSTEM_SOUND_DEVICES> GetSystemSoundDevicesPortal(int sysId, int companyId)
    {
        return Logic.GetSystemSoundDevicesPortal(sysId, companyId);
    }


    public List<V_SYSTEM_NETWOR_DEVICES> GetSystemNetworkDevicePortal(int sysId, int companyId)
    {
        return Logic.GetSystemNetworkDevicePortal(sysId, companyId);
    }
    public List<V_SYSTEM_POINTING_DEVICE> GetSystemPointingDevicePortal(int sysId, int companyId)
    {
        return Logic.GetSystemPointingDevicePortal(sysId, companyId);
    }
    public List<V_SYSTEM_PORTS_CONNECTOR> GetSystemPortsDevicePortal(int sysId, int companyId)
    {
        return Logic.GetSystemPortsDevicePortal(sysId, companyId);
    }
    public List<V_SYSTEM_PRINTER_INFORMATION> GetSystemPrintDevicePortal(int sysId, int companyId)
    {
        return Logic.GetSystemPrintDevicePortal(sysId, companyId);
    }

    public List<PrivsList> GetPrivs()
    {
        throw new NotImplementedException();
    }

    public List<UserRoleWithPrivsList> GetUserRoleWithPrivs(int userid)
    {
        throw new NotImplementedException();
    }

    public List<RolePrivsList> GetRoleWithPrivileges(int roleId)
    {
        throw new NotImplementedException();
    }

    public void AddPrivsToRole(List<RoleList> roleLists, List<RolePrivleges> privlegeses, string userid, string mac)
    {
        throw new NotImplementedException();
    }

    public List<UsersEntity> GetUsers()
    {
        throw new NotImplementedException();
    }

    public List<RolePrivlegesList> GetRolePrivleges(int? roleId)
    {
        throw new NotImplementedException();
    }

    public List<RoleList> GetRoles()
    {
        throw new NotImplementedException();
    }

    public string Activate(string username, string password, string mac)
    {
        throw new NotImplementedException();
    }

    public LicenseDevices VerifyLicense(string licenceCode, string mac)
    {
        throw new NotImplementedException();
    }

    public UserPortalEntity loginUser(string userName, string Password)
    {
        throw new NotImplementedException();
    }

    public bool registerUser(UserPortalEntity user)
    {
        throw new NotImplementedException();
    }

    public V_USER_LOGIN_DETAIL AuthenticateUserMac(string mac)
    {
        return Logic.AuthenticateUser( mac);
    }
}

