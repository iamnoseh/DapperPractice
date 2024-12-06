using Model.Teachers;

namespace Model.Courses;

public class Course
{
    public int CourseID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime EndDate { get; set; }
    public int TeacherId { get; set; }
    public int StudentId { get; set; }
}