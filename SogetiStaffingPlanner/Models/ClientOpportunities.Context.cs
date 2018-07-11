//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SogetiStaffingPlanner.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ClientOpportunitiesEntities : DbContext
    {
        public ClientOpportunitiesEntities()
            : base("name=ClientOpportunitiesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusinessRole> BusinessRoles { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DefaultViewRole> DefaultViewRoles { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Opportunity> Opportunities { get; set; }
        public virtual DbSet<PermissionRole> PermissionRoles { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PositionStatus> PositionStatuses { get; set; }
        public virtual DbSet<Practice> Practices { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<SoldStatus> SoldStatuses { get; set; }
        public virtual DbSet<UnitPractice> UnitPractices { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserBusinessRole> UserBusinessRoles { get; set; }
    
        public virtual ObjectResult<GetACTLeadList_Result> GetACTLeadList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetACTLeadList_Result>("GetACTLeadList");
        }
    
        public virtual ObjectResult<GetAEList_Result> GetAEList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAEList_Result>("GetAEList");
        }
    
        public virtual ObjectResult<GetPracticeManagerReportData_Result> GetPracticeManagerReportData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPracticeManagerReportData_Result>("GetPracticeManagerReportData");
        }
    
        public virtual int MainView()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MainView");
        }
    
        public virtual ObjectResult<spGetClients_Result> spGetClients()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetClients_Result>("spGetClients");
        }
    
        public virtual ObjectResult<spOpportunity_Result> spOpportunity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spOpportunity_Result>("spOpportunity");
        }
    
        public virtual ObjectResult<spPosition_Result> spPosition()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPosition_Result>("spPosition");
        }
    }
}
