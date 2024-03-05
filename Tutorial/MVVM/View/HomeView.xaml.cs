using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Tutorial.MVVM.ViewModel;

namespace Tutorial.MVVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            this.DataContext = new HomeViewModel();
        }

        private void run_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
