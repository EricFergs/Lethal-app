using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Core;
using Tutorial.MVVM.View;

namespace Tutorial.MVVM.ViewModel
{
    class MainViewModel : ObservableObjects
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand ScrapCalcCommand { get; set; }

        public HomeViewModel HomeVM{ get; set; }

        public ScrapCalcModel Calc { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            Calc = new ScrapCalcModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });
            ScrapCalcCommand = new RelayCommand(o =>
            {
                CurrentView = Calc;
            });
        }
    }
}
