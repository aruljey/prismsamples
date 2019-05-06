using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using UserRegistration.Modules.UserForm;

namespace UserRegistration
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<CoreShell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (CoreShell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(GetType().Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(UserInfoModule).Assembly));
        }
    }
}
