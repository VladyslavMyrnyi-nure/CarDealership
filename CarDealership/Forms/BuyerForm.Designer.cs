namespace CarDealership.Forms
{
    partial class BuyerForm
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
            txtFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            txtDesiredBrand = new TextBox();
            label4 = new Label();
            label5 = new Label();
            nudMinYear = new NumericUpDown();
            label6 = new Label();
            cmbCondition = new ComboBox();
            label7 = new Label();
            rtbRequirements = new RichTextBox();
            label9 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            nudMaxPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMinYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.Location = new Point(170, 9);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(182, 29);
            txtFullName.TabIndex = 8;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 7;
            label1.Text = "ПІБ покупця";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 9;
            label2.Text = "Телефон";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(170, 44);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(182, 29);
            txtPhone.TabIndex = 10;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(170, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 29);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // txtDesiredBrand
            // 
            txtDesiredBrand.Font = new Font("Segoe UI", 12F);
            txtDesiredBrand.Location = new Point(170, 114);
            txtDesiredBrand.Name = "txtDesiredBrand";
            txtDesiredBrand.Size = new Size(182, 29);
            txtDesiredBrand.TabIndex = 14;
            txtDesiredBrand.TextChanged += txtDesiredBrand_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 13;
            label4.Text = "Бажана марка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 152);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 15;
            label5.Text = "Мінімальний рік";
            // 
            // nudMinYear
            // 
            nudMinYear.Font = new Font("Segoe UI", 12F);
            nudMinYear.Location = new Point(170, 150);
            nudMinYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudMinYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nudMinYear.Name = "nudMinYear";
            nudMinYear.Size = new Size(182, 29);
            nudMinYear.TabIndex = 16;
            nudMinYear.Value = new decimal(new int[] { 2015, 0, 0, 0 });
            nudMinYear.ValueChanged += nudMinYear_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 17;
            label6.Text = "Бюджет, $";
            label6.Click += label6_Click;
            // 
            // cmbCondition
            // 
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.Font = new Font("Segoe UI", 12F);
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(170, 220);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(182, 29);
            cmbCondition.TabIndex = 20;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 223);
            label7.Name = "label7";
            label7.Size = new Size(138, 21);
            label7.TabIndex = 19;
            label7.Text = "Мінімальний стан";
            // 
            // rtbRequirements
            // 
            rtbRequirements.Font = new Font("Segoe UI", 12F);
            rtbRequirements.Location = new Point(12, 291);
            rtbRequirements.Name = "rtbRequirements";
            rtbRequirements.Size = new Size(236, 108);
            rtbRequirements.TabIndex = 28;
            rtbRequirements.Text = "";
            rtbRequirements.TextChanged += rtbRequirements_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 267);
            label9.Name = "label9";
            label9.Size = new Size(139, 21);
            label9.TabIndex = 27;
            label9.Text = "Додаткові вимоги";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(182, 421);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 38);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(11, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 38);
            btnSave.TabIndex = 29;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudMaxPrice
            // 
            nudMaxPrice.Font = new Font("Segoe UI", 12F);
            nudMaxPrice.Location = new Point(170, 185);
            nudMaxPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMaxPrice.Name = "nudMaxPrice";
            nudMaxPrice.Size = new Size(182, 29);
            nudMaxPrice.TabIndex = 31;
            nudMaxPrice.ThousandsSeparator = true;
            nudMaxPrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });

            // 
            // BuyerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 486);
            Controls.Add(nudMaxPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtbRequirements);
            Controls.Add(label9);
            Controls.Add(cmbCondition);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(nudMinYear);
            Controls.Add(label5);
            Controls.Add(txtDesiredBrand);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "BuyerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuyerForm";
            ((System.ComponentModel.ISupportInitialize)nudMinYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label label1;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtDesiredBrand;
        private Label label4;
        private Label label5;
        private NumericUpDown nudMinYear;
        private Label label6;
        private ComboBox cmbCondition;
        private Label label7;
        private RichTextBox rtbRequirements;
        private Label label9;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown nudMaxPrice;
    }
}