using ADONETIntro.Models;
using ADONETIntro.Services;
using System.Data;
using System.Data.SqlClient;

namespace ADONETIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ado intro example
            //string conn = "server=MSI;database=AdoNetExample;trusted_connection=true;integrated security=true;";

            //SqlConnection connection = new SqlConnection(conn);
            //connection.Open();

            //string cmd = "INSERT INTO Students VALUES('Test','Testov',26)";
            //SqlCommand command = new SqlCommand(cmd, connection);

            //int result = command.ExecuteNonQuery();

            //if (result > 0)
            //{
            //    Console.WriteLine("Command successfully completed");
            //}
            //else
            //{
            //    Console.WriteLine("Erro occured");
            //}

            //connection.Close();


            //connection.Open();
            //string query = "SELECT * FROM Students";
            //SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            //DataTable table = new DataTable();

            //adapter.Fill(table);
            //connection.Close();

            //foreach (DataRow row in table.Rows)
            //{
            //    Console.WriteLine(row["Id"]+" " + row["Name"]+" "+ row["Surname"]+" " + row["Age"]);
            //} 
            #endregion




            StudentService service=new StudentService();

            //Student student = new Student
            //{
            //    Age = 23,
            //    Name = "Nigar",
            //    Surname = "QuizKiller"
            //};

            //service.Add(student);

            service.Delete(5);


            List<Student> students = service.GetAll();


            foreach (Student item in students)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Surname+" "+item.Age);
            }



        }
    }
}