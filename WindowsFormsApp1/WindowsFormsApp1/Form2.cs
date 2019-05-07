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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void table2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'empresaDataSet.Table2'. Você pode movê-la ou removê-la conforme necessário.
            this.table2TableAdapter.Fill(this.empresaDataSet.Table2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table2BindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.table2BindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.table2BindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.table2BindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table2TableAdapter.FillBy(this.empresaDataSet.Table2, clienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Visible = false;
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Visible = false;
            form1.Show();
        }
    }
}
