using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TeamTalkStation_TTS_Client.Controls
{
    public class SendingChatBubble : UserControl
    {
        public SendingChatBubble()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}