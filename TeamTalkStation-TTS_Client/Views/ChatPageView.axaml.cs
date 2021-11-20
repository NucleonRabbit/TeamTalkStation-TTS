using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TeamTalkStation_TTS_Client.Views
{
    public class ChatPageView : UserControl
    {
        public ChatPageView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}