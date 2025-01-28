namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        // Globally Unique Identifier
        public Guid Id { get; set; }
        public  required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }   // Question Mark makes this property nullable
        public decimal Salary { get; set; }
    }
}
