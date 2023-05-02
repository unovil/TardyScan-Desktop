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
            txtBoxSearchTerm = new TextBox();
            comboBoxSearchOptions = new ComboBox();
            txtBoxResultName = new TextBox();
            txtBoxResultSection = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxResultLrn = new TextBox();
            dgvTardy = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            labelSearchOutcome = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTardy).BeginInit();
            SuspendLayout();
            // 
            // txtBoxSearchTerm
            // 
            txtBoxSearchTerm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSearchTerm.Location = new Point(235, 70);
            txtBoxSearchTerm.Name = "txtBoxSearchTerm";
            txtBoxSearchTerm.Size = new Size(230, 38);
            txtBoxSearchTerm.TabIndex = 0;
            txtBoxSearchTerm.TextChanged += Input_Change;
            // 
            // comboBoxSearchOptions
            // 
            comboBoxSearchOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchOptions.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchOptions.FormattingEnabled = true;
            comboBoxSearchOptions.Items.AddRange(new object[] { "Last Name", "LRN" });
            comboBoxSearchOptions.Location = new Point(492, 69);
            comboBoxSearchOptions.Name = "comboBoxSearchOptions";
            comboBoxSearchOptions.Size = new Size(148, 39);
            comboBoxSearchOptions.TabIndex = 1;
            comboBoxSearchOptions.TextChanged += Input_Change;
            // 
            // txtBoxResultName
            // 
            txtBoxResultName.Enabled = false;
            txtBoxResultName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxResultName.Location = new Point(55, 164);
            txtBoxResultName.Name = "txtBoxResultName";
            txtBoxResultName.Size = new Size(425, 38);
            txtBoxResultName.TabIndex = 2;
            // 
            // txtBoxResultSection
            // 
            txtBoxResultSection.Enabled = false;
            txtBoxResultSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxResultSection.Location = new Point(55, 247);
            txtBoxResultSection.Name = "txtBoxResultSection";
            txtBoxResultSection.Size = new Size(139, 38);
            txtBoxResultSection.TabIndex = 3;
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
            // txtBoxResultLrn
            // 
            txtBoxResultLrn.Enabled = false;
            txtBoxResultLrn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxResultLrn.Location = new Point(55, 333);
            txtBoxResultLrn.Name = "txtBoxResultLrn";
            txtBoxResultLrn.Size = new Size(139, 38);
            txtBoxResultLrn.TabIndex = 6;
            // 
            // dgvTardy
            // 
            dgvTardy.AllowUserToAddRows = false;
            dgvTardy.AllowUserToDeleteRows = false;
            dgvTardy.AllowUserToResizeColumns = false;
            dgvTardy.AllowUserToResizeRows = false;
            dgvTardy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTardy.Location = new Point(517, 164);
            dgvTardy.Name = "dgvTardy";
            dgvTardy.ReadOnly = true;
            dgvTardy.RowHeadersWidth = 30;
            dgvTardy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTardy.RowTemplate.Height = 29;
            dgvTardy.Size = new Size(350, 312);
            dgvTardy.TabIndex = 8;
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
            btnSearch.Location = new Point(646, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 39);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search!";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += recordSearch;
            // 
            // labelSearchOutcome
            // 
            labelSearchOutcome.AutoSize = true;
            labelSearchOutcome.Location = new Point(235, 112);
            labelSearchOutcome.Name = "labelSearchOutcome";
            labelSearchOutcome.Size = new Size(0, 20);
            labelSearchOutcome.TabIndex = 12;
            labelSearchOutcome.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(135, 69);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormSearch
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnClear);
            Controls.Add(labelSearchOutcome);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvTardy);
            Controls.Add(label3);
            Controls.Add(txtBoxResultLrn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxResultSection);
            Controls.Add(txtBoxResultName);
            Controls.Add(comboBoxSearchOptions);
            Controls.Add(txtBoxSearchTerm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSearch";
            Text = "Tardy - Search Engine";
            Load += FormSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTardy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSearchTerm;
        private ComboBox comboBoxSearchOptions;
        private TextBox txtBoxResultName;
        private TextBox txtBoxResultSection;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxResultLrn;
        private DataGridView dgvTardy;
        private Label label4;
        private Label label5;
        private Button btnSearch;
        private Label labelSearchOutcome;
        private Button btnClear;
    }
}