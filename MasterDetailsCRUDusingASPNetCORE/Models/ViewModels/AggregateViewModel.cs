namespace MasterDetailsCRUDusingASPNetCORE.Models.ViewModels
{
    public class AggregateViewModel
    {
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public decimal SumValue { get; set; }
        public decimal AvgValue { get; set; }
        public List<GroupByViewModel> GroupByResult { get; set; }
        public List<EmployeeViewModel> Employees { get; set; }
    }
}
