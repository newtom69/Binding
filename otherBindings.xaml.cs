using Binding.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Binding
{
    /// <summary>
    /// Logique d'interaction pour otherBindings.xaml
    /// </summary>
    public partial class otherBindings : Window
    {
        public PersonData _personne = new PersonData();

        private static IList<PersonData> listePersonnes = new List<PersonData>();

        public otherBindings()
        {
            InitializeComponent();
            DataContext = _personne;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_personne.Age >= 18 && _personne.Age <= 120
                && _personne.Nom.Length >= 2 && _personne.Nom.Length <= 30
                && _personne.Prenom.Length >= 2 && _personne.Prenom.Length <= 30)
            {
                PersonData personneValidee = new PersonData(_personne.Nom, _personne.Prenom, _personne.Age);
                listePersonnes.Add(personneValidee);
                AfficheListePersonnes();
            }

            if (_personne.Age < 18 || _personne.Age > 120)
                 bordureAge.BorderBrush = Brushes.Red;
            else bordureAge.BorderBrush = Brushes.Transparent;

            if (_personne.Nom.Length < 2 || _personne.Nom.Length > 30)
                 bordureNom.BorderBrush = Brushes.Red;
            else bordureNom.BorderBrush = Brushes.Transparent;

            if (_personne.Prenom.Length < 2 || _personne.Prenom.Length > 30)            
                 bordurePrenom.BorderBrush = Brushes.Red;
            else bordurePrenom.BorderBrush = Brushes.Transparent;
        }

        private void AfficheListePersonnes()
        {
            affichageListe.Items.Clear();
            foreach (PersonData person in listePersonnes)
            {
                affichageListe.Items.Add(person.Fullname);
            }
        }

        private void BoutonEffacer(object sender, RoutedEventArgs e)
        {
            int dernier = listePersonnes.Count - 1;
            if (dernier >= 0)
            {
                listePersonnes.RemoveAt(dernier);
                AfficheListePersonnes();
            }
        }
    }
}

