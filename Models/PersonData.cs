namespace Binding.Models
{
    public class PersonData
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public string Fullname {
            get => $"{Nom} {Prenom}, age : {Age} ans";
            set { }
        }

        public PersonData()
        {
            Nom = "";
            Prenom = "";
            Age = 0;
        }
        public PersonData(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
    }
}
