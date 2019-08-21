using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Kilargo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kilargo
{

    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public partial class login : Form
    {
        public static ExternalCommandData commandata1;
        public static Autodesk.Revit.DB.ElementSet elements1;
        string message1;


        public login(ExternalCommandData commandata2, ref string mess, Autodesk.Revit.DB.ElementSet ele)
        {
            InitializeComponent();
            commandata1 = commandata2;
            elements1 = ele;
            message1 = mess;
        }



        public Boolean RunServiceMethod()
        {

            Boolean Status = false;
            try
            {

                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "KilargoSoap";
                binding.CloseTimeout = System.TimeSpan.Parse("00:10:00");

                binding.OpenTimeout = System.TimeSpan.Parse("00:10:00");
                binding.ReceiveTimeout = System.TimeSpan.Parse("00:10:00");
                binding.SendTimeout = System.TimeSpan.Parse("00:10:00");

                binding.AllowCookies = false;
                binding.BypassProxyOnLocal = false;
                binding.HostNameComparisonMode = System.ServiceModel.HostNameComparisonMode.StrongWildcard;

                binding.MaxBufferSize = 65536;
                binding.MaxBufferPoolSize = 524288;
                binding.MaxReceivedMessageSize = 65536;

                binding.MessageEncoding = System.ServiceModel.WSMessageEncoding.Text;
                binding.TextEncoding = System.Text.Encoding.UTF8;
                binding.TransferMode = System.ServiceModel.TransferMode.Buffered;

                binding.UseDefaultWebProxy = true;
                binding.ReaderQuotas.MaxDepth = 32;
                binding.ReaderQuotas.MaxStringContentLength = 8192;

                binding.ReaderQuotas.MaxArrayLength = 16384;
                binding.ReaderQuotas.MaxBytesPerRead = 4096;
                binding.ReaderQuotas.MaxNameTableCharCount = 16384;

                binding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.None;
                binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;

                binding.Security.Transport.Realm = "";
                binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
                binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Default;

                EndpointAddress endpoint = new EndpointAddress("http://54.213.22.112/kilargo/Kilargo.asmx?wsdl");
                KilargoServices.KilargoSoapClient objService = new KilargoServices.KilargoSoapClient(binding, endpoint);
                Status = objService._getAuthentication(properities.Username, properities.Password);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Check your Internet Connection.");
            }

            return Status;
        }









        private void button1_Click(object sender, EventArgs e)
        {



              if (userNametxt.Text == String.Empty)
            {
                MessageBox.Show("Please input UserName");
                userNametxt.Focus();
            }

            else if (passWordtxt.Text == String.Empty)
            {
               MessageBox.Show("Please input Password");
                passWordtxt.Focus();
            }
            else
            {
                properities.Username = @"admin";
                properities.Password = @"admin";
                Boolean Status = false;
              
                try
                {
                   
                    Status = RunServiceMethod();
                    if (Status)
                    {

                        //App.Instance.Toggle();
                        properities.islogin = true;

                        //FrmProduct objProduct = new FrmProduct(commandata1, ref message1, elements1);
                        //objProduct.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or Password.");
                        passWordtxt.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Check your Internet Connection.");
                }

                finally
                {

                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



            
        }
    }

