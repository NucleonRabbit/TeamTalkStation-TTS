using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TeamTalkStation_TTS_Client.Views
{
    public class DoubleChatView : UserControl
    {
        public static StackPanel MessagePanel;

        public static ScrollViewer ChatMessageViewer;
        public DoubleChatView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);


            ChatMessageViewer = this.FindControl<ScrollViewer>("ChatMessageViewer");
            
            MessagePanel = this.FindControl<StackPanel>("MessagePanel");
        }
    }
}