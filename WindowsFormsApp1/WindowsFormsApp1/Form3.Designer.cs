namespace WindowsFormsApp1
{
    partial class Form3
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label casadoLabel;
            this.empresaDataSet = new WindowsFormsApp1.empresaDataSet();
            this.table3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table3TableAdapter = new WindowsFormsApp1.empresaDataSetTableAdapters.Table3TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.empresaDataSetTableAdapters.TableAdapterManager();
            this.table3DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.casadoCheckBox = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            casadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3DataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(201, 153);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "nome:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(201, 179);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(32, 13);
            sexoLabel.TabIndex = 6;
            sexoLabel.Text = "sexo:";
            // 
            // casadoLabel
            // 
            casadoLabel.AutoSize = true;
            casadoLabel.Location = new System.Drawing.Point(201, 207);
            casadoLabel.Name = "casadoLabel";
            casadoLabel.Size = new System.Drawing.Size(45, 13);
            casadoLabel.TabIndex = 8;
            casadoLabel.Text = "casado:";
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "empresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table3BindingSource
            // 
            this.table3BindingSource.DataMember = "Table3";
            this.table3BindingSource.DataSource = this.empresaDataSet;
            // 
            // table3TableAdapter
            // 
            this.table3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table2TableAdapter = null;
            this.tableAdapterManager.Table3TableAdapter = this.table3TableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table3DataGridView
            // 
            this.table3DataGridView.AutoGenerateColumns = false;
            this.table3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.table3DataGridView.DataSource = this.table3BindingSource;
            this.table3DataGridView.Location = new System.Drawing.Point(475, 101);
            this.table3DataGridView.Name = "table3DataGridView";
            this.table3DataGridView.Size = new System.Drawing.Size(300, 220);
            this.table3DataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sexo";
            this.dataGridViewTextBoxColumn3.HeaderText = "sexo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "casado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "casado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table3BindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(252, 150);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(104, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table3BindingSource, "sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(252, 176);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(104, 20);
            this.sexoTextBox.TabIndex = 7;
            // 
            // casadoCheckBox
            // 
            this.casadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.table3BindingSource, "casado", true));
            this.casadoCheckBox.Location = new System.Drawing.Point(252, 202);
            this.casadoCheckBox.Name = "casadoCheckBox";
            this.casadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.casadoCheckBox.TabIndex = 9;
            this.casadoCheckBox.Text = "checkBox1";
            this.casadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(399, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 41);
            this.button5.TabIndex = 29;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(490, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 41);
            this.button4.TabIndex = 28;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(592, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 41);
            this.button3.TabIndex = 27;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(690, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(300, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripLabel,
            this.nomeToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 30;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // nomeToolStripLabel
            // 
            this.nomeToolStripLabel.Name = "nomeToolStripLabel";
            this.nomeToolStripLabel.Size = new System.Drawing.Size(41, 22);
            this.nomeToolStripLabel.Text = "nome:";
            // 
            // nomeToolStripTextBox
            // 
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
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
            this.label1.Location = new System.Drawing.Point(171, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Funcionário";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Enabled = false;
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(126, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 29);
            this.button6.TabIndex = 32;
            this.button6.Text = "Proximo";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(12, 381);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 29);
            this.button7.TabIndex = 33;
            this.button7.Text = "Voltar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form3
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
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(casadoLabel);
            this.Controls.Add(this.casadoCheckBox);
            this.Controls.Add(this.table3DataGridView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form3";
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3DataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private empresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource table3BindingSource;
        private empresaDataSetTableAdapters.Table3TableAdapter table3TableAdapter;
        private empresaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView table3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.CheckBox casadoCheckBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}