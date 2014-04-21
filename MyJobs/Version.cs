using System;

namespace KPI
{
    public class Version
    {
        public static int VersionMajor = 0;
        public static int VersionMinor = 2;
        public static int VersionFix = 1;

        public static string AppName = "MyJobs";
        public static string VersionFull = VersionMajor.ToString() + "." + VersionMinor.ToString() + "." + VersionFix.ToString();
        public static string AppNameFull = AppName + " v" + VersionFull;

        public static string Author = "Melnik Eugene <jeka7js@gmail.com>";
    }
}

