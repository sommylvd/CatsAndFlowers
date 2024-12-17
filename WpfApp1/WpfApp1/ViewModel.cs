using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string photo = "C:\\Users\\STUDENT\\Documents\\CatsAndFlowers\\WpfApp1\\WpfApp1\\assetscats";
        public Image Imag;
        

        public ViewModel() 
        {

        }
        void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
