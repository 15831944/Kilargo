using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Kilargo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kilargo
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]

    public partial class Products : Form
    {
        DataSet dsProduct = new DataSet();
        ExternalCommandData comma1;
        string mess1 = string.Empty;
        Autodesk.Revit.DB.ElementSet element;
        public Products(ExternalCommandData comma, ref string mess, Autodesk.Revit.DB.ElementSet ele)
        {
            InitializeComponent();
            comma1 = comma;
            mess1 = mess;
            element = ele;
        }

        DataTable dt = new DataTable();
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String RunServiceMethod()
        {
            String getData = String.Empty;
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "CaromaSoap";
                binding.CloseTimeout = System.TimeSpan.Parse("00:10:00");

                binding.OpenTimeout = System.TimeSpan.Parse("00:10:00");
                binding.ReceiveTimeout = System.TimeSpan.Parse("00:10:00");
                binding.SendTimeout = System.TimeSpan.Parse("00:10:00");

                binding.AllowCookies = false;
                binding.BypassProxyOnLocal = false;
                binding.HostNameComparisonMode = System.ServiceModel.HostNameComparisonMode.StrongWildcard;

                binding.MaxBufferSize = 28454546;
                binding.MaxBufferPoolSize = 28454546;
                binding.MaxReceivedMessageSize = 28454546;

                binding.MessageEncoding = System.ServiceModel.WSMessageEncoding.Text;
                binding.TextEncoding = System.Text.Encoding.UTF8;
                binding.TransferMode = System.ServiceModel.TransferMode.Buffered;

                binding.UseDefaultWebProxy = true;
                binding.ReaderQuotas.MaxDepth = 28454546;
                binding.ReaderQuotas.MaxStringContentLength = 28454546;

                binding.ReaderQuotas.MaxArrayLength = 28454546;
                binding.ReaderQuotas.MaxBytesPerRead = 28454546;
                binding.ReaderQuotas.MaxNameTableCharCount = 28454546;

                binding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.None;
                binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;

                binding.Security.Transport.Realm = "";
                binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
                binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Default;


                EndpointAddress endpoint = new EndpointAddress("http://kilargo.designcontent.com.au/Kilargo.asmx?wsdl");

                KilargoServices.KilargoSoapClient objService = new KilargoServices.KilargoSoapClient(binding, endpoint);

                getData = objService._getCategoryList(properities.Username);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Check your Internet Connection.");
            }

            return getData;

        }

        private void downloadRFA(String RemoteFtpPath, String LocalDestinationPath, String Username = "library@bimmepaus.com.au", String Password = "L4hia?;tVt.9")
        {            
            Boolean UseBinary = true;
            // use true for .zip file or false for a text file            
            Boolean UsePassive = false;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(RemoteFtpPath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.KeepAlive = true;
            request.UsePassive = UsePassive;
            request.UseBinary = UseBinary;
            request.Credentials = new NetworkCredential(Username, Password);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            using (FileStream writer = new FileStream(LocalDestinationPath, FileMode.Create))
            {
                long length = response.ContentLength;
                int bufferSize = 2048;
                int readCount; byte[] buffer = new byte[2048];
                readCount = responseStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    writer.Write(buffer, 0, readCount); readCount = responseStream.Read(buffer, 0, bufferSize);
                }
            }

            reader.Close();
            response.Close();
        }


        private Image LoadImage(string url)
        {
            System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }


        private DataSet getProductData(String UserName)
        {
            String getData = String.Empty;
            dsProduct = new DataSet();
            try
            {
                // CaromaService.CaromaSoapClient objService = new CaromaService.CaromaSoapClient();
                getData = RunServiceMethod();
                StringReader theReader = new StringReader(getData);
                dsProduct.ReadXml(theReader);
                //  objService.Close();
            }
            catch (Exception ex)
            {
                //lblProductErrorMessage.Text = "Please Check your Internet Connection.";
            }
            return dsProduct;
        }



        public DataTable GetTable()
        {
            getProductData(properities.Username);
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table = dsProduct.Tables[0];
            table.DefaultView.RowFilter = "Isdeleted = 'False'";
            table = table.DefaultView.ToTable();
            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            properities.Username = "admin";
            properities.pass = false;

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Product View";
            Deletelink.Name = "ProductView";
            //Deletelink.AutoSizeMode =DisplayedCells;
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Product Details";
            Deletelink.MinimumWidth = 120;
            Deletelink.Width = 120;
            dt.Clear();
            dt = GetTable();
            dataGridView1.RowTemplate.MinimumHeight = 30;
            dataGridView1.Columns.Add(Deletelink);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            dataGridView1.Columns["sn"].Visible = false;

            dataGridView1.Columns["typeComment"].Visible = false;
            dataGridView1.Columns["isDeleted"].Visible = false;
            dataGridView1.Columns["condition"].Visible = false;
            dataGridView1.Columns["ApplicationMountingDetail"].HeaderText = "Application / Mounting and Detail";
            dataGridView1.Columns["BuildingElement"].HeaderText = "Building Element";
            dataGridView1.Columns["ModelNumber"].HeaderText = "Model Number";

            BindSearchBox();
        }
        private void BindSearchBox()
        {
            penetrationcmb.Items.Clear();
            buildElement.Items.Clear();
            FRL.Items.Clear();
            DataTable table5 = dsProduct.Tables[0];
            table5.DefaultView.RowFilter = "Isdeleted = 'False'";
            table5 = table5.DefaultView.ToTable();
            DataView view = new DataView(table5);
            DataTable distinctValues = view.ToTable(true, "penetration");
            DataView view2 = new DataView(table5);
            DataTable distinctValues2 = view.ToTable(true, "buildingElement");
            DataView view3 = new DataView(table5);
            DataTable distinctValues3 = view.ToTable(true, "FRL");

            var filePaths = from row in distinctValues.AsEnumerable()
                            select row.Field<string>("penetration");
            var filePaths1 = from row in distinctValues2.AsEnumerable()
                             select row.Field<string>("buildingElement");
            var filePaths2 = from row in distinctValues3.AsEnumerable()
                             select row.Field<string>("FRL");

            var filePathsArray = filePaths.ToList();
            var filePathsArray1 = filePaths1.ToList();
            var filePathsArray3 = filePaths2.ToList();



            penetrationcmb.Items.Insert(0, "---Select Penetration---");
            buildElement.Items.Insert(0, "---Select Building Element---");
            FRL.Items.Insert(0, "---Select  Fire Resistance Level---");


            penetrationcmb.SelectedIndex = 0;
            buildElement.SelectedIndex = 0;
            FRL.SelectedIndex = 0;



            for (int i = 0; i < filePathsArray.Count; i++)
            {
                if (filePathsArray[i].ToString() != null)
                {
                    penetrationcmb.Items.Add(filePathsArray[i].ToString().ToUpper());

                }
            }

            for (int i = 0; i < filePathsArray1.Count; i++)
            {
                if (filePathsArray1[i].ToString() != null)
                {
                    buildElement.Items.Add(filePathsArray1[i].ToString().ToUpper());
                }

            }

            for (int i = 0; i < filePathsArray3.Count; i++)
            {

                if (filePathsArray3[i].ToString() != null)
                {
                    FRL.Items.Add(filePathsArray3[i].ToString().ToUpper());
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {

                if (dataGridView1.SelectedCells.Count > 0)
                {

                    DataGridViewCell cell = dataGridView1.SelectedCells[0] as DataGridViewCell;
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    string value = cell.EditedFormattedValue.ToString();
                    //string value1 = cell1.EditedFormattedValue.ToString();
                    //string value2 = cell2.EditedFormattedValue.ToString();


                    if (value == "Product Details")
                    {
                        int index = e.RowIndex;
                        Int16 SelectedProductTypeDetailsID = Convert.ToInt16(dsProduct.Tables[0].Rows[index]["sn"]);
                        String SelectedProductTypeRevitFileName = dataGridView1.Rows[selectedrowindex].Cells[11].FormattedValue.ToString();
                        // String SelectedProductTypeRevitFileName = dsProduct.Tables[0].Rows[index]["fileName"].ToString();
                        String ProductDescription = dataGridView1.Rows[selectedrowindex].Cells[12].FormattedValue.ToString();
                        properities.RevitFilePath = SelectedProductTypeRevitFileName;

                        properities.fileDescription = ProductDescription;
                        ProductDetails obj = new ProductDetails(comma1, ref mess1, element);
                        obj.ShowDialog();
                        if (properities.minwindow)
                        {
                            this.WindowState = FormWindowState.Minimized;
                            properities.minwindow = false;
                        }
                    }
                }

            }


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if ((penetrationcmb.Text != "---Select Penetration---") && (buildElement.Text != "---Select Building Element---") && (FRL.Text != "---Select  Fire Resistance Level---"))
            {
                DataSet ds = new DataSet();
                DataTable dt3 = new DataTable();
                DataTable dtfinal = new DataTable();
                dt3 = dt;

                dt3.DefaultView.RowFilter = "Isdeleted = 'False' and penetration = '" + penetrationcmb.Text + "'";
                DataTable dt1 = new DataTable();
                dt1 = dt3.DefaultView.ToTable();

                try
                {
                    if (dt1.Rows.Count > 0)
                    {
                        dtfinal = dt1;
                        dtfinal.DefaultView.RowFilter = "FRL= '" + FRL.Text + "' and buildingElement='" + buildElement.Text + "'";
                        DataTable dtfinal1 = new DataTable();
                        dtfinal1 = dtfinal.DefaultView.ToTable();
                        if (dtfinal1.Rows.Count > 0)
                        {
                            DataSet dsfinal = new DataSet();
                            dsfinal.Tables.Add(dtfinal1);
                            dataGridView1.DataSource = dsfinal.Tables[0];
                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.Columns["sn"].Visible = false;

                            dataGridView1.Columns["typeComment"].Visible = false;
                            dataGridView1.Columns["isDeleted"].Visible = false;
                            dataGridView1.Columns["condition"].Visible = false;
                            dataGridView1.Columns["ApplicationMountingDetail"].HeaderText = "Application / Mounting and Detail";
                            dataGridView1.Columns["BuildingElement"].HeaderText = "Building Element";
                            dataGridView1.Columns["ModelNumber"].HeaderText = "Model Number";
                        }

                        else
                        {
                            dataGridView1.DataSource = null;
                            MessageBox.Show("No Records Found");
                            dataGridView1.DataSource = null;
                            dt.Clear();
                            dt = GetTable();
                            dataGridView1.DataSource = dt;
                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.Columns["sn"].Visible = false;

                            dataGridView1.Columns["typeComment"].Visible = false;
                            dataGridView1.Columns["isDeleted"].Visible = false;
                            dataGridView1.Columns["condition"].Visible = false;
                            dataGridView1.Columns["ApplicationMountingDetail"].HeaderText = "Application / Mounting and Detail";
                            dataGridView1.Columns["BuildingElement"].HeaderText = "Building Element";
                            dataGridView1.Columns["ModelNumber"].HeaderText = "Model Number";
                        }
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No Records Found");
                        dataGridView1.DataSource = null;
                        dt.Clear();
                        dt = GetTable();
                        dataGridView1.DataSource = dt;
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.Columns["sn"].Visible = false;

                        dataGridView1.Columns["typeComment"].Visible = false;
                        dataGridView1.Columns["isDeleted"].Visible = false;
                        dataGridView1.Columns["condition"].Visible = false;
                        dataGridView1.Columns["ApplicationMountingDetail"].HeaderText = "Application / Mounting and Detail";
                        dataGridView1.Columns["BuildingElement"].HeaderText = "Building Element";
                        dataGridView1.Columns["ModelNumber"].HeaderText = "Model Number";
                    }
                }
                catch (Exception)
                {


                }
            }
            else
            {

                MessageBox.Show("Please Fill the mandatary fields");

                if (penetrationcmb.Text == "---Select Penetration---")
                {
                    dataGridView1.DataSource = null;
                    dt.Clear();
                    dt = GetTable();
                    dataGridView1.DataSource = dt;
                    dataGridView1.RowHeadersVisible = false;

                    dataGridView1.Columns["sn"].Visible = false;
                    dataGridView1.Columns["typeComment"].Visible = false;
                    dataGridView1.Columns["isDeleted"].Visible = false;
                    dataGridView1.Columns["condition"].Visible = false;
                    dataGridView1.Columns["ApplicationMountingDetail"].HeaderText = "Application / Mounting and Detail";
                    dataGridView1.Columns["BuildingElement"].HeaderText = "Building Element";
                    dataGridView1.Columns["ModelNumber"].HeaderText = "Model Number";
                }

            }

        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            penetrationcmb.Items.Clear();
            buildElement.Items.Clear();
            FRL.Items.Clear();
            properities.pass = true;
            properities.logoutpass = false;
            //App._app.toggle3();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void penetrationcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Str = penetrationcmb.SelectedItem.ToString();

            if (Str != "---Select Penetration---")
            {
                buildElement.Enabled = true;
                FRL.Enabled = false;
                Selectedpenetration = Str;
                buildElement.Items.Clear();
                DataTable table5 = dsProduct.Tables[0];
                table5.DefaultView.RowFilter = "Isdeleted = 'False' and penetration = '" + Str + "'";
                table5 = table5.DefaultView.ToTable();
                DataView view = new DataView(table5);
                FRL.Enabled = false;
                DataTable distinctValues2 = view.ToTable(true, "buildingElement");
                distinctValues2 = distinctValues2.DefaultView.ToTable();
                var filePaths1 = from row in distinctValues2.AsEnumerable()
                                 select row.Field<string>("buildingElement");

                //DataTable distinctValues3 = view.ToTable(true, "FRL");
                //distinctValues3 = distinctValues3.DefaultView.ToTable();
                //var filePaths2 = from row in distinctValues3.AsEnumerable()
                //                 select row.Field<string>("FRL");

                var filePathsArray1 = filePaths1.ToList();
                buildElement.Items.Insert(0, "---Select Building Element---");
                FRL.Items.Insert(0, "---Select  Fire Resistance Level---");
                FRL.SelectedIndex = 0;

                buildElement.SelectedIndex = 0;


                for (int i = 0; i < filePathsArray1.Count; i++)
                {
                    if (filePathsArray1[i].ToString() != null)
                    {
                        buildElement.Items.Add(filePathsArray1[i].ToString().ToUpper());
                    }
                }

                //var filePathsArray2 = filePaths2.ToList();
                //FRL.Items.Clear();
                //FRL.Items.Insert(0, "---Select  Fire Resistance Level---");
                //FRL.SelectedIndex = 0;
                //for (int i = 0; i < filePathsArray2.Count; i++)
                //{
                //    if (filePathsArray2[i].ToString() != null)
                //    {
                //        FRL.Items.Add(filePathsArray2[i].ToString().ToUpper());
                //    }
                //}

            }
            else
            {

                buildElement.Enabled = false;
                FRL.Enabled = false;
                buildElement.Items.Clear();
                buildElement.Items.Insert(0, "---Select Building Element---");
                buildElement.SelectedIndex = 0;
                FRL.Items.Clear();
                FRL.Items.Insert(0, "---Select  Fire Resistance Level---");
                FRL.SelectedIndex = 0;
            }

        }
        String Selectedpenetration = String.Empty;
        private void buildElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Str = buildElement.SelectedItem.ToString();
            if (Str != "---Select Building Element---")
            {
                FRL.Enabled = true;
                FRL.Items.Clear();
                DataTable table5 = dsProduct.Tables[0];
                table5.DefaultView.RowFilter = "Isdeleted = 'False' and penetration = '" + Selectedpenetration + "' and buildingElement= '" + Str + "'";
                table5 = table5.DefaultView.ToTable();
                DataView view = new DataView(table5);

                DataTable distinctValues3 = view.ToTable(true, "FRL");
                distinctValues3 = distinctValues3.DefaultView.ToTable();
                var filePaths2 = from row in distinctValues3.AsEnumerable()
                                 select row.Field<string>("FRL");

                var filePathsArray1 = filePaths2.ToList();
                FRL.Items.Clear();
                FRL.Items.Insert(0, "---Select  Fire Resistance Level---");
                FRL.SelectedIndex = 0;


                for (int i = 0; i < filePathsArray1.Count; i++)
                {
                    if (filePathsArray1[i].ToString() != null)
                    {
                        FRL.Items.Add(filePathsArray1[i].ToString().ToUpper());
                    }
                }
            }
            else
            {
                FRL.Items.Clear();
                FRL.Items.Insert(0, "---Select  Fire Resistance Level---");
                FRL.SelectedIndex = 0;
                FRL.Enabled = false;


            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }


        private bool _dragging = false;
        private System.Drawing.Point _offset;
        private System.Drawing.Point _start_point = new System.Drawing.Point(0, 0);


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                System.Drawing.Point p = PointToScreen(e.Location);
                Location = new System.Drawing.Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new System.Drawing.Point(e.X, e.Y);
        }
        

    }

}

