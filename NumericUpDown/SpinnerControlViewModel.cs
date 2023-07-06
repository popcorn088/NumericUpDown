using NumericUpDown.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NumericUpDown
{
    public class SpinnerControlViewModel : INotifyPropertyChanged
    {
        public DelegateCommand UpRepeatCommand { get; }
        public DelegateCommand DownRepeatCommand { get; }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _Message = "";
        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                if (value != _Message)
                {
                    Message = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public SpinnerControlViewModel()
        {
            UpRepeatCommand = new DelegateCommand(UpRepeatCommandExecute);
            DownRepeatCommand = new DelegateCommand(DownRepeatCommandExecute);
        }

        private decimal _Value;
        public decimal Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (_Value == value)
                {
                    return;
                }

                _Value = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }

        private decimal _Nick;

        public decimal Nick
        {
            get
            {
                return _Nick;
            }
            set
            {
                if (_Nick == value)
                {
                    return;
                }

                _Nick = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Nick)));
                }
            }
        }

        public decimal _Maximum;
        public decimal Maximum
        {
            get
            {
                return _Maximum;
            }
            set
            {
                if (_Maximum == value)
                {
                    return;
                }

                _Maximum = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Maximum)));
                }
            }
        }

        public decimal _Minimum;
        public decimal Minimum
        {
            get
            {
                return _Minimum;
            }
            set
            {
                if (_Minimum == value)
                {
                    return;
                }

                _Minimum = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Minimum)));
                }
            }
        }
        private void UpRepeatCommandExecute()
        {
            if (Value + Nick >= Maximum)
            {
                Value = Maximum;
            }
            else
            {
                Value += Nick;
            }
        }
        private void DownRepeatCommandExecute()
        {
            if (Value - Nick <= Minimum)
            {
                Value = Minimum;
            }
            else
            {
                Value -= Nick;
            }
        }
    }
}
