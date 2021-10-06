using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeamTalkStation_TTS_Client;
using TeamTalkStation_TTS_Client.Libraries.MessageTypes;
using TeamTalkStation_TTS_Client.Libraries.Models;
using TeamTalkStation_TTS_Client.Models;
using Avalonia.Controls.Notifications;
using Avalonia.Threading;
using System.Reactive.Linq;

namespace TeamTalkStation_TTS_Client.ViewModels
{
    public class ChatViewModel : ViewModelBase
    {        
        public ObservableCollection<MessageBase> Messages { get; private set; }

      

        public ChatViewModel() 
        {
            this.Messages = new ObservableCollection<MessageBase>();
            
            
            
            this.Messages.Add(new TextMessage("12332333333333333333333333333333333333333333333333333333333","Nucleon14_1"){
                Role = ChatRoleType.Sender
            });
            
 
           
        }

       
    }
}
