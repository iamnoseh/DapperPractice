using Model.Courses;
using Model.Students;
using Model.Teachers;
using Infrastructure.Service;


Teacher teachers = new Teacher();
TeacherService teacherService = new TeacherService();
var teacher = teacherService.GetTaechers();
foreach (var t in teacher)
{
    Console.WriteLine(t.Id + " || " + t.FullName+ " || " + t.Email + " || " + t.Phone + " || " + t.Address);
}