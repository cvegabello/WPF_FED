using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfFEDSubMenu.ViewModel;

namespace WpfFEDSubMenu.Model
{
    // Tab Control
    
    public class TabControlItems : ViewModelBase
    {
        public string TCName { get; set; }
        public string TCImage { get; set; }
        public string TagCombo { get; set; }
        public object dataSourceCombo { get; set; }
        public string DisplayMemberPath { get; set; }
        public double WidthCombo { get; set; }
        private bool _IsReadOnly;
        public bool IsReadOnly
        {
            get
            {
                return _IsReadOnly;
            }
            set
            {
                _IsReadOnly = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }
    }

    public class ItemsCarlosCombo1
    {
        public string ICName { get; set; }
        public string ICLastName { get; set; }
    }

    public class ItemsCarlosCombo2
    {
        public string ICName { get; set; }
        public string ICLastName { get; set; }
    }
}
