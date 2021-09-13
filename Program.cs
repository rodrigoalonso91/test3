using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person(NationalId: 12345678, FirstName: "Bill", LastName: "Gates", 
                Birthday: new DateTime(1955,10,28), Age: 65, Genre: "Male", Job: "Dev");

            person1.GetPersonData();
            
        }
    }
}
