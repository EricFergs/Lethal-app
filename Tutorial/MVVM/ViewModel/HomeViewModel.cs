using System.Text;
using System.Threading.Tasks;
using Tutorial.Core;
using Tutorial.MVVM.View;
using System;
using System.Configuration;
using System.Xml;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows;



namespace Tutorial.MVVM.ViewModel
{
    class HomeViewModel : ObservableObjects
    {
        private string _soldvalue;
        private string _quotavalue;
        private string _total = "Total";
        private string _result = "Result";

        public RelayCommand ButtonClick { get; set; }
        public string SoldValue
        {
            get { return _soldvalue; }
            set { SetProperty(ref _soldvalue, value); }
        }

        public string QuotaValue
        {
            get { return _quotavalue; }
            set { SetProperty(ref _quotavalue, value); }
        }
        public string Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged(); }
        }
        public string Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged(); }
        }
        public HomeViewModel()
        {
            ButtonClick = new RelayCommand(o =>
            {

                try
                {
                    int convertedQuota = int.Parse(QuotaValue);
                    int convertedSold = int.Parse(SoldValue);
                    int final = ((convertedSold - convertedQuota) / 5) - 15;
                    Result = final.ToString();
                    Total = (final + convertedSold).ToString();
                }
                catch(FormatException)
                {
                    MessageBox.Show("Hey only numbers >:(");
                }
            });
        }
        
    }

}
