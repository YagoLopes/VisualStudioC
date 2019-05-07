namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label cnpjLabel;
            this.empresaDataSet = new WindowsFormsApp1.empresaDataSet();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table2TableAdapter = new WindowsFormsApp1.empresaDataSetTableAdapters.Table2TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.empresaDataSetTableAdapters.TableAdapterManager();
            this.table2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            clienteLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(138, 129);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(41, 13);
            clienteLabel.TabIndex = 4;
            clienteLabel.Text = "cliente:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(138, 155);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 6;
            cnpjLabel.Text = "cnpj:";
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "empresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table2";
            this.table2BindingSource.DataSource = this.empresaDataSet;
            // 
            // table2TableAdapter
            // 
            this.table2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table2TableAdapter = this.table2TableAdapter;
            this.tableAdapterManager.Table3TableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table2DataGridView
            // 
            this.table2DataGridView.AutoGenerateColumns = false;
            this.table2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.table2DataGridView.DataSource = this.table2BindingSource;
            this.table2DataGridView.Location = new System.Drawing.Point(385, 91);
            this.table2DataGridView.Name = "table2DataGridView";
            this.table2DataGridView.Size = new System.Drawing.Size(342, 220);
            this.table2DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn3.HeaderText = "cnpj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(185, 126);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteTextBox.TabIndex = 5;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(185, 152);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(385, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(476, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 41);
            this.button4.TabIndex = 23;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(578, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 41);
            this.button3.TabIndex = 22;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(676, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(286, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripLabel,
            this.clienteToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 25;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // clienteToolStripLabel
            // 
            this.clienteToolStripLabel.Name = "clienteToolStripLabel";
            this.clienteToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.clienteToolStripLabel.Text = "cliente:";
            // 
            // clienteToolStripTextBox
            // 
            this.clienteToolStripTextBox.Name = "clienteToolStripTextBox";
            this.clienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cliente";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(21, 382);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 29);
            this.button7.TabIndex = 35;
            this.button7.Text = "Voltar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(135, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 29);
            this.button6.TabIndex = 34;
            this.button6.Text = "Proximo";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(this.table2DataGridView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form2";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private empresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private empresaDataSetTableAdapters.Table2TableAdapter table2TableAdapter;
        private empresaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView table2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}