using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TeamTalkStation_TTS_Client.Views
{
    public class GroupChatPageView : UserControl
    {
        public GroupChatPageView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}