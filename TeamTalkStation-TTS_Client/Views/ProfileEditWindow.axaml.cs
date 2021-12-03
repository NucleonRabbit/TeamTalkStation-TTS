using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using FluentAvalonia.UI.Controls;
using Button = Avalonia.Controls.Button;

namespace TeamTalkStation_TTS_Client.Views
{
    public class ProfileEditWindow : Window
    {


        private Button AvatarChangeButton { get; set; }
        
        
        
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

            AvatarChangeButton = this.FindControl<Button>("AvatarChangeButton");

        }

        private void AvatarChangeButtonOnClick(object sender, EventArgs e)
        {
            
        }

        private void AvatarChangeButtonIsPointerOver(object sender, EventArgs e)
        {
            AvatarChangeButton.Background = Brushes.Gray;
        }
        
    }
}