using System;



namespace TeamTalkStation_TTS_Client.Modules
{
    public class PlatformDetect
    {
        public static bool DetectLinux()
        {
            return OperatingSystem.IsLinux();
        }

        public static bool DetectWindows()
        {
            return OperatingSystem.IsWindows();
        }

        public static bool DetectMacOS()
        {
            return OperatingSystem.IsMacOS();
        }
    }
}