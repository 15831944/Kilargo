using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kilargo
{
    class properities
    {

        public static string filename { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Boolean islogin { get; set; }
        public static Boolean download { get; set; }
        public static string RevitFilePath { get; set; }
        public static string RevitFileName { get; set; }
        public static string Filename { get; set; }
        public static string fileDescription { get; set; }
        public static string lastdownloadname { get; set; }
        public static ExternalCommandData tempCommandData { get; set; }
        public static ElementSet tempElementSet { get; set; }
        public static string tempMessage { get; set; }
        public static Boolean pass { get; set; }
        public static Boolean logoutpass { get; set; }
        public static Boolean minwindow { get; set; }
    }
}
