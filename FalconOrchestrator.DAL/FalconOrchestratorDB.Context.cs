﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FalconOrchestratorDB : DbContext
    {
        public FalconOrchestratorDB()
            : base("name=FalconOrchestratorDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountGroup> AccountGroups { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountTicket> AccountTickets { get; set; }
        public virtual DbSet<AuthenticationLog> AuthenticationLogs { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<CustomerIOCEvent> CustomerIOCEvents { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DetectionDevice> DetectionDevices { get; set; }
        public virtual DbSet<Detection> Detections { get; set; }
        public virtual DbSet<DetectionTag> DetectionTags { get; set; }
        public virtual DbSet<DetectionTaxonomy> DetectionTaxonomies { get; set; }
        public virtual DbSet<DetectionTicket> DetectionTickets { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceTicket> DeviceTickets { get; set; }
        public virtual DbSet<DnsRequest> DnsRequests { get; set; }
        public virtual DbSet<DocumentsAccess> DocumentsAccesses { get; set; }
        public virtual DbSet<ExecutablesWritten> ExecutablesWrittens { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<NetworkAccess> NetworkAccesses { get; set; }
        public virtual DbSet<Responder> Responders { get; set; }
        public virtual DbSet<ResponderSchedule> ResponderSchedules { get; set; }
        public virtual DbSet<ScanResult> ScanResults { get; set; }
        public virtual DbSet<Severity> Severities { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Taxonomy> Taxonomies { get; set; }
        public virtual DbSet<TaxonomyType> TaxonomyTypes { get; set; }
        public virtual DbSet<TicketRecipient> TicketRecipients { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }
        public virtual DbSet<Whitelist> Whitelists { get; set; }
        public virtual DbSet<WhitelistType> WhitelistTypes { get; set; }
        public virtual DbSet<v_DetectionAverages> v_DetectionAverages { get; set; }
    }
}
