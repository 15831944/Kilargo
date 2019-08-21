using Autodesk.Revit.UI;
using kilargo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Kilargo
{
    class App : IExternalApplication
    {
        RibbonPanel ribbonPanel;
        RibbonPanel ribbonPanel2;
        RibbonPanel ribbonPanel1;
        PushButton pushButton;
        PushButton pushButton2;
        RibbonItem _button;
        public static string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static string assyPath = Path.Combine(dir, "kilargo.dll");

        public Result OnStartup(UIControlledApplication a)
        {
            kilargo.properities.pass = true;
            a.Idling += OnIdling;

            _app = this;
            // Create a custom ribbon tab
            String tabName = "Kilargo";
            a.CreateRibbonTab(tabName);

            //ribbonPanel = a.CreateRibbonPanel(tabName, "Login");
            //ribbonPanel2 = a.CreateRibbonPanel(tabName, "Logout");
            ribbonPanel1 = a.CreateRibbonPanel(tabName, "Kilargo Products");

            // Create a push button to trigger a command add it to the ribbon panel.
            // string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            //PushButtonData buttonData = new PushButtonData("Login", "Login", assyPath, "Kilargo.Command");

            //pushButton = ribbonPanel.AddItem(buttonData) as PushButton;
            //_button = pushButton;

            //PushButtonData buttonData2 = new PushButtonData("Logout", "Logout", assyPath, "Kilargo.logout");
            //pushButton2 = ribbonPanel2.AddItem(buttonData2) as PushButton;


            PushButtonData buttonData1 = new PushButtonData("Kilargo", "Products", assyPath, "Kilargo.Products1");
            PushButton pushButton1 = ribbonPanel1.AddItem(buttonData1) as PushButton;

            // Optionally, other properties may be assigned to the button
            // a) tool-tip
            //pushButton.ToolTip = "Kilargo Login";
            pushButton1.ToolTip = "Kilargo Revit File Downloader";

            //Uri uriImagel = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/login.png");
            //BitmapImage largeImagelarge = new BitmapImage(uriImagel);
            
            //// b) large bitmap
            //Uri uriImage = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/icon1.ico");
            //BitmapImage largeImage = new BitmapImage(uriImage);
            //pushButton.LargeImage = largeImage;
            //pushButton.ToolTipImage = largeImagelarge;
            //ribbonPanel2.Visible = false;




            //Uri uriImagel22 = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/logout.png");
            //BitmapImage largeImagelarge2 = new BitmapImage(uriImagel22);

            //Uri uriImage2 = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/icon2.ico");

            //BitmapImage largeImage2 = new BitmapImage(uriImage2);
            //pushButton2.LargeImage = largeImage2;
            //pushButton2.ToolTipImage = largeImagelarge2;



            Uri uriImagel3 = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/kilargo.png");
            BitmapImage largeImagelarge3 = new BitmapImage(uriImagel3);

            Uri uriImage1 = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/favicon (18).ico");
            BitmapImage largeImage1 = new BitmapImage(uriImage1);
            pushButton1.LargeImage = largeImage1;
            pushButton1.ToolTipImage = largeImagelarge3;
            ribbonPanel1.Enabled = true;

            
            return Result.Succeeded;
        }

        private void OnIdling(object sender, Autodesk.Revit.UI.Events.IdlingEventArgs e)
        {
            if (properities.download && properities.tempCommandData != null)
            {
                properities.download = false;
                CmdPlaceFamilyInstance objcmd = new CmdPlaceFamilyInstance();
                string tempMessage = string.Empty;
                objcmd.Execute(kilargo.properities.tempCommandData, ref tempMessage, kilargo.properities.tempElementSet);
                properities.tempCommandData = null;
                properities.tempElementSet = null;
                properities.download = false;
            }
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            kilargo.properities.pass = false;
            return Result.Succeeded;
        }

        internal static App _app = null;

        public static App Instance
        {
            get { return _app; }
        }



        //public void Toggle()
        //{
        //    string s = _button.ItemText;
          
        //    ribbonPanel2.Visible = true;
        //    ribbonPanel.Visible = false;
        //    ribbonPanel2.Enabled = false;
        //    ribbonPanel1.Enabled = true;

        //}

        //public void toggle2()
        //{
        //   properities.islogin = false;
        //    ribbonPanel1.Enabled = false;
        //    ribbonPanel2.Visible = false;
        //    ribbonPanel.Visible = true;
        //}

        //public void toggle3()
        //{
        //    ribbonPanel2.Enabled = true;
           
        //}


        //public void toggle4()
        //{
        //    ribbonPanel2.Enabled = false;

        //}


    }
}
