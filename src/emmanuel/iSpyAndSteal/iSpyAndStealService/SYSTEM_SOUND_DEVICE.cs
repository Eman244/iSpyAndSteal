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
    
    public partial class SYSTEM_SOUND_DEVICE
    {
        public long ID { get; set; }
        public long SYSTEM_ID { get; set; }
        public string CAPTION { get; set; }
        public string DESCRIPTION { get; set; }
        public string DEVICE_ID { get; set; }
        public string MANUFACTURER { get; set; }
        public string NAME { get; set; }
        public string STATUS_INFO { get; set; }
        public string SYSTEM_NAME { get; set; }
    
        public virtual SYSTEM_INFORMATION SYSTEM_INFORMATION { get; set; }
    }
}
