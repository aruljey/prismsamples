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
        private ObservableCollection<string> _message;

        [ImportingConstructor]
        public MessageListViewModel()
        {
            EventAggregatorService.EventService.GetEvent<MsgSendEvent>().Subscribe(MessageReceived);
        }

        public ObservableCollection<string> Messages
        {
            get
            {
                if(_message==null)
                {
                    _message = new ObservableCollection<string>();
                }
                return _message;
            }
            set
            {
                SetProperty(ref _message, value);
            }
        }

        //[ImportingConstructor]
        //public MessageListViewModel(IEventAggregator ea)
        //{
        //    _ea = ea;
        //    Messages = new ObservableCollection<string>();
        //    var myEvent = _ea.GetEvent<MsgSendEvent>();
        //    if (myEvent != null)
        //        myEvent.Subscribe(MessageReceived, ThreadOption.UIThread, true);
        //    //_ea.GetEvent<MsgSendEvent>().Subscribe(MessageReceived,ThreadOption.UIThread);
        //}


        private void MessageReceived(string msg)
        {
            Messages.Add(msg);
        }

    }
}
