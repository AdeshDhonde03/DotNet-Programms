namespace EMS.Responses.EmployeeResponses
{
    public class PaginatedEmployeeResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<EmployeeResponse> Employees { get; set; }
    }
}
