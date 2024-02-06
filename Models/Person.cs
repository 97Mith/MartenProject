namespace WebApp.Models
{
    public class Person
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }

        public Person(string name, int age, string hairColor)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            HairColor = hairColor;
        }
    }
}
