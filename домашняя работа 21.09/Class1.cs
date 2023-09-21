using System.Text;
using System.Threading.Tasks;

namespace дз_на_21._09
{
    public class Person
    {
        public int age; public string name;
        public string town; public string PIN;
        public Person(string name, string town, int age, string PIN)
        {
            this.name = name; this.town = town;
            this.PIN = PIN; this.age = age;
        }
        public override string ToString()
        {
            return string.Format("Человек по имени {0}, проживающий в {1}, имеет такой PIN: {2}. Ему {3} лет", name, town, PIN, age);
        }
    }
}
