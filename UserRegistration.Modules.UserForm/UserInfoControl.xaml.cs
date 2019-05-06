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


namespace UserRegistration.Modules.UserForm
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 
    [Export(typeof(UserInfoControl))]
    public partial class UserInfoControl : UserControl
    {
        [ImportingConstructor]
        public UserInfoControl()
        {
            InitializeComponent();
        }
    }
}
