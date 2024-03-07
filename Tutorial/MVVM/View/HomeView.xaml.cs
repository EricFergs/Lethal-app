using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Sold.TextChanged += TextBox_TextChanged;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // This will be triggered when the Text property of TextBox changes
            
        }


    }
}
