namespace Employee.ViewModels.ViewModels
{
    public class EmployeModel
    {
        public Guid EmployeeId { get; set; }

        public string Name { get; set; } = null!;

        public byte? Gender { get; set; }

        public DateTimeOffset? DateOfJoining { get; set; }

        public string? Designation { get; set; }

        public List<AddressModel> EmployeeAddress { get; set; }
    }
}
