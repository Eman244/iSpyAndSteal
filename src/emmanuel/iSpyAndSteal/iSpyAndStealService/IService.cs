using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI.WebControls;

namespace iSpyAndStealService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<ListItem> GetAllSystem();
        [OperationContract]
        bool AddHardwareInformation(SYSTEM_INFORMATION hrd);

        [OperationContract]
        bool AddTicket(SUPPORT sp);

        [OperationContract]
        bool AddPrivs(PRIV priv, string userid, string mac);

        [OperationContract]
        List<PrivsList> GetPrivs();

        [OperationContract]
        List<UserRoleWithPrivsList> GetUserRoleWithPrivs(int userid);

        [OperationContract]
        List<RolePrivsList> GetRoleWithPrivileges(int roleId);

        [OperationContract]
        void AddPrivsToRole(List<RoleList> roleLists, List<RolePrivleges> privlegeses, string userid, string mac);

        [OperationContract]
        List<UsersEntity> GetUsers();

        [OperationContract]
        List<RolePrivlegesList> GetRolePrivleges(int? roleId);

        [OperationContract]
        bool AddRole(ROLE role, List<ROLEPRIV> privlegeses, string userid, string mac);

        [OperationContract]
        List<RoleList> GetRoles();

        [OperationContract]
        void AssingRolesToMultiUser(List<USERROLE> userrole, string userid, string mac);

        [OperationContract]
        bool RevokeMultiRoleFromUser(List<USERROLE> list, string userId, string mac);

        [OperationContract]
        V_USER_LOGIN_DETAIL AuthenticateUser(string userid, string password, string mac);

        [OperationContract]
        V_USER_LOGIN_DETAIL AuthenticateUserMac(string mac);

        [OperationContract]
        bool ChnagePassword(string userId, string oldPassword, string newPassword);

        [OperationContract]
        bool AddActiveWindows(List<WINDOW_ACTIVE> win, string userid, string mac);

        [OperationContract]
        bool AddVolume(List<SYSTEM_VOLUME> sv);

        [OperationContract]
        bool AddSystemMemory(List<SYSTEM_MEMORY> sv);

        [OperationContract]
        bool CreateLoginHistory(ACTIVITYLOG log);

        [OperationContract]
        bool AddSystemPointingDevice(List<SYSTEM_POINTING_DEVICE> dev);

        [OperationContract]
        bool AddSystemPortConnector(List<SYSTEM_PORT_CONNECTOR> port);

        [OperationContract]
        bool AddSystemPrinters(List<SYSTEM_PRINTER> printer);

        [OperationContract]
        bool AddSystemSoundDeices(List<SYSTEM_SOUND_DEVICE> sound);

        [OperationContract]
        bool AddSystemVideoConroller(List<SYSTEM_VIDEO_CONTROLLER> video);

        [OperationContract]
        bool AddSystemNetworkInfo(List<SYSTEM_NETWORK> video);

        [OperationContract]
        List<V_SYSTEM_ACTIVE_WINDOW> GetSystemActiveWindow(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_NETWORK> GetSystemNetwork(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_MEMORY> GetSystemMemory(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_POINTING_DEVICE> GetSystemPointingDevice(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_PORTS_CONNECTOR> GetSystemPorts(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_PRINTER_INFORMATION> GetSystemPrinter(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_SOUND> GetSystemSound(long systemId, string mac);
        [OperationContract]
        List<V_SYSTEM_VIDEO_CONTROLLER> GetSystemVideoControllers(long systemId, string mac);
        [OperationContract]
        List<V_SYSTEM_VOLUME> GetSystemVolume(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_MEMORY_USAGE> GetSystemMemoryUsage(long systemId, string mac);

        [OperationContract]
        List<V_SYSTEM_PROCESSOR_USAGE> GetSystemProcessorUsage(long systemId, string mac);

        [OperationContract]
        bool AddSystemMemoryUsage(SYSTEM_MEMORY_USAGE sv);

        [OperationContract]
        bool AddSystemProcessorUsage(SYSTEM_PROCESSOR_USAGE sv);

        [OperationContract]
        bool AddChromeHistory(List<BROWSER_HISTORY> hist);

        [OperationContract]
        string Activate(string username, string password, string mac);



        [OperationContract]
        bool AddSystemInstalledApps(List<SYSTEM_INSTALLED_APPLICATION> hist);

        [OperationContract]
        LicenseDevices VerifyLicense(string licenceCode, string mac);


        [OperationContract]
        UserPortalEntity loginUser(string userName, string Password);
        [OperationContract]
        bool registerUser(UserPortalEntity user);
        [OperationContract]
        List<V_BrowserHistory> getBrowserHistoryAll(int sysId, int companyId);

        [OperationContract]
        List<SYSTEM_INFORMATION> GetRegisteredSystems(int companyId);

        [OperationContract]
        List<V_SYSTEM_REGISTERED_APPS> GetInstalledApps(int sysId, int companyId);

        [OperationContract]
        List<V_SYSTEM_ACTIVE_WINDOWS> GetSysActiveWindows(int sysId, int companyId);

        [OperationContract]
        List<V_SYSTEM_VIDEO_CONTROLLERS> GetSystemVideoControllersNew(int sysId, int companyId);

        [OperationContract]
        List<V_SYSTEM_SOUND_DEVICES> GetSystemSoundDevicesPortal(int sysId, int companyId);

        [OperationContract]
        List<V_SYSTEM_NETWOR_DEVICES> GetSystemNetworkDevicePortal(int sysId, int companyId);

        [OperationContract]
        List<V_SYSTEM_POINTING_DEVICE> GetSystemPointingDevicePortal(int sysId, int companyId);
        [OperationContract]
        List<V_SYSTEM_PORTS_CONNECTOR> GetSystemPortsDevicePortal(int sysId, int companyId);
        [OperationContract]
        List<V_SYSTEM_PRINTER_INFORMATION> GetSystemPrintDevicePortal(int sysId, int companyId);
    }
}
