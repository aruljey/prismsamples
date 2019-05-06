using Prism.Mvvm;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EventAggregator.Core;
using System.ComponentModel.Composition;

namespace ModuleB.ViewModel
{
    [Export(typeof(MessageListViewModel))]
    public class MessageListViewModel : BindableBase
    {
        IEventAggregator _ea;
        private ObservableCollection<string> _message;

        public ObservableCollection<string> Messages
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        [ImportingConstructor]
        public MessageListViewModel(IEventAggregator ea)
        {
            _ea = ea;
            Messages = new ObservableCollection<string>();
            _ea.GetEvent<MsgSendEvent>().Subscribe(MessageReceived);
        }


        private void MessageReceived(string msg)
        {
            Messages.Add(msg);
        }

    }
}
