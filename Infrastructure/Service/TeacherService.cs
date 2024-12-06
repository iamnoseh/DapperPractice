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
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Insert into teachers(Full_Name,Age,Address,Email,Phone) values(@Full_Name,@Age,@Address,@Email,@Phone)";
            connection.Execute(cmd, taecher);
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
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Update Teachers set Full_Name = @Full_Name,Age = @Age,Address = @Address,Email = @Email,Phone = @Phone";
            int res = connection.Execute(cmd, taecher);
            if (res != 0)
            {
                Console.WriteLine("Teacher updated!");
            }
            else
            {
                Console.WriteLine("Teacher not updated!");
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

    public void DeleteTaecher(int id)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Delete from teachers where id = @id";
            int res = connection.Execute(cmd, new { id = id });
            if (res != 0)
            {
                Console.WriteLine("Teacher deleted!");
            }
            else
            {
                Console.WriteLine("Teacher not deleted!");
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

    public Teacher GetTaecherById(int id)
    {
        try
        {
            string connectionString = "Server=127.0.0.1;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Select * from teachers where id = @id";
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
            string connectionString = "Server=localhost;Port=5432;Database=coursedb;User Id=postgres;Password=12345;";
            using var connection = new NpgsqlConnection(connectionString);
            string cmd = "Select * from teachers";
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