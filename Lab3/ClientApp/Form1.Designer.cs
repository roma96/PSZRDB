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
            this.headOfficeTablesCombobox = new System.Windows.Forms.ComboBox();
            this.headOfficeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.headOfficeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headOfficeTablesCombobox
            // 
            this.headOfficeTablesCombobox.FormattingEnabled = true;
            this.headOfficeTablesCombobox.Location = new System.Drawing.Point(13, 13);
            this.headOfficeTablesCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headOfficeTablesCombobox.Name = "headOfficeTablesCombobox";
            this.headOfficeTablesCombobox.Size = new System.Drawing.Size(239, 24);
            this.headOfficeTablesCombobox.TabIndex = 1;
            // 
            // headOfficeDataGridView
            // 
            this.headOfficeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headOfficeDataGridView.Location = new System.Drawing.Point(260, 13);
            this.headOfficeDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headOfficeDataGridView.Name = "headOfficeDataGridView";
            this.headOfficeDataGridView.RowHeadersWidth = 51;
            this.headOfficeDataGridView.Size = new System.Drawing.Size(644, 393);
            this.headOfficeDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 413);
            this.Controls.Add(this.headOfficeDataGridView);
            this.Controls.Add(this.headOfficeTablesCombobox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headOfficeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView headOfficeDataGridView;
        private System.Windows.Forms.ComboBox headOfficeTablesCombobox;
    }
}

