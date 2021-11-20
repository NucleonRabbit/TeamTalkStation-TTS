using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TeamTalkStation_TTS_Client.ViewModels
{
    public class MainWindowViewModel : ViewModelBase        
    {
        public string Greeting => "Welcome to Avalonia!";

        public Bitmap MyBitmap => new Bitmap(filename: "/home/nucleon14/Projects/CSharpProjects/TeamTalkStation-TTS/TeamTalkStation-TTS_Client/Assets/0.jpeg");
    }
}