namespace kilargo
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.penetrationcmb = new System.Windows.Forms.ComboBox();
            this.buildElement = new System.Windows.Forms.ComboBox();
            this.FRL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // penetrationcmb
            // 
            this.penetrationcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penetrationcmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.penetrationcmb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penetrationcmb.FormattingEnabled = true;
            this.penetrationcmb.Location = new System.Drawing.Point(255, 83);
            this.penetrationcmb.Name = "penetrationcmb";
            this.penetrationcmb.Size = new System.Drawing.Size(317, 27);
            this.penetrationcmb.Sorted = true;
            this.penetrationcmb.TabIndex = 0;
            this.penetrationcmb.SelectedIndexChanged += new System.EventHandler(this.penetrationcmb_SelectedIndexChanged);
            // 
            // buildElement
            // 
            this.buildElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildElement.Enabled = false;
            this.buildElement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buildElement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildElement.FormattingEnabled = true;
            this.buildElement.Location = new System.Drawing.Point(840, 83);
            this.buildElement.Name = "buildElement";
            this.buildElement.Size = new System.Drawing.Size(444, 27);
            this.buildElement.Sorted = true;
            this.buildElement.TabIndex = 1;
            this.buildElement.SelectedIndexChanged += new System.EventHandler(this.buildElement_SelectedIndexChanged);
            // 
            // FRL
            // 
            this.FRL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FRL.Enabled = false;
            this.FRL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FRL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRL.FormattingEnabled = true;
            this.FRL.Location = new System.Drawing.Point(255, 136);
            this.FRL.Name = "FRL";
            this.FRL.Size = new System.Drawing.Size(317, 27);
            this.FRL.Sorted = true;
            this.FRL.TabIndex = 2;
            this.FRL.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type of Penetration :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(673, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building element :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fire Resistance Level :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(186)))), ((int)(((byte)(32)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 505);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1301, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(186)))), ((int)(((byte)(32)))));
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(1086, 133);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(198, 32);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(578, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "*";
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(1265, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 24);
            this.minimize.TabIndex = 12;
            this.minimize.Text = "__";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1290, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(578, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 45);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kilargo.Properties.Resources.bgfrm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 703);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FRL);
            this.Controls.Add(this.buildElement);
            this.Controls.Add(this.penetrationcmb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kilargo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Products_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Products_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox penetrationcmb;
        private System.Windows.Forms.ComboBox buildElement;
        private System.Windows.Forms.ComboBox FRL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

