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
using Prism.Modules.INotifySample.Model;


namespace Prism.Modules.INotifySample
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    /// 
    [Export(typeof(StudentView))]
    public partial class StudentView : UserControl
    {
        [ImportingConstructor]
        public StudentView(StudentViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
