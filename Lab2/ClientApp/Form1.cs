using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        Type _headOfficeType = Type.GetTypeFromProgID("HeadOffice.DatabaseMananger");
        Type _branchOfficeType = Type.GetTypeFromProgID("BranchOffice.DatabaseMananger");
        object _headOfficeComObject;
        object _branchOfficeComObject;

        public Form1()
        {          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_headOfficeType != null)
            {
                _headOfficeComObject = Activator.CreateInstance(_headOfficeType);
                if (_headOfficeComObject != null)
                {
                    var mehtodInvoke = _headOfficeType.GetMethod("GetTables");
                    List<string> ls = (List<string>)mehtodInvoke.Invoke(_headOfficeComObject, new object[] { });

                    foreach (var item in ls)
                    {
                        headOfficeTablesCombobox.Items.Add(item);
                    }
                    headOfficeTablesCombobox.SelectedValueChanged += HeadOfficeTableSelected;
                }
            }

            if (_branchOfficeType != null)
            {
                _branchOfficeComObject = Activator.CreateInstance(_branchOfficeType);
                if (_branchOfficeComObject != null)
                {
                    var mehtodInvoke = _branchOfficeType.GetMethod("GetTables");
                    List<string> ls = (List<string>)mehtodInvoke.Invoke(_branchOfficeComObject, new object[] { });

                    foreach (var item in ls)
                    {
                        branchOfficeTablesCombobox.Items.Add(item);
                    }
                    branchOfficeTablesCombobox.SelectedValueChanged += BranchOfficeTableSelected;
                }
            }
        }


        private void HeadOfficeTableSelected(object sender, EventArgs e)
        {
            var mi = _headOfficeType.GetMethod("GetTable");
            DataTable dt = (DataTable)mi.Invoke(_headOfficeComObject, new object[] { "SELECT * FROM " + headOfficeTablesCombobox.Text });
            headOfficeDataGridView.Columns.Clear();
            headOfficeDataGridView.DataSource = dt;

            headOfficeDataGridView.Refresh();
        }

        private void BranchOfficeTableSelected(object sender, EventArgs e)
        {
            var mi = _branchOfficeType.GetMethod("GetTable");
            DataTable dt = (DataTable)mi.Invoke(_branchOfficeComObject, new object[] { "SELECT * FROM " + branchOfficeTablesCombobox.Text });
            branchOfifceDataGridView.Columns.Clear();
            branchOfifceDataGridView.DataSource = dt;

            branchOfifceDataGridView.Refresh();
        }

        private void headOfficeTablesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in headOfficeDataGridView.Rows)
            {
                // your code
                foreach (var cl in headOfficeDataGridView.Columns)
                {
                     row.Cells[cl.ToString()].Value.ToString();
                }
            }
        }
    }
}
