//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FalconOrchestrator.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserActivityLog
    {
        public int UserActivityLogId { get; set; }
        public string OperationName { get; set; }
        public string ServiceName { get; set; }
        public bool Success { get; set; }
        public string UserId { get; set; }
        public string UserIp { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string Offset { get; set; }
        public string DetectId { get; set; }
        public string State { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
