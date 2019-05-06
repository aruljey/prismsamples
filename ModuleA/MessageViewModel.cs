using EventAggregator.Core;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModuleA
{
    [Export(typeof(MessageViewModel))]
    public class MessageViewModel : BindableBase
    {
        IEventAggregator _ea;
        private string _message = "Message to send";
        //private ICommand _sendMessageCommand;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand SendMessageCommand { get; private set; }

        //public ICommand SendMessageCommand
        //{
        //    get
        //    {
        //        if(_sendMessageCommand==null)
        //        {
        //            _sendMessageCommand = new RelayCommand(param => SendMessage(), null);
        //        }
        //        return _sendMessageCommand;
        //    }
        //}

        //public MessageViewModel()
        //{

        //}

        [ImportingConstructor]
        public MessageViewModel(IEventAggregator ea)
        {
            _ea = ea;
            SendMessageCommand =new DelegateCommand(SendMessage);
        }

        private void SendMessage()
        {
            _ea.GetEvent<MsgSendEvent>().Publish(Message);
        }
    }
}
