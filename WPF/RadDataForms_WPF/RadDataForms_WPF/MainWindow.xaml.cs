using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadDataForms_WPF.ViewModel;
using Telerik.Windows.Controls;

namespace RadDataForms_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _vm=new MainViewModel();
        
        public MainWindow()
        {
            StyleManager.ApplicationTheme = new Windows8TouchTheme();
            InitializeComponent();
           
            radDataFormPL.ItemsSource=_vm.GetPatient();
        }
    }
}