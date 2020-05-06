using SQLite.Data;
using SQLite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLite.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly DBPerson bDPerson;
        public ICommand SelectPersonCommand { get; private set; }
        public ICommand SavePersonCommand { get; private set; }

        private ObservableCollection<PersonModel> _persons;
        private PersonModel _person;

        public ObservableCollection<PersonModel> Persons 
        {
            get => _persons;
            set => SetProperty(ref _persons, value);
        }

        public PersonModel Person
        {
            get => _person;
            set => SetProperty(ref _person, value);
        }

        public MainPageViewModel()
        {
            bDPerson = new DBPerson();
            initCommands();
            initClass();
        }

        private void initClass()
        {
            Person = new PersonModel();
            Persons = new ObservableCollection<PersonModel>(bDPerson.GetItemsAsync().Result);
        }

        private void initCommands()
        {
            SelectPersonCommand = new Command<PersonModel>(SelectPerson);
            SavePersonCommand = new Command(SavePerson);
        }

        private void SavePerson()
        {
            //Person.BirthDate = DateTime.Now.AddDays((new Random()).Next(1,30));
            bDPerson.Save(Person);
            if (Person.Id == 0)
            {
                Persons.Add(Person);
            }
            Person = new PersonModel();
        }

        private void SelectPerson(PersonModel person)
        {
            Person = person;
        }
    }
}
