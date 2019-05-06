using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
using Prism.Modularity;

namespace PrismMefModules
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [Export]
    public partial class CoreShell : Window
    {
        //IModuleManager _moduleManager;
        public CoreShell()
        {
            InitializeComponent();
            //_moduleManager = moduleManager;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //_moduleManager.LoadModule("CoreControlModule");
        }
    }
}
