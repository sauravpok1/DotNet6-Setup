﻿using TM.Core.Enums;

namespace TM.Services.Issues.Rqst
{

    public class IssueVm
    {
        public string Title { get; set; }
        public IssueType Type { get; set; }
        public IssueStatus Status { get; set; }
        public IssuePriority Priority { get; set; }
        public int ListPosition { get; set; }
        public string Description { get; set; }
        public string DescriptionText { get; set; }
        public int? Estimate { get; set; }
        public int ReporterId { get; set; }
        public int ProjectId { get; set; }
    }
    public class AddIssueRqst: IssueVm
    {
       
    }

    public class UpdateIssueRqst: IssueVm
    {
        public int Id { get; set; }
        public int TimeSpent { get; set; }
        public int TimeRemaining { get; set; }
    }
}
