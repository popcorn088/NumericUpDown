using NumericUpDown.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericUpDown
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private NumericUpDownViewModel _numericUpDownViewModel = new NumericUpDownViewModel();
        public NumericUpDownViewModel NumericUpDownViewModel
        {
            get
            {
                return _numericUpDownViewModel;
            }
            set
            {
                _numericUpDownViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NumericUpDownViewModel)));
            }
        }
    }
}
