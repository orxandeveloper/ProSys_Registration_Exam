namespace ER.Domain.ViewModels
{
    public class StudentVM
    {
        public int Id { get; set; }
        public int? StudentNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? GradeLevel { get; set; }
    }
}
