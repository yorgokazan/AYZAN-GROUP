using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ayzanGroupDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.PROFESSION' table. You can move, or remove it, as needed.
            this.pROFESSIONTableAdapter.Fill(this.ayzanGroupDataSet.PROFESSION);
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.PROFESSION' table. You can move, or remove it, as needed.
            this.pROFESSIONTableAdapter.Fill(this.ayzanGroupDataSet.PROFESSION);
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.ayzanGroupDataSet.EMPLOYEE);

        }
    }
}
