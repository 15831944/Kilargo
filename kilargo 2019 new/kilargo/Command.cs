using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using kilargo;
using Kilargo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilargo
{
   
    [Transaction(TransactionMode.Manual)]
    class Command : IExternalCommand
    {
       
        public Result Execute(ExternalCommandData commandData, ref string message, Autodesk.Revit.DB.ElementSet elements)
        {

            Process process = Process.GetCurrentProcess();

            IntPtr h = process.MainWindowHandle;

          


            //login objLogin = new login(commandData, ref message, elements);
            //objLogin.ShowDialog();
            //if (properities.islogin)
            //{
                //objLogin.Hide();
                properities.logoutpass = false;
                //FrmProduct objproduct = new FrmProduct(commandData,ref message,elements);
                //objproduct.ShowDialog();
                properities.pass = true;
                Products1 prdobj = new Products1();
                properities.logoutpass = false;
                properities.tempCommandData = commandData;
                properities.tempElementSet = elements;
                properities.tempMessage = message;
                prdobj.Execute(commandData, ref message, elements);
               
                //CmdPlaceFamilyInstance cmd = new CmdPlaceFamilyInstance();
                //cmd.Execute(commandData, ref message, elements);

            //}

            return Result.Succeeded;

        }

      
    }






    [Transaction(TransactionMode.Manual)]
   public class Products1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, Autodesk.Revit.DB.ElementSet elements)
        {
            Products objproduct = new Products(commandData, ref message, elements);

            if (properities.pass)
            {
                if (properities.logoutpass)
                {

                    properities.logoutpass = false;
                }

                else
                {
                    //App._app.toggle4();
                    objproduct.Show();
                    objproduct.WindowState = FormWindowState.Normal;
                }
                
            }
           
          
            return Result.Succeeded;
        }

       
    }









    [Transaction(TransactionMode.Manual)]
    class logout : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, Autodesk.Revit.DB.ElementSet elements)
        {
            Products1 prdobj = new Products1();
            properities.logoutpass = true;
            prdobj.Execute(commandData, ref message, elements);
           
            //App._app.toggle2();

            return Result.Succeeded;
        }
    }
  


    public class JtWindowHandle : IWin32Window
    {
        IntPtr _hwnd;

        public JtWindowHandle(IntPtr h)
        {
            Debug.Assert(IntPtr.Zero != h,
              "expected non-null window handle");

            _hwnd = h;
        }

        public IntPtr Handle
        {
            get
            {
                return _hwnd;
            }
        }
    }



    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class CmdPlaceFamilyInstance : IExternalCommand
    {

        FamilySymbol symbol1;
        string FamilyPath = Path.GetFullPath(@"C:\Temp\" + properities.filename + ".rfa");
        string Familyname = properities.filename;
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //MessageBox.Show("Execute");
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // Retrieve elements from database

            FilteredElementCollector a = new FilteredElementCollector(doc).OfClass(typeof(Family));

            Family family = a.FirstOrDefault<Element>(e => e.Name.Equals(Familyname)) as Family;

            // Filtered element collector is iterable


            if (null == family)
            {
                // It is not present, so check for 
                // the file to load it from:

                if (!File.Exists(FamilyPath))
                {
                    // System.Security.Util.ErrorMsg(string.Format("Please ensure that the sample table " + "family file '{0}' exists in '{1}'.",Familyname, _family_folder));

                    return Result.Failed;
                }

                // Load family from file:
                //MessageBox.Show(FamilyPath);
                using (Transaction tx = new Transaction(doc))
                {
                    tx.Start("Load Family");
                    doc.LoadFamily(FamilyPath, out family);

                    tx.Commit();
                   
                }




                FamilySymbol symbol;

                symbol = null;

                foreach (ElementId eid in family.GetFamilySymbolIds())
                {
                    Element element = doc.GetElement(eid);
                    FamilySymbol s = element as FamilySymbol;
                    symbol = s;
                    // Our family only contains one
                    // symbol, so pick it and leave

                    break;
                }


                // MessageBox.Show("1");
                try
                {
                    uidoc.PromptForFamilyInstancePlacement(symbol);
                }
                catch (Autodesk.Revit.Exceptions.OperationCanceledException ex)
                {
                    
                }

             
            }
            //Modify document within a transaction

            else
            {

                foreach (ElementId eleid in family.GetFamilySymbolIds())
                {
                    Element ele = doc.GetElement(eleid);
                    FamilySymbol s = ele as FamilySymbol;
                    symbol1 = s;
                    // Our family only contains one
                    // symbol, so pick it and leave
                     
                    break;
                }
                //MessageBox.Show("2");
                try
                {
                    uidoc.PromptForFamilyInstancePlacement(symbol1);
                }
                catch (Autodesk.Revit.Exceptions.OperationCanceledException ex)
                {
                    
                }
                //uidoc.PromptForFamilyInstancePlacement(symbol1);
                //Place the family symbol:

                //PromptForFamilyInstancePlacement cannot 
                //be called inside transaction.





            }


            return Result.Succeeded;
        }



        public static Element FindElementByName(Document doc, Type targetType, string targetName)
        {
            return new FilteredElementCollector(doc)
              .OfClass(targetType).FirstOrDefault<Element>(e => e.Name.Equals(targetName));
        }

    }

       
    }










