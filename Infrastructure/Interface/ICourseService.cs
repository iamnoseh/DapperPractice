namespace Infrastructure.Interface;

public interface ICourseService
{
    public void AddCourse(Course course);
    public List<string> GetCourses();
    public void UpdateCourse(Course course);
    public void DeleteCourse(int courseId);
    public Course GetCourseById(int courseId);
}