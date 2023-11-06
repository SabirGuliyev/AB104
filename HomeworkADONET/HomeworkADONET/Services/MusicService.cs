using HomeworkADONET.Data;
using HomeworkADONET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkADONET.Services
{
    internal class MusicService
    {

        Sql _database = new Sql();


        public void Add(Music music)
        {
            string query = $"INSERT INTO Musics VALUES('{music.Name}',{music.Duration},{music.CategoryId})";
            int result=_database.ExecuteCommand(query);
            if (result>0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
