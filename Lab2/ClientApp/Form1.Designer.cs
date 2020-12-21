namespace ClientApp
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.headOfficeTablesCombobox = new System.Windows.Forms.ComboBox();
            this.headOfficeDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.branchOfficeTablesCombobox = new System.Windows.Forms.ComboBox();
            this.branchOfifceDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headOfficeDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchOfifceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.headOfficeTablesCombobox);
            this.tabPage1.Controls.Add(this.headOfficeDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(944, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Головний офіс";
            // 
            // headOfficeTablesCombobox
            // 
            this.headOfficeTablesCombobox.FormattingEnabled = true;
            this.headOfficeTablesCombobox.Location = new System.Drawing.Point(8, 8);
            this.headOfficeTablesCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.headOfficeTablesCombobox.Name = "headOfficeTablesCombobox";
            this.headOfficeTablesCombobox.Size = new System.Drawing.Size(214, 24);
            this.headOfficeTablesCombobox.TabIndex = 1;
            this.headOfficeTablesCombobox.SelectedIndexChanged += new System.EventHandler(this.headOfficeTablesCombobox_SelectedIndexChanged);
            // 
            // headOfficeDataGridView
            // 
            this.headOfficeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headOfficeDataGridView.Location = new System.Drawing.Point(230, 8);
            this.headOfficeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.headOfficeDataGridView.Name = "headOfficeDataGridView";
            this.headOfficeDataGridView.RowHeadersWidth = 51;
            this.headOfficeDataGridView.Size = new System.Drawing.Size(707, 368);
            this.headOfficeDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.branchOfficeTablesCombobox);
            this.tabPage2.Controls.Add(this.branchOfifceDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(944, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Філіал аптеки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // branchOfficeTablesCombobox
            // 
            this.branchOfficeTablesCombobox.FormattingEnabled = true;
            this.branchOfficeTablesCombobox.Location = new System.Drawing.Point(8, 8);
            this.branchOfficeTablesCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.branchOfficeTablesCombobox.Name = "branchOfficeTablesCombobox";
            this.branchOfficeTablesCombobox.Size = new System.Drawing.Size(216, 24);
            this.branchOfficeTablesCombobox.TabIndex = 2;
            // 
            // branchOfifceDataGridView
            // 
            this.branchOfifceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchOfifceDataGridView.Location = new System.Drawing.Point(232, 8);
            this.branchOfifceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.branchOfifceDataGridView.Name = "branchOfifceDataGridView";
            this.branchOfifceDataGridView.RowHeadersWidth = 51;
            this.branchOfifceDataGridView.Size = new System.Drawing.Size(704, 370);
            this.branchOfifceDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(982, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headOfficeDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchOfifceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView headOfficeDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView branchOfifceDataGridView;
        private System.Windows.Forms.ComboBox headOfficeTablesCombobox;
        private System.Windows.Forms.ComboBox branchOfficeTablesCombobox;
        private System.Windows.Forms.Button button1;
    }
}

