
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        IDatabaseMananger _databaseManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Code configuration
                //ChannelServices.RegisterChannel(new TcpClientChannel(), false);

                //Config file configuratuin
                string config = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
                RemotingConfiguration.Configure(config, false);
                _databaseManager = (IDatabaseMananger)(Activator.GetObject(typeof(IDatabaseMananger), "tcp://localhost:9990/DatabaseMananger"));

                if (_databaseManager != null)
                {
                    List<string> ls = _databaseManager.GetTables();

                    foreach (var item in ls)
                    {
                        headOfficeTablesCombobox.Items.Add(item);
                    }
                    headOfficeTablesCombobox.SelectedValueChanged += HeadOfficeTableSelected;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can`t connect");
            }
        }


        private void HeadOfficeTableSelected(object sender, EventArgs e)
        {
            DataTable dt = _databaseManager.GetTable("SELECT * FROM " + headOfficeTablesCombobox.Text);
            headOfficeDataGridView.Columns.Clear();
            headOfficeDataGridView.DataSource = dt;

            headOfficeDataGridView.Refresh();
        }
    }
}
