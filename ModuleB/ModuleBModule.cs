using ModuleB.Views;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using EventAggregator.Core;

namespace ModuleB
{
    [ModuleExport(typeof(ModuleBModule))]
    public class ModuleBModule : IModule
    {

        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public ModuleBModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }



        public void Initialize()
        {
            IRegionManager region = _regionManager.RegisterViewWithRegion("RightRegion", typeof(MessageList));
        }
    }
}
