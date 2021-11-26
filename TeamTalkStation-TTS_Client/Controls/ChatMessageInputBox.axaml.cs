using System;
using System.Linq;
using System.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using TeamTalkStation_TTS_Client.GlobalVariables;
using TeamTalkStation_TTS_Client.Views;

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

        private void SendMessageButtonOnClick(object? sender, RoutedEventArgs e)
        {

            ChatBubble bubble = new ChatBubble();

            StringBuilder sb = new StringBuilder("My name is Nucleon14");
            sb.Append(" ");
            bubble.IsRead = true;
            bubble.Content = sb.ToString();
            
            DoubleChatView.MessagePanel.Children.Add(bubble);
            //DoubleChatView.ChatMessageViewer.ScrollToHome();
            DoubleChatView.ChatMessageViewer.ScrollToEnd();
        }
    }
}