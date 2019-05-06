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

namespace MefCoreControls.View
{
    /// <summary>
    /// Interaction logic for CoreControl1.xaml
    /// </summary>
    /// 
    [Export(typeof(CoreControlView1))]
    public partial class CoreControlView1 : UserControl
    {
        public CoreControlView1()
        {
            InitializeComponent();
        }
    }
}
