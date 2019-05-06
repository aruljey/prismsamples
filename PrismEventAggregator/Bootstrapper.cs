using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ModuleA;
using ModuleB;
using Prism.Mef;

namespace PrismEventAggregator
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (MainWindow)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(GetType().Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleAModule).Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleBModule).Assembly));
        }
    }
}
