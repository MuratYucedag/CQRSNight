namespace CQRSNight.MediatorDesignPattern.Results
{
    public class GetEmployeeByIdQueryResult
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
