using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TeamTalkStation_TTS_Client.GlobalVariables;

namespace TeamTalkStation_TTS_Client.Controls
{
    public class ChatMessageInputBox : UserControl
    {
        private TextBox InputBox;

        public ChatMessageInputBox()
        {

                        
            
            InitializeComponent();
            
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            InputBox = this.FindControl<TextBox>("InputBox");
            
        }
    }
}