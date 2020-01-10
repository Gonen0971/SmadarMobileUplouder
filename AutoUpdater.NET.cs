using System;
using AutoUpdaterDotNET;

namespace SmadarMobileUplouder
{

    public static class AutoUpdaterDotNet
    {
        //  --  Checking  \\sps-sql1\!LastVersions\Smadar Mobile\DocUploader\DocUploader_AutoUpdater.xml  --
        //  -- https://github.com/ravibpatel/AutoUpdater.NET  --



        public static void RunAutoUpdater()
        {
            AutoUpdater.Start(@"\\sps-sql1\!LastVersions\Smadar Mobile\DocUploader\DocUploader_AutoUpdater.xml");
        }


    }
}