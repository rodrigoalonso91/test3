using System;

namespace test3
{
    public class Person
    {
        public int NationalId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthday { get; private set; }
        public byte Age  { get; private set; }
        public string Genre { get; private set; }
        public string Job { get; private set; }

        public Person(int NationalId, string FirstName, string LastName, DateTime Birthday, byte Age, string Genre, string Job)
        {
            this.NationalId = NationalId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.Age = Age;
            this.Genre = Genre;
            this.Job = Job;
        }

        /// <summary>
        /// Muestra en consola los datos basicos de la persona
        /// </summary>
        public void GetPersonData()
        {
            Console.WriteLine($"Full name: {this.FirstName} {this.LastName}\n" +
                $"Id: {this.NationalId}\n" +
                $"Birthday: {this.Birthday.ToString("d MMM yyyy")}\n" +
                $"Age: {this.Age}\n" +
                $"Genre: {this.Genre}\n" +
                $"Job: {this.Job}");
        }

    }
}
