using HomeworkADONET.Data;
using HomeworkADONET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkADONET.Services
{
    internal class ArtistService
    {
        Sql _database = new Sql();

        public void Add(Artist artist)
        {
            string cmd = $"INSERT INTO Artists VALUES('{artist.Name}','{artist.Surname}','{artist.BirthDate}','{artist.Gender}')";
            int result = _database.ExecuteCommand(cmd);
            if (result > 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }


        public List<Artist> GetAll()
        {
            string query = "SELECT * FROM Artists";
            DataTable table= _database.ExecuteQuery(query);


            List<Artist> artists=new List<Artist>();
            foreach (DataRow row in table.Rows)
            {
                artists.Add(new Artist
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Surname = row["Surname"].ToString(),
                    Gender = row["Gender"].ToString(),
                    BirthDate = (DateTime)row["BirthDate"]

                });
            }

            return artists;

        }
    }
}
