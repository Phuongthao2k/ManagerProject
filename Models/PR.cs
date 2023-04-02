using System;
using System.Collections.Generic;
namespace ManagementPurchasing.Models;

public class PR
{
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string StaffId { get; set; }
    public DateTime RequestDate { get; set; }
    public string ProjectName { get; set; }
    public string status { get; set; }
}
