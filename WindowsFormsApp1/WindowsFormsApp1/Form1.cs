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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'empresaDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.empresaDataSet.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.AddNew();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.empresaDataSet.Table, produtoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Visible = false;
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
