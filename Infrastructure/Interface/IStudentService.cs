using Model.Students;

namespace Infrastructure.Interface;

public interface IStudentService
{
    public void AddStudent(Student student);
    public List<Student> GetStudents();
    public void DeleteStudentById(int id);
    public Student GetStudentById(int id);
    public void UpdateStudent(Student student);
}