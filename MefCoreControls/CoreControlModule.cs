using Prism.Modularity;
using Prism.Mef.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using System.ComponentModel.Composition;
using MefCoreControls.View;

namespace MefCoreControls
{
    [ModuleExport(typeof(CoreControlModule))]
    public class CoreControlModule : IModule
    {
        IRegionManager _regionManager;

        [ImportingConstructor]
        public CoreControlModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            IRegionManager manager = _regionManager.RegisterViewWithRegion("ContentRegion", typeof(CoreControlView1));
            manager=_regionManager.RegisterViewWithRegion("SideRegion", typeof(CoreControlView2));
        }
    }
}
