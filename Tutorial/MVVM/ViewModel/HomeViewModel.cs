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
        private string _quotavalue;
        private string _total = "Total";
        public RelayCommand ButtonClick { get; set; }
        public string soldValue
        {
            get { return _soldvalue; }
            set { _soldvalue = value; OnPropertyChanged(); }
        }

        public string quotaValue
        {
            get { return _quotavalue; }
            set { _quotavalue = value; OnPropertyChanged(); }
        }
        public string Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged(); }
        }
        public HomeViewModel()
        {
            ButtonClick = new RelayCommand(o =>
            {

                Total = soldValue + quotaValue;
            });
        }
        
    }

}
