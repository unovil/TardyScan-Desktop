namespace TardyQuery {
    partial class FormSearch {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtBoxName = new TextBox();
            comboBoxOptions = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dateTardy = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(235, 70);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(230, 38);
            txtBoxName.TabIndex = 0;
            // 
            // comboBoxOptions
            // 
            comboBoxOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOptions.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOptions.FormattingEnabled = true;
            comboBoxOptions.Items.AddRange(new object[] { "Last Name", "LRN" });
            comboBoxOptions.Location = new Point(492, 69);
            comboBoxOptions.Name = "comboBoxOptions";
            comboBoxOptions.Size = new Size(148, 39);
            comboBoxOptions.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(55, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 38);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(55, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 38);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 130);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 213);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 5;
            label2.Text = "Section";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 299);
            label3.Name = "label3";
            label3.Size = new Size(56, 31);
            label3.TabIndex = 7;
            label3.Text = "LRN";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(55, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 38);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dateTardy });
            dataGridView1.Location = new Point(499, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 200;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(350, 312);
            dataGridView1.TabIndex = 8;
            // 
            // dateTardy
            // 
            dateTardy.HeaderText = "Tardy Date";
            dateTardy.MinimumWidth = 6;
            dateTardy.Name = "dateTardy";
            dateTardy.ReadOnly = true;
            dateTardy.Resizable = DataGridViewTriState.False;
            dateTardy.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(235, 36);
            label4.Name = "label4";
            label4.Size = new Size(125, 31);
            label4.TabIndex = 9;
            label4.Text = "Search Box";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(492, 36);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 10;
            label5.Text = "Search in:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(661, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search!";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += recordSearch;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBoxOptions);
            Controls.Add(txtBoxName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSearch";
            Text = "Tardy - Search Engine";
            Load += FormSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxName;
        private ComboBox comboBoxOptions;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dateTardy;
        private Label label4;
        private Label label5;
        private Button btnSearch;
    }
}