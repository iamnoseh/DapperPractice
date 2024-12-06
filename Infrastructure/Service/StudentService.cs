using Dapper;
using Infrastructure.Interface;
using Model.Students;
using Npgsql;

namespace Infrastructure.Service;

public class StudentService: IStudentService
{
    public void AddStudent(Student student)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd =
                "Insert into Students(id,Full_name,Age,Phone,Address,Email) values (@id,@full_name, @age, @phone, @address, @email)";
            connection.Execute(cmd, student);
            Console.WriteLine("Student added !");
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

    public List<Student> GetStudents()
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd =
                "Select * from Students";
            List<Student> students = connection.Query<Student>(cmd).ToList();
            Console.WriteLine("Students :");
            return students;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteStudentById(int id)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Delete from Students where id = @id";
            connection.Execute(cmd, new {id = id});
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

    public Student GetStudentById(int id)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Select * from Students where id = @id";
           Student student = connection.Query(cmd,new {id = id}).FirstOrDefault();
           return student;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void UpdateStudent(Student student)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Update Students set Full_Name = @Full_Name,Age = @Age,Phone = @Phone,Address = @Address where id = @id";
            connection.Execute(cmd, student);
            Console.WriteLine("Student updated !");
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