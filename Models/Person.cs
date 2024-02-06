namespace WebApp.Models
{
    public class Person
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }
        public Person(string name, int age, string hairColor)
        {
            
            Name = name;
            Age = age;
            HairColor = hairColor;
        }
    }
}
