using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_GeekBrains_1.Model
{
    public class Book : INotifyPropertyChanged
    {
        string _Author;
        string _Title;

        public string Author
        {
            get { return _Author; }
            set { 
                _Author = value;
                OnPropertyChanged(nameof(Author));
            }
        }


        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
