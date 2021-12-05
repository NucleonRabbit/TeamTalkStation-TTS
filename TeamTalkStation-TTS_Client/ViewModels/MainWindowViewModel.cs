using System;
using System.Collections.Generic;
using System.Text;
using TeamTalkStation_TTS_Client.Views;

namespace TeamTalkStation_TTS_Client.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        
        private ProfileEditWindow ProfileEditWindowEntity { get; set; }


        public void OpenProfileEditWindow()
        {
            if (ProfileEditWindowEntity == null || ProfileEditWindowEntity.IsVisible == false)
            {
                ProfileEditWindowEntity = new ProfileEditWindow();
                
                ProfileEditWindowEntity.Show();
            }
            else
            {
                ProfileEditWindowEntity.Activate();
                ProfileEditWindowEntity.WindowState = Avalonia.Controls.WindowState.Normal;
            }
        }
        
        
    }
}
