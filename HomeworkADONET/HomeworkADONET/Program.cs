using HomeworkADONET.Models;
using HomeworkADONET.Services;

namespace HomeworkADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MusicService service = new MusicService();

            //Music music = new Music { Name = "Lithium", CategoryId =1, Duration = 376 };

            //service.Add(music);


            ArtistService service = new ArtistService();


            //Artist artist = new Artist
            //{
            //    Name = "Adam",
            //    Surname = "Gontier",
            //    BirthDate = DateTime.Now,
            //    Gender = "male"
            //};

            //service.Add(artist);


            service.GetAll().ForEach(x => Console.WriteLine(x.Name+" "+x.BirthDate));
        }
    }
}