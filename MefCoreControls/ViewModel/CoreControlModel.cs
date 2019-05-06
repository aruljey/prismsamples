using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefCoreControls.ViewModel
{
    [Export(typeof(CoreControlModel))]
    class CoreControlModel : BindableBase
    {
        private string title = "This is core control model 1";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value);
            }
        }
    }
}
