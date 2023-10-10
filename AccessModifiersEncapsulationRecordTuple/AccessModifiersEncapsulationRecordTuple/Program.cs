using AccessModifiersEncapsulationRecordTuple.Models;

namespace AccessModifiersEncapsulationRecordTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Access modifiers/specifiers Encapsulation

            //User user = new User("Sabir", "Guliyev");
            //User user2 = user;
            //user2.Name = "Aqil";

            //Console.WriteLine(user);



            //user.Name = name;
            //user.Password = Console.ReadLine(); 
            #endregion

            #region Record and init
            //Person person = new Person("Sabir","Guliyev");
            //Person person2 = new Person("Sabir","Guliyev");
            //Console.WriteLine(person);


            //PersonRecord personrecord = new PersonRecord("sabuhi", "camalzade");
            //personrecord =personrecord with 
            //{ 
            //    Name="Aqil"
            //};

            //Console.WriteLine(personrecord);

            //personRecord.Name = "Aqil";
            //PersonRecord personRecord = new PersonRecord
            //{
            //    Name="Sabuhi",
            //    Surname="Camalzade"
            //};

            //personRecord.Name = "Aqil";


            //PersonRecord personRecord2 = new PersonRecord("Sabuhi","Camalzade");
            //Console.WriteLine(personRecord==personRecord2);
            //Console.WriteLine(personRecord); 
            #endregion

            #region Tuple and ValueTuple
            //Tuple
            //string monthName = "Yanvar";
            //int days = 31;

            //(string Name, int Day) month = (Console.ReadLine(), 31);
            //month.Item1 = "Fevral";
            //month.Item2 = 29;

            //month.Item1 = "Mart";
            //month.Day = 30;
            //Console.WriteLine(month);

            //(string Name,int Day) month = Tuple.Create("Yanvar", 31).ToValueTuple();

            //Console.WriteLine(month);

            //int[] numbers = { 7, 1, 9, 11, 3, 5, 4 };

            //var result = GetMinMax(numbers);

            //Console.WriteLine(result);

            //int a = 5;
            //int b= 10;

            //(a, b) = (b, a);



            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            #endregion

            #region DateTime
            //User user = new User("Sabir", "Guliyev");

            //Console.WriteLine(user.RegisteredAt);
            //Console.ReadLine();
            //Console.WriteLine(user.RegisteredAt); 
            #endregion


        }

        //public static (int Min,int Max) GetMinMax(int[] arr)
        //{
        //    return (arr.Min(), arr.Max());
        //}

        //public static void GetMonth((string Name,int Day) month)
        //{
            
        //}
    }

    public class User
    {
        private string _name;
        private string _surname;
        string _username;
        string _password;

        private DateTime _registeredAt;
        public DateTime RegisteredAt
        {
            get { return _registeredAt; }
           
        }

        //Property
        public string Password { set { _password = value; } }
        public string Username { get { return _username; }  }
        public string Name { 
            get
            {
                return _name;
            } 
            set 
            {
                value = value.Trim();
                if (value.Length >= 3 && value.Length <= 25)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Deyer yanlishdir");
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 3 && value.Length <= 25)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Deyer yanlishdir");
                }
            }
        }
        

        //public int Age { get; set; }
        public User(string name,string surname)
        {
            Name = name;
            Surname = surname;

            _username = Name + "." + Surname;

            _registeredAt = DateTime.Now;

           _registeredAt= _registeredAt.AddYears(40);
        }

        //public void SetName(string name)
        //{
        //    name = name.Trim();
        //    if (name.Length>=3&&name.Length<=25)
        //    {
        //        Name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Deyer yanlishdir");
        //    }
        //}

        //public string GetName()
        //{
        //    return Name;
        //}
        

    } 

  
}