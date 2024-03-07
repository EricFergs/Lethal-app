using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tutorial.Core;

namespace Tutorial.MVVM.ViewModel
{
    internal class ScrapCalcModel : ObservableObjects
    {

        //fields
        private string _total;
        private string _sold;
        private string _result = "Remaining";


        //properties
        public RelayCommand ButtonClick { get; set; }
        public string Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        public string Sold
        {
            get { return _sold; }
            set { SetProperty(ref _sold, value); }
        }

        public string Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        //Constructor
        public ScrapCalcModel() {
            ButtonClick = new RelayCommand(o =>
            {
                try
                {
                    int convertedTotal = int.Parse(Total);
                    int convertedSold = int.Parse(Sold);
                    int final = convertedTotal - convertedSold;
                    Result = final.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hey only numbers >:(");
                }
            });
        }
    }
}
