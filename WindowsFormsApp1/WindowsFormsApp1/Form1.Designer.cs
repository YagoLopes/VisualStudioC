namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label precoUnitarioLabel;
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.produtoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.precoUnitarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.produtoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.produtoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet = new WindowsFormsApp1.empresaDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTableAdapter = new WindowsFormsApp1.empresaDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.empresaDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            produtoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            precoUnitarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Location = new System.Drawing.Point(110, 121);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(46, 13);
            produtoLabel.TabIndex = 4;
            produtoLabel.Text = "produto:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(110, 173);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 8;
            descricaoLabel.Text = "descricao:";
            // 
            // precoUnitarioLabel
            // 
            precoUnitarioLabel.AutoSize = true;
            precoUnitarioLabel.Location = new System.Drawing.Point(110, 147);
            precoUnitarioLabel.Name = "precoUnitarioLabel";
            precoUnitarioLabel.Size = new System.Drawing.Size(76, 13);
            precoUnitarioLabel.TabIndex = 19;
            precoUnitarioLabel.Text = "preco Unitario:";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableDataGridView.Location = new System.Drawing.Point(345, 80);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(443, 220);
            this.tableDataGridView.TabIndex = 1;
            // 
            // produtoTextBox
            // 
            this.produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "produto", true));
            this.produtoTextBox.Location = new System.Drawing.Point(192, 118);
            this.produtoTextBox.Name = "produtoTextBox";
            this.produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.produtoTextBox.TabIndex = 5;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(192, 170);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(441, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 41);
            this.button5.TabIndex = 19;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(532, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 41);
            this.button4.TabIndex = 18;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(634, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(732, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(342, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // precoUnitarioMaskedTextBox
            // 
            this.precoUnitarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "precoUnitario", true));
            this.precoUnitarioMaskedTextBox.Location = new System.Drawing.Point(192, 144);
            this.precoUnitarioMaskedTextBox.Mask = "$0000.00";
            this.precoUnitarioMaskedTextBox.Name = "precoUnitarioMaskedTextBox";
            this.precoUnitarioMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoUnitarioMaskedTextBox.TabIndex = 20;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripLabel,
            this.produtoToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillByToolStrip.TabIndex = 21;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // produtoToolStripLabel
            // 
            this.produtoToolStripLabel.Name = "produtoToolStripLabel";
            this.produtoToolStripLabel.Size = new System.Drawing.Size(53, 22);
            this.produtoToolStripLabel.Text = "produto:";
            // 
            // produtoToolStripTextBox
            // 
            this.produtoToolStripTextBox.Name = "produtoToolStripTextBox";
            this.produtoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.empresaDataSet;
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "empresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precoUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "precoUnitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table2TableAdapter = null;
            this.tableAdapterManager.Table3TableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Enabled = false;
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(12, 375);
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
            this.button6.Location = new System.Drawing.Point(126, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 29);
            this.button6.TabIndex = 34;
            this.button6.Text = "Proximo";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(precoUnitarioLabel);
            this.Controls.Add(this.precoUnitarioMaskedTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(produtoLabel);
            this.Controls.Add(this.produtoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.tableDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private empresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private empresaDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private empresaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox produtoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox precoUnitarioMaskedTextBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel produtoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox produtoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

