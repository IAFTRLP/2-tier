using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final0105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void site_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.site_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.site_info);

        }

        private void site_infoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.site_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.site_info);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'site_info._Site_info' 資料表。您可以視需要進行移動或移除。
            this.site_infoTableAdapter.Fill(this.site_info._Site_info);

        }

        private void fillBy_CountryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.site_infoTableAdapter.FillBy_Country(this.site_info._Site_info, countryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
