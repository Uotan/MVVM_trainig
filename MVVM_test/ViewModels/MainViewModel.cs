using MVVM_test.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVM_test.Models;
using System.Windows.Input;
using System.Collections;
using System.Diagnostics;
using System.Windows.Media;
using System.Drawing;
using System.Windows;

namespace MVVM_test.ViewModels
{
    internal class MainViewModel : BaseVM, ICommand
    {
        private string _EditText;
        public string EditText
        {
            get { return _EditText; }

            set
            {
                _EditText = value;
                //OnPropertyChanged();
            }
        }


        private string _FinalText;
        public string FinalText
        {
            get { return _FinalText; }

            set
            {
                _FinalText = value;
                OnPropertyChanged();
            }
        }


        public ICommand Show
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    FinalText = EditText;
                    Debug.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                });
            }
        }


        public ICommand CommandGen4
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    MessageBox.Show("Четвертое поколение");
                });
            }
        }
        public ICommand CommandGen1
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    MessageBox.Show("Первое поколение");
                });
            }
        }
        public ICommand CommandGen2
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    MessageBox.Show("Второе поколение");
                });
            }
        }
        public ICommand CommandGen3
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    MessageBox.Show("Третье поколение");
                });
            }
        }
        public ICommand CommandGen5
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    MessageBox.Show("Пятое поколение");
                });
            }
        }

        public event EventHandler CanExecuteChanged;


        public MainViewModel()
        {
            //ImgSource = "Resources\\pc4.jpg";
        }

        //private string _ImgSource4 = "C:\\Users\\Uotan Heinz\\Downloads\\pc4.jpg";
        private string _ImgSource4 = "/Images/pc4.jpg";
        public string ImgSource4
        {
            get { return _ImgSource4; }

            set
            {
                _ImgSource4 = value;
                OnPropertyChanged();
            }
        }

        //private string _ImgSource1 = "C:\\Users\\Uotan Heinz\\Downloads\\pc1.jpg";
        private string _ImgSource1 = "/Images/pc1.jpg";
        public string ImgSource1
        {
            get { return _ImgSource1; }

            set
            {
                _ImgSource1 = value;
                OnPropertyChanged();
            }
        }

        //private string _ImgSource2 = "C:\\Users\\Uotan Heinz\\Downloads\\pc2.png";
        private string _ImgSource2 = "/Images/pc2.png";
        public string ImgSource2
        {
            get { return _ImgSource2; }

            set
            {
                _ImgSource2 = value;
                OnPropertyChanged();
            }
        }

        //private string _ImgSource3 = "C:\\Users\\Uotan Heinz\\Downloads\\pc3.jpg";
        private string _ImgSource3 = "/Images/pc3.jpg";
        public string ImgSource3
        {
            get { return _ImgSource3; }

            set
            {
                _ImgSource3 = value;
                OnPropertyChanged();
            }
        }

        //private string _ImgSource5 = "C:\\Users\\Uotan Heinz\\Downloads\\pc5.png";
        private string _ImgSource5 = "/Images/pc5.png";
        public string ImgSource5
        {
            get { return _ImgSource5; }

            set
            {
                _ImgSource4 = value;
                OnPropertyChanged();
            }
        }



        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
