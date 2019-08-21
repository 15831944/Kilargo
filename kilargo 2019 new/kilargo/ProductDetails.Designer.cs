namespace kilargo
{
    partial class ProductDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailsimage = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.dload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.prodescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRevitFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.revitfilesize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailsimage)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsimage
            // 
            this.detailsimage.BackColor = System.Drawing.Color.Transparent;
            this.detailsimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsimage.Location = new System.Drawing.Point(12, 103);
            this.detailsimage.Name = "detailsimage";
            this.detailsimage.Size = new System.Drawing.Size(328, 360);
            this.detailsimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.detailsimage.TabIndex = 0;
            this.detailsimage.TabStop = false;
            // 
            // productName
            // 
            this.productName.BackColor = System.Drawing.Color.Transparent;
            this.productName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.productName.Location = new System.Drawing.Point(12, 49);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(737, 34);
            this.productName.TabIndex = 1;
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dload
            // 
            this.dload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(186)))), ((int)(((byte)(32)))));
            this.dload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.dload.FlatAppearance.BorderSize = 3;
            this.dload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.dload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.dload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dload.ForeColor = System.Drawing.Color.White;
            this.dload.Location = new System.Drawing.Point(656, 447);
            this.dload.Name = "dload";
            this.dload.Size = new System.Drawing.Size(108, 39);
            this.dload.TabIndex = 2;
            this.dload.Text = "Download";
            this.dload.UseVisualStyleBackColor = false;
            this.dload.Click += new System.EventHandler(this.dload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(358, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Description";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(730, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prodescription
            // 
            this.prodescription.BackColor = System.Drawing.Color.Transparent;
            this.prodescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.prodescription.Location = new System.Drawing.Point(358, 135);
            this.prodescription.Name = "prodescription";
            this.prodescription.Size = new System.Drawing.Size(365, 195);
            this.prodescription.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(186)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(531, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save As";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(360, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Revit File Name: ";
            // 
            // lblRevitFileName
            // 
            this.lblRevitFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblRevitFileName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevitFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.lblRevitFileName.Location = new System.Drawing.Point(360, 367);
            this.lblRevitFileName.Name = "lblRevitFileName";
            this.lblRevitFileName.Size = new System.Drawing.Size(389, 42);
            this.lblRevitFileName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(360, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "File Size : ";
            // 
            // revitfilesize
            // 
            this.revitfilesize.AutoSize = true;
            this.revitfilesize.BackColor = System.Drawing.Color.Transparent;
            this.revitfilesize.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revitfilesize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.revitfilesize.Location = new System.Drawing.Point(434, 422);
            this.revitfilesize.Name = "revitfilesize";
            this.revitfilesize.Size = new System.Drawing.Size(0, 13);
            this.revitfilesize.TabIndex = 14;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kilargo.Properties.Resources.bgfrm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 496);
            this.Controls.Add(this.revitfilesize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRevitFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prodescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dload);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.detailsimage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox detailsimage;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button dload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label prodescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRevitFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label revitfilesize;
    }
}