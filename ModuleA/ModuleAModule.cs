using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Mef.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;
using EventAggregator.Core;

namespace ModuleA
{
    [ModuleExport(typeof(ModuleAModule))]
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public ModuleAModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }


        public void Initialize()
        {
            IRegionManager region = _regionManager.RegisterViewWithRegion("LeftRegion", typeof(MessageView));
        }
    }
}
