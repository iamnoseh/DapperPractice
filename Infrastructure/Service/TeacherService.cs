using Dapper;
using Infrastructure.Interface;
using Model.Teachers;
using Npgsql;

namespace Infrastructure.Service;

public class TeacherService:ITaecherService
{
    public void AddTaecher(Teacher taecher)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=CourseDB;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Insert into teacher(Full_Name,Age,Address,Email,Phone) values(@Full_Name,@Age,@Address,@Email,@Phone)";
            connection.Query(cmd, taecher);
            Console.WriteLine("Teacher added!");
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

    public void UpdateTeacher(Teacher taecher)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=CourseDB;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Upodaer Teachers set Full_Name = @Full_Name,Age = @Age,Address = @Address,Email = @Email,Phone = @Phone";
            connection.Query(cmd, taecher);
            Console.WriteLine("Teacher updated!");
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

    public void DeleteTaecher(int id)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=CourseDB;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Delete from teacher where id = @id";
            connection.Query(cmd, new { id = id });
            Console.WriteLine("Teacher deleted!");
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

    public Teacher GetTaecherById(int id)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=CourseDB;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Select * from teacher where id = @id";
            Teacher teacher = connection.Query<Teacher>(cmd,new {id = id}).FirstOrDefault();
            return teacher;
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

    public List<Teacher> GetTaechers()
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=CourseDB;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Select * from teacher";
            List<Teacher> teachers = connection.Query<Teacher>(cmd).ToList();
            Console.WriteLine("Teachers : ");
            return teachers;
            
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