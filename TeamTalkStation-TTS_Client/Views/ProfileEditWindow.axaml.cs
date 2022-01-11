using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Text;



namespace TeamTalkStation_TTS_Client.Views
{

    public class ProfileEditWindow : Window
    {

        TextBlock b;

        public ProfileEditWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            b = this.FindControl<TextBlock>("MyText");

            b.Text = SkiaSharp.SKTypeface.Default.FamilyName;
        }
    }
}