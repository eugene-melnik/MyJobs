using System;

namespace MyJobs
{
    static class Version
    {
        /* Constants */
        public static UInt16 AppVersionMajor = 0;
        public static UInt16 AppVersionMinor = 5;
        public static UInt16 AppVersionFix = 1;

        public static String AppVersionFull = AppVersionMajor.ToString() + "."
                                            + AppVersionMinor.ToString() + "."
                                            + AppVersionFix.ToString();

        public static String AppName = "MyJobs";

        public static String AppNameFull = AppName + " v"
                                         + AppVersionFull;

        public static String AppLicense = "GNU GPL v2";
        public static String AppAuthor = "Melnik Eugene <jeka7js@gmail.com>";
        public static String[] AppTranslators = { "Ukrainian: Melnik Eugene <jeka7js@gmail.com>" };
    }
}
