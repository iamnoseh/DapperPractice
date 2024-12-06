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

Console.WriteLine(new string('-',20));



CourseService courseService = new CourseService();
var courses = courseService.GetCourses();
foreach (var course in courses)
{
    Console.WriteLine($"ID: {course.CourseID} || Name: {course.Name} || Description: {course.Description} || CreateDate: {course.CreatedDate} || EndDate: {course.EndDate}");
}