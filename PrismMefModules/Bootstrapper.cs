using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Prism;
using Prism.Mef;
using Prism.Modules.INotifySample;

namespace PrismMefModules
{
    class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<CoreShell>();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(GetType().Assembly));   //Basic module setup

            //to discover the modules - do the following setup
            //add module catalog
            //var moduleCatalog = new DirectoryCatalog("Modules");   //disconvering modules
            //this.AggregateCatalog.Catalogs.Add(moduleCatalog);


            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MefCoreControls.CoreControlModule).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(StudentModule).Assembly));
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (CoreShell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        
    }
}
