using System.Collections.Generic;
using TeamTalkStation_TTS_Client.Libraries.MessageTypes;

namespace TeamTalkStation_TTS_Client.Libraries.Models
{
    public class SuccessfulLoginResponse
    {
        public User User { get; set; }

        public List<MessagePayload> PreviousMessages { get; set; }

        public List<User> Users { get; set; }

        public AccessToken AccessToken { get; init; }
    }
}
