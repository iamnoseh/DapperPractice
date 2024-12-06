using Infrastructure.Interface;
using Model.Courses;
using Npgsql;
using Dapper;
namespace Infrastructure.Service;

public class CourseService: ICourseService
{
    public void AddCourse(Course course)
    {
        try
        {
            var connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd =
                "Insert into Courses(Name,Description,CreateDate,Enddate,TeacherId,StudentId) values (@Name,@Description,@CreateDate,@EndDate,@TeacherId,@StudentId)";
            var effect = connection.Execute(cmd, course);
            if (effect != 0)
            {
                Console.WriteLine("Course added!");
            }
            else
            {
                Console.WriteLine("Course doesn't exist!");
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Course> GetCourses()
    {
        try
        {
            var connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd =
                "Select * from Courses";
            List<Course> courses = connection.Query<Course>(cmd).ToList();
            Console.WriteLine("Courses : ");
            return courses;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void UpdateCourse(Course course)
    {
        try
        {
            var connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd  = "Update Courses set Id = @Id,Name = @Name,Description = @description,CreateDate = @CreateDate,EndDate = @EndDate,TeacherId = @TeacherId,StudentId = @StudentId where Id = @Id";
            var effect = connection.Execute(cmd, course);
            if (effect != 0)
            {
                Console.WriteLine("Course Updated !");
            }

            else
            {
                Console.WriteLine("Courses is not updated");
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteCourse(int courseId)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd  = "Delete from Courses where Id = @Id";
            var effect = connection.Execute(cmd, courseId);
            Console.WriteLine("Course Deleted !");
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public Course GetCourseById(int courseId)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Select * from Courses where Id = @Id";
            var course = connection.Query<Course>(cmd, new { Id = courseId }).FirstOrDefault();
            return course;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

