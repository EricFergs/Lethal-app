using System.Text;
using System.Threading.Tasks;
using Tutorial.Core;
using Tutorial.MVVM.View;
using System;

namespace Tutorial.MVVM.ViewModel
{
    class HomeViewModel : ObservableObjects
    {
        private string _soldvalue;
        public string Soldvalue
        {
            get { return _soldvalue; }
            set { _soldvalue = "21"; OnPropertyChanged(); }
        }

    }

}
