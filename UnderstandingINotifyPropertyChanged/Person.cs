using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingINotifyPropertyChanged
{
    public class Person : INotifyPropertyChanged
    {
        private string firstname;
        private string lastname;
        private string fullname;

        public string FirstName
        {
            get { return firstname; }
            set 
            {
                if (firstname != value)
                { 
                    firstname = value;
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                { 
                    lastname = value;
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }


        public string FullName
        {
            get { return fullname = firstname+ " " + lastname; }
            set
            {
                if (fullname != value)
                { 
                    fullname = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
