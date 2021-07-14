
namespace Wood_Stocks_Application
{
    partial class WoodStocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.XmlStyleButton2 = new System.Windows.Forms.Button();
            this.XmlStyleButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.NullValue = null;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemDescription,
            this.CurrentCount,
            this.OnOrder});
            this.DataGridView.Location = new System.Drawing.Point(12, 262);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(954, 262);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellAndEdit);
            this.DataGridView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.DataGridView_SortCompare);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.MinimumWidth = 6;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // CurrentCount
            // 
            this.CurrentCount.HeaderText = "Current Count";
            this.CurrentCount.MinimumWidth = 6;
            this.CurrentCount.Name = "CurrentCount";
            // 
            // OnOrder
            // 
            this.OnOrder.HeaderText = "On Order";
            this.OnOrder.MinimumWidth = 6;
            this.OnOrder.Name = "OnOrder";
            this.OnOrder.ReadOnly = true;
            // 
            // ImportButton
            // 
            this.ImportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ImportButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.Color.Thistle;
            this.ImportButton.Location = new System.Drawing.Point(728, 532);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(116, 40);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SaveButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Thistle;
            this.SaveButton.Location = new System.Drawing.Point(850, 532);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 40);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox.Location = new System.Drawing.Point(12, 537);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(462, 28);
            this.TextBox.TabIndex = 3;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Csv Files (*csv)|*csv";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Csv Files (*csv)|*csv| Xml Files (*xml)| *xml";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser1.Location = new System.Drawing.Point(12, 12);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(952, 231);
            this.WebBrowser1.TabIndex = 4;
            // 
            // XmlStyleButton2
            // 
            this.XmlStyleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XmlStyleButton2.BackColor = System.Drawing.SystemColors.GrayText;
            this.XmlStyleButton2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlStyleButton2.ForeColor = System.Drawing.Color.Thistle;
            this.XmlStyleButton2.Location = new System.Drawing.Point(604, 532);
            this.XmlStyleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.XmlStyleButton2.Name = "XmlStyleButton2";
            this.XmlStyleButton2.Size = new System.Drawing.Size(116, 40);
            this.XmlStyleButton2.TabIndex = 5;
            this.XmlStyleButton2.Text = "Xml Style 2";
            this.XmlStyleButton2.UseVisualStyleBackColor = false;
            this.XmlStyleButton2.Click += new System.EventHandler(this.XmlStyleButton2_Click);
            // 
            // XmlStyleButton1
            // 
            this.XmlStyleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XmlStyleButton1.BackColor = System.Drawing.SystemColors.GrayText;
            this.XmlStyleButton1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlStyleButton1.ForeColor = System.Drawing.Color.Thistle;
            this.XmlStyleButton1.Location = new System.Drawing.Point(482, 532);
            this.XmlStyleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.XmlStyleButton1.Name = "XmlStyleButton1";
            this.XmlStyleButton1.Size = new System.Drawing.Size(116, 40);
            this.XmlStyleButton1.TabIndex = 5;
            this.XmlStyleButton1.Text = "Xml Style 1";
            this.XmlStyleButton1.UseVisualStyleBackColor = false;
            this.XmlStyleButton1.Click += new System.EventHandler(this.XmlStyleButton1_Click);
            // 
            // WoodStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.XmlStyleButton1);
            this.Controls.Add(this.XmlStyleButton2);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WoodStocks";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wood Stocks";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnOrder;
        private System.Windows.Forms.WebBrowser WebBrowser1;
        private System.Windows.Forms.Button XmlStyleButton2;
        private System.Windows.Forms.Button XmlStyleButton1;
    }
}

