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
    
    public partial class DeviceTicket
    {
        public int DeviceTicketId { get; set; }
        public int DeviceId { get; set; }
        public int TicketId { get; set; }
    
        public virtual Device Device { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
