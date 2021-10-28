using System;
using System.Linq;
using System.Text;
using TeamTalkStation_TTS_Client.Libraries.Models;
using TeamTalkStation_TTS_Client.Libraries.MessageTypes;

namespace TeamTalkStation_TTS_Client.Models
{
    public class TextMessage : MessageBase
    {
        public string Content { get; set; } 

        public TextMessage(string content, string authorUsername)
        {
            AuthorUsername = authorUsername;

            StringBuilder stringBuilder = new StringBuilder(content);

            string MyContent = stringBuilder.Append(@"\0.").ToString();
            
            Console.WriteLine(MyContent);
            
            Content = content;
        }



        internal override MessagePayload ToMessagePayload()
        {
            return new MessagePayload(ObjectToString(Content), Libraries.MessageTypes.MessageType.Text) { AuthorUsername = AuthorUsername };
        }

        internal TextMessage(MessagePayload payload)
        {
            AuthorUsername = payload.AuthorUsername;
            Content = StringToObject<string>(payload.Base64Payload);
        }
             
    }
}
