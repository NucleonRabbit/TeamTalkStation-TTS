using System;
using System.Collections.Generic;
using Avalonia.ReactiveUI;
using Avalonia.Reactive;
using System.Drawing;
using System.Reactive;
using System.Runtime.InteropServices;
using TeamTalkStation_TTS_Client.Views;
using System.Text;

using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Microsoft.CodeAnalysis.Operations;
using ReactiveUI;

namespace TeamTalkStation_TTS_Client.ViewModels
{


    public class MainWindowViewModel : ViewModelBase
    {

        private ProfileEditWindow ProfileEditWindowEntity { get; set; }
        
        public MainWindowViewModel()
        {
            ProfileEditWindowEntity = new ProfileEditWindow();
        }



        public void OpenProfileEditWindow()
        {

            if (ProfileEditWindowEntity == null)
            {
                ProfileEditWindowEntity = new ProfileEditWindow();
            }
            
            ProfileEditWindowEntity.Show();

            ProfileEditWindowEntity = null;
        }
        
    }
        
       
    
    
    
    
    
}