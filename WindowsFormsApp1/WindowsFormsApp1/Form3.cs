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

        private void table3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'empresaDataSet.Table3'. Você pode movê-la ou removê-la conforme necessário.
            this.table3TableAdapter.Fill(this.empresaDataSet.Table3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.table3BindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.table3BindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.table3BindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table3BindingSource.AddNew();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table3TableAdapter.FillBy(this.empresaDataSet.Table3, nomeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Visible = false;
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }
    }
}
