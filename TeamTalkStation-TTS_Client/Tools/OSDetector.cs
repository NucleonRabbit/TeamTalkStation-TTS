using System;
using TeamTalkStation_TTS_Client.Enums;

namespace TeamTalkStation_TTS_Client.Tools
{
    public static class OSDetector
    {
        public static OSName OSDetect()
        {
            if (OperatingSystem.IsWindows() == true)
            {
                return OSName.Windows;
            }
            else if (OperatingSystem.IsLinux() == true)
            {
                return OSName.Linux;
            }
            else if (OperatingSystem.IsMacCatalyst() == true)
            {
                return OSName.MacCatalyst;
            }
            else if (OperatingSystem.IsMacOS() == true)
            {
                return OSName.MacOSX;
            }
            else
            {
                return OSName.Error_OSVersionIsNotSupport;
            }
        }
    }
}