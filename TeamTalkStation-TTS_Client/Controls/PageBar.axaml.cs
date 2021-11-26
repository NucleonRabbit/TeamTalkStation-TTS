using Avalonia;
using Avalonia.Controls;
using TeamTalkStation_TTS_Client.ViewModels;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using TeamTalkStation_TTS_Client.Views;

namespace TeamTalkStation_TTS_Client.Controls
{
    class PageBar : UserControl
    {
        public PageBar()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        // public async void PersonalInformationWindowShowDialog()
        // {
        //     var window = new PersonalInformationWindow();
        //
        //    
        //     
        //     await window.ShowDialog<object?>(Window);
        //     
        // }
        //
        // public void Personal(object? sender, RoutedEventArgs e,object t)
        // {
        //     PersonalInformationWindowShowDialog();
        //     
        // }
        //
        
    }
}