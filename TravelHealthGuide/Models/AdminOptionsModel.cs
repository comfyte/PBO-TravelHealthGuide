using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TravelHealthGuide.Models
{
    public class AdminOptionsModel
    {
        public string GetCurrentWorkingDirectory()
            => Directory.GetCurrentDirectory();

        public void OpenCurrentWorkingDirectory()
        {
            Process.Start("explorer.exe", "/select,\""+GetCurrentWorkingDirectory()+"\\TravelHealthGuide.db\"");
        }
    }
}
