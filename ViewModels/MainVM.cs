using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickFreeMaui.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        public Command CurrentStatus => new Command( () => Status = "Please plugin ClickFree or DataLogixx device.");
        private string mstatus;

        public string Status
        {
            get
            {
                return mstatus;
            }
            set
            {
                if (mstatus != value)
                {
                    mstatus = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Status"));
                }

            }
        }
     

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
