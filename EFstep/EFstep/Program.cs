using EFstep.DAL;
using EFstep.Models;

namespace EFstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
          AppDbContext context=new AppDbContext();

            //Student student=new Student
            //{
            //    Name="Sabuhi",
            //    Surname="Camalzade",
            //    Age=19
            //};

            //context.Students.Add(student);
            //context.SaveChanges();


            //Student existed=context.Students.FirstOrDefault(s => s.Id == 2);
            //Student existed=context.Students.Find(2);

            // existed.Name = "Sabuhi234";

            // //context.Students.Update(existed);
            // context.SaveChanges();
            //if (existed != null)
            //{
            //    context.Students.Remove(existed);
            //    context.SaveChanges();
            //}


            //if (existed != null)
            //{
            //    Console.WriteLine(existed.Name + " " + existed.Surname);
            //}


           List<Student> students= context.Students.Where(s=>s.Age>=18).ToList();

            foreach (Student student in students) {
                Console.WriteLine(student.Name+" "+student.Age);
            
            }


        }
    }
}