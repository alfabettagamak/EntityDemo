using System.Collections.Generic;

namespace EntityDemo.models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }

        public ICollection<Car> Cars;
        public ICollection<Animal> Animals;
    }
}