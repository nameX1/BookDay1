using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp3.Models
{
    class DateBook: INotifyPropertyChanged
    {
        public string CreationDate
        {
            get { return _CreationDate; }
            set
            {
                if (_CreationDate == value)
                    return;
                _CreationDate = value;
                OnPropertyChanged("IsDone");
            }

        }
        private string _CreationDate;
        private bool _isDone;
        private string _text;

        

        public bool IsDone
        {
            get { return _isDone; }
            set 
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }
    }

}
