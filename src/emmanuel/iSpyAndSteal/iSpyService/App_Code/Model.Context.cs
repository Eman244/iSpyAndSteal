﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class iSpyDb : DbContext
{
    public iSpyDb()
        : base("name=iSpyDb")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<ACTIVITYLOG> ACTIVITYLOGs { get; set; }
    public virtual DbSet<BROWSER> BROWSERs { get; set; }
    public virtual DbSet<BROWSER_HISTORY> BROWSER_HISTORY { get; set; }
    public virtual DbSet<COMPANY> COMPANies { get; set; }
    public virtual DbSet<COMPANY_INDUSTRY> COMPANY_INDUSTRY { get; set; }
    public virtual DbSet<LICENSE_TYPE> LICENSE_TYPE { get; set; }
    public virtual DbSet<LOGTYPE> LOGTYPES { get; set; }
    public virtual DbSet<PRIV> PRIVS { get; set; }
    public virtual DbSet<ROLEPRIV> ROLEPRIVS { get; set; }
    public virtual DbSet<ROLE> ROLES { get; set; }
    public virtual DbSet<SUPPORT> SUPPORTs { get; set; }
    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    public virtual DbSet<SYSTEM_DEVICE> SYSTEM_DEVICE { get; set; }
    public virtual DbSet<SYSTEM_INFORMATION> SYSTEM_INFORMATION { get; set; }
    public virtual DbSet<SYSTEM_INSTALLED_APPLICATION> SYSTEM_INSTALLED_APPLICATION { get; set; }
    public virtual DbSet<SYSTEM_LICENSE_KEY> SYSTEM_LICENSE_KEY { get; set; }
    public virtual DbSet<SYSTEM_MEMORY> SYSTEM_MEMORY { get; set; }
    public virtual DbSet<SYSTEM_MEMORY_SIZE> SYSTEM_MEMORY_SIZE { get; set; }
    public virtual DbSet<SYSTEM_MEMORY_USAGE> SYSTEM_MEMORY_USAGE { get; set; }
    public virtual DbSet<SYSTEM_NETWORK> SYSTEM_NETWORK { get; set; }
    public virtual DbSet<SYSTEM_POINTING_DEVICE> SYSTEM_POINTING_DEVICE { get; set; }
    public virtual DbSet<SYSTEM_PORT_CONNECTOR> SYSTEM_PORT_CONNECTOR { get; set; }
    public virtual DbSet<SYSTEM_PRINTER> SYSTEM_PRINTER { get; set; }
    public virtual DbSet<SYSTEM_PROCESSOR_USAGE> SYSTEM_PROCESSOR_USAGE { get; set; }
    public virtual DbSet<SYSTEM_SOUND_DEVICE> SYSTEM_SOUND_DEVICE { get; set; }
    public virtual DbSet<SYSTEM_USERS> SYSTEM_USERS { get; set; }
    public virtual DbSet<SYSTEM_VIDEO_CONTROLLER> SYSTEM_VIDEO_CONTROLLER { get; set; }
    public virtual DbSet<SYSTEM_VOLUME> SYSTEM_VOLUME { get; set; }
    public virtual DbSet<USER_LOGIN> USER_LOGIN { get; set; }
    public virtual DbSet<USERPRIV> USERPRIVS { get; set; }
    public virtual DbSet<USERROLE> USERROLES { get; set; }
    public virtual DbSet<WINDOW_ACTIVE> WINDOW_ACTIVE { get; set; }
    public virtual DbSet<V_BrowerHistoryAll> V_BrowerHistoryAll { get; set; }
    public virtual DbSet<V_BROWSER_HISTORY> V_BROWSER_HISTORY { get; set; }
    public virtual DbSet<V_ROLE_PRIV> V_ROLE_PRIV { get; set; }
    public virtual DbSet<V_SYSTEM_ACTIVE_WINDOW> V_SYSTEM_ACTIVE_WINDOW { get; set; }
    public virtual DbSet<V_SYSTEM_ACTIVE_WINDOWS> V_SYSTEM_ACTIVE_WINDOWS { get; set; }
    public virtual DbSet<V_SYSTEM_INFOR_REGISTERED> V_SYSTEM_INFOR_REGISTERED { get; set; }
    public virtual DbSet<V_SYSTEM_MEMORY> V_SYSTEM_MEMORY { get; set; }
    public virtual DbSet<V_SYSTEM_MEMORY_INFO> V_SYSTEM_MEMORY_INFO { get; set; }
    public virtual DbSet<V_SYSTEM_MEMORY_USAGE> V_SYSTEM_MEMORY_USAGE { get; set; }
    public virtual DbSet<V_SYSTEM_NETWOR_DEVICES> V_SYSTEM_NETWOR_DEVICES { get; set; }
    public virtual DbSet<V_SYSTEM_NETWORK> V_SYSTEM_NETWORK { get; set; }
    public virtual DbSet<V_SYSTEM_POINTING_DEVICE> V_SYSTEM_POINTING_DEVICE { get; set; }
    public virtual DbSet<V_SYSTEM_PORTS_CONNECTOR> V_SYSTEM_PORTS_CONNECTOR { get; set; }
    public virtual DbSet<V_SYSTEM_PRINTER_INFORMATION> V_SYSTEM_PRINTER_INFORMATION { get; set; }
    public virtual DbSet<V_SYSTEM_PROCESSOR_USAGE> V_SYSTEM_PROCESSOR_USAGE { get; set; }
    public virtual DbSet<V_SYSTEM_REGISTERED_APPS> V_SYSTEM_REGISTERED_APPS { get; set; }
    public virtual DbSet<V_SYSTEM_SOUND> V_SYSTEM_SOUND { get; set; }
    public virtual DbSet<V_SYSTEM_SOUND_DEVICES> V_SYSTEM_SOUND_DEVICES { get; set; }
    public virtual DbSet<V_SYSTEM_VIDEO_CONTROLLER> V_SYSTEM_VIDEO_CONTROLLER { get; set; }
    public virtual DbSet<V_SYSTEM_VIDEO_CONTROLLERS> V_SYSTEM_VIDEO_CONTROLLERS { get; set; }
    public virtual DbSet<V_SYSTEM_VOLUME> V_SYSTEM_VOLUME { get; set; }
    public virtual DbSet<V_USER_LOGIN_DETAIL> V_USER_LOGIN_DETAIL { get; set; }
    public virtual DbSet<V_USER_PRIVS_WITHROLE> V_USER_PRIVS_WITHROLE { get; set; }
}
