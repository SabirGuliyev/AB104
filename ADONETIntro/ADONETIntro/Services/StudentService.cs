using ADONETIntro.Data;
using ADONETIntro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETIntro.Services
{
    internal class StudentService
    {
        private Sql _database=new Sql();


        public void Add(Student student)
        {


            string cmd = $"INSERT INTO Students VALUES('{student.Name}','{student.Surname}',{student.Age})";
            int result= _database.ExecuteCommand(cmd);
            if (result>0)
            {
                Console.WriteLine("Command successfully completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }

        }

        public List<Student> GetAll()
        {
            string query = "SELECT * FROM Students";
            DataTable table= _database.ExecuteQuery(query);

            List<Student> students = new List<Student>();

            foreach (DataRow row in table.Rows)
            {
               Student student = new Student
               {
                   Id = (int)row["id"],
                   Name = row["name"].ToString(),
                   Surname = row["surname"].ToString(),
                   Age = Convert.ToInt32(row["age"])
                   
               };
                students.Add(student);
            }
            return students;
        }

        public void Delete(int id)
        {
            string cmd = $"DELETE FROM Students WHERE Id={id}";
            _database.ExecuteCommand(cmd);
        }

    }
}
