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
    
    public partial class SYSTEM_VIDEO_CONTROLLER
    {
        public long ID { get; set; }
        public long SYSTEM_ID { get; set; }
        public string ADAPTER_COMPATIABILITY { get; set; }
        public string ADAPTER_DAC_TYPE { get; set; }
        public string ADAPTER_AVAILABILITY { get; set; }
        public string CAPTION { get; set; }
        public string DESCRIPTION { get; set; }
        public string DEVICE_ID { get; set; }
        public Nullable<System.DateTime> DRIVER_DATE { get; set; }
        public string DRIVER_VERSION { get; set; }
        public string NAME { get; set; }
        public string VIDEO_ARCHITECTURE { get; set; }
        public string VIDEO_MEMORY_TYPE { get; set; }
        public string VIDEO_PROCESSOR { get; set; }
    
        public virtual SYSTEM_INFORMATION SYSTEM_INFORMATION { get; set; }
    }
}
