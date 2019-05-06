using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Mef.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;


namespace Prism.Modules.INotifySample
{
    [ModuleExport(typeof(StudentModule))]
    public class StudentModule : IModule
    {
        IRegionManager _regionManager;

        [ImportingConstructor]
        public StudentModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            
            IRegionManager region = _regionManager.RegisterViewWithRegion("StudentRegion",typeof(StudentView));
        }
    }
}
