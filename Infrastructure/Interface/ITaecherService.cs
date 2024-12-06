using Model.Teachers;

namespace Infrastructure.Interface;

public interface ITaecherService
{
    public void AddTaecher(Teacher taecher);
    public void UpdateTeacher(Teacher taecher);
    public void DeleteTaecher(int id);
    public Teacher GetTaecherById(int id);
    public List<Teacher> GetTaechers();
}