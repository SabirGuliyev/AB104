
//ctrl+r+g
//namespace NamespaceExample.Models.Base.Example
namespace NamespaceExample.Models
{
    internal class Person
    {
        public const string WiFiPass="sabir123";
        //public int A { get; set; }

        public readonly string _surname;

        //Get only Auto Property
        public string Name { get; }


        private string _group;

        public string Group { get { return _group; } }


        //public Person(string group,string name)
        //{
        //    _group = group;
        //    Name = name;
        //}


        //------------------------------- Yuxaridakilar Object Init sintaksisi ile ishlemir
        public byte Age { get; init; }

        //public Person(string surname, string name,byte age)
        //{
        //    _surname = surname;
        //    Name = name;
        //    Age = age;
        //}
    }
}
