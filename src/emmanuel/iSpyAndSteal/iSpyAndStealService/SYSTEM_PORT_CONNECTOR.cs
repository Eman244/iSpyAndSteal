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
    
    public partial class SYSTEM_PORT_CONNECTOR
    {
        public long ID { get; set; }
        public long SYSTEM_ID { get; set; }
        public string CAPTION { get; set; }
        public string CONNECTOR_TYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public string NAME { get; set; }
        public string TAG { get; set; }
    
        public virtual SYSTEM_INFORMATION SYSTEM_INFORMATION { get; set; }
    }
}
