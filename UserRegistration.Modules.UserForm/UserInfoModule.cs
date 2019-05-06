using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Mef.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace UserRegistration.Modules.UserForm
{
    [ModuleExport(typeof(UserInfoModule))]
    public class UserInfoModule : IModule
    {
        IRegionManager _regionManager;

        [ImportingConstructor]
        public UserInfoModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            IRegionManager region = _regionManager.RegisterViewWithRegion("UserRegion", typeof(UserInfoControl));
        }
    }
}
