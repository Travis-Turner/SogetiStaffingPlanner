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
    using System.Collections.Generic;
    
    public partial class Position
    {
        public int PositionId { get; set; }
        public int OpportunityId { get; set; }
        public int UnitPracticeId { get; set; }
        public Nullable<int> MaxConsultantGradeId { get; set; }
        public Nullable<int> MinConsultantGradeId { get; set; }
        public string PositionName { get; set; }
        public int NumberOfPositions { get; set; }
        public string Skillset { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<System.DateTime> ExpectedStartDate { get; set; }
        public Nullable<int> Duration { get; set; }
        public string HireCandidate { get; set; }
        public string ProposedCandidate { get; set; }
        public string AcceptedCandidate { get; set; }
        public string RejectedCandidate { get; set; }
        public string PositionNote { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public System.DateTime LastModified { get; set; }
        public bool Active { get; set; }
        public int PositionStatusId { get; set; }
    
        public virtual Grade Grade { get; set; }
        public virtual Grade Grade1 { get; set; }
        public virtual Opportunity Opportunity { get; set; }
        public virtual PositionStatus PositionStatus { get; set; }
        public virtual UnitPractice UnitPractice { get; set; }
        public virtual User User { get; set; }
    }
}
