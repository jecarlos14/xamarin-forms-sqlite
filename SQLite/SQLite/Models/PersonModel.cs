using System;
using System.ComponentModel;

namespace SQLite.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // if there is any subscribers 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _idCard;
        private string _name;

        public string IdCard 
        { 
            get => _idCard;
            set 
            {
                if (_idCard == value) return;

                _idCard = value;
                OnPropertyChanged(nameof(IdCard));
            }
        }

        //public DateTime BirthDate { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;

                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }
}
