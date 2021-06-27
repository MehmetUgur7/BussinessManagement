using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFManagement.Models;

namespace WPFManagement.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Mehmet", LastName = "Uğur" });
            People.Add(new PersonModel { FirstName = "Gökhan", LastName = "Kerman" });
            People.Add(new PersonModel { FirstName = "Rüstem", LastName = "Bütün" });
        }
        private string _fistName = "Mehmet";

        public string FirstName
        {
            get { return _fistName; }
            set
            {
                _fistName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }            
        }

        private BindableCollection<PersonModel> _people=new BindableCollection<PersonModel>();

        public BindableCollection<PersonModel> People

        {
            get { return _people; }
            set { _people = value; }
        }

        private PersonModel _selectedPerson;

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set 
            { 
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            //return !String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName);
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}
