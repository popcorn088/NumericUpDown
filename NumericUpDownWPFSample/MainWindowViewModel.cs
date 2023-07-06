using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericUpDownWPFSample
{
    class MainWindowViewModel
    {
        private decimal _Volume = 0.5m;
        public decimal Volume
        {
            get
            {
                return _Volume;
            }
            set
            {
                _Volume = value;
            }
        }
    }
}
