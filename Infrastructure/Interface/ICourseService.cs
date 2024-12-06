namespace Infrastructure.Interface;
using Model.Courses;
public interface ICourseService
{
    public void AddCourse(Course course);
    public List<Course> GetCourses();
    public void UpdateCourse(Course course);
    public void DeleteCourse(int courseId);
    public Course GetCourseById(int courseId);
}