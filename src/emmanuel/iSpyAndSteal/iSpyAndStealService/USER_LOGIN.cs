//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iSpyAndStealService
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER_LOGIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_LOGIN()
        {
            this.SUPPORTs = new HashSet<SUPPORT>();
            this.SYSTEM_INFORMATION = new HashSet<SYSTEM_INFORMATION>();
            this.SYSTEM_USERS = new HashSet<SYSTEM_USERS>();
            this.USERPRIVS = new HashSet<USERPRIV>();
        }
    
        public int USER_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> USER_ROLE { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public string COMPANY { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string PHONE { get; set; }
        public Nullable<System.DateTime> LAST_LOGIN { get; set; }
        public bool EMAIL_ALERT { get; set; }
        public bool SMS_ALERT { get; set; }
        public bool PHONE_ALERT { get; set; }
        public string ADDRESS_LINE_1 { get; set; }
        public string ADDRESS_LINE_2 { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string PINCODE { get; set; }
        public string COUNTRY { get; set; }
        public Nullable<int> FK_COMPANY_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPORT> SUPPORTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTEM_INFORMATION> SYSTEM_INFORMATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTEM_USERS> SYSTEM_USERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERPRIV> USERPRIVS { get; set; }
    }
}