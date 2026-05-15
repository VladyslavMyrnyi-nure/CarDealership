namespace CarDealership.Forms
{
    partial class CarForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtCountry = new TextBox();
            nudYear = new NumericUpDown();
            nudPrice = new NumericUpDown();
            cmbCondition = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            nudEngine = new NumericUpDown();
            lblEngine = new Label();
            lblHorsePower = new Label();
            nudHorsePower = new NumericUpDown();
            lblCountry = new Label();
            nudMileage = new NumericUpDown();
            label7 = new Label();
            cmbFuel = new ComboBox();
            label8 = new Label();
            cmbTransmission = new ComboBox();
            chkIsNew = new CheckBox();
            label9 = new Label();
            rtbFeatures = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEngine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHorsePower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMileage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 1;
            label2.Text = "Модель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 2;
            label3.Text = "Рік";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 511);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 3;
            label4.Text = "Ціна, $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(11, 183);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 4;
            label5.Text = "Пробіг, км";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 323);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 5;
            label6.Text = "Стан";
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 12F);
            txtBrand.Location = new Point(170, 9);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(182, 29);
            txtBrand.TabIndex = 6;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 12F);
            txtModel.Location = new Point(170, 44);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(182, 29);
            txtModel.TabIndex = 7;
            txtModel.TextChanged += txtModel_TextChanged;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F);
            txtCountry.Location = new Point(170, 219);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(182, 29);
            txtCountry.TabIndex = 8;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // nudYear
            // 
            nudYear.Font = new Font("Segoe UI", 12F);
            nudYear.Location = new Point(170, 79);
            nudYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(182, 29);
            nudYear.TabIndex = 9;
            nudYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            nudYear.ValueChanged += nudYear_ValueChanged;
            // 
            // nudPrice
            // 
            nudPrice.Font = new Font("Segoe UI", 12F);
            nudPrice.Location = new Point(116, 509);
            nudPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 29);
            nudPrice.TabIndex = 10;
            nudPrice.ThousandsSeparator = true;
            nudPrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.ValueChanged += nudPrice_ValueChanged;
            // 
            // cmbCondition
            // 
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.Font = new Font("Segoe UI", 12F);
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(170, 323);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(182, 29);
            cmbCondition.TabIndex = 11;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(11, 575);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 38);
            btnSave.TabIndex = 12;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(182, 575);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // nudEngine
            // 
            nudEngine.DecimalPlaces = 1;
            nudEngine.Font = new Font("Segoe UI", 12F);
            nudEngine.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudEngine.Location = new Point(170, 114);
            nudEngine.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudEngine.Name = "nudEngine";
            nudEngine.Size = new Size(182, 29);
            nudEngine.TabIndex = 14;
            nudEngine.Value = new decimal(new int[] { 16, 0, 0, 65536 });
            nudEngine.ValueChanged += nudEngine_ValueChanged;
            // 
            // lblEngine
            // 
            lblEngine.AutoSize = true;
            lblEngine.Font = new Font("Segoe UI", 12F);
            lblEngine.Location = new Point(11, 113);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(132, 21);
            lblEngine.TabIndex = 15;
            lblEngine.Text = "Об'єм двигуна, л.";
            // 
            // lblHorsePower
            // 
            lblHorsePower.AutoSize = true;
            lblHorsePower.Font = new Font("Segoe UI", 12F);
            lblHorsePower.Location = new Point(12, 148);
            lblHorsePower.Name = "lblHorsePower";
            lblHorsePower.Size = new Size(120, 21);
            lblHorsePower.TabIndex = 16;
            lblHorsePower.Text = "Потужність, к.с.";
            // 
            // nudHorsePower
            // 
            nudHorsePower.Font = new Font("Segoe UI", 12F);
            nudHorsePower.Location = new Point(170, 149);
            nudHorsePower.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudHorsePower.Name = "nudHorsePower";
            nudHorsePower.Size = new Size(182, 29);
            nudHorsePower.TabIndex = 17;
            nudHorsePower.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudHorsePower.ValueChanged += nudHorsePower_ValueChanged;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 12F);
            lblCountry.Location = new Point(11, 219);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(57, 21);
            lblCountry.TabIndex = 18;
            lblCountry.Text = "Країна";
            // 
            // nudMileage
            // 
            nudMileage.Font = new Font("Segoe UI", 12F);
            nudMileage.Location = new Point(170, 184);
            nudMileage.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMileage.Name = "nudMileage";
            nudMileage.Size = new Size(182, 29);
            nudMileage.TabIndex = 19;
            nudMileage.ThousandsSeparator = true;
            nudMileage.ValueChanged += nudMileage_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 253);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 20;
            label7.Text = "Пальне";
            // 
            // cmbFuel
            // 
            cmbFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuel.Font = new Font("Segoe UI", 12F);
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(170, 253);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(182, 29);
            cmbFuel.TabIndex = 21;
            cmbFuel.SelectedIndexChanged += cmbFuel_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 288);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 22;
            label8.Text = "Коробка передач";
            // 
            // cmbTransmission
            // 
            cmbTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransmission.Font = new Font("Segoe UI", 12F);
            cmbTransmission.FormattingEnabled = true;
            cmbTransmission.Location = new Point(170, 288);
            cmbTransmission.Name = "cmbTransmission";
            cmbTransmission.Size = new Size(182, 29);
            cmbTransmission.TabIndex = 23;
            cmbTransmission.SelectedIndexChanged += cmbTransmission_SelectedIndexChanged;
            // 
            // chkIsNew
            // 
            chkIsNew.AutoSize = true;
            chkIsNew.Font = new Font("Segoe UI", 12F);
            chkIsNew.Location = new Point(12, 358);
            chkIsNew.Name = "chkIsNew";
            chkIsNew.Size = new Size(164, 25);
            chkIsNew.TabIndex = 24;
            chkIsNew.Text = " Новий автомобіль";
            chkIsNew.UseVisualStyleBackColor = true;
            chkIsNew.CheckedChanged += chkIsNew_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(11, 389);
            label9.Name = "label9";
            label9.Size = new Size(99, 21);
            label9.TabIndex = 25;
            label9.Text = "Особливості";
            // 
            // rtbFeatures
            // 
            rtbFeatures.Font = new Font("Segoe UI", 12F);
            rtbFeatures.Location = new Point(116, 389);
            rtbFeatures.Name = "rtbFeatures";
            rtbFeatures.Size = new Size(236, 108);
            rtbFeatures.TabIndex = 26;
            rtbFeatures.Text = "";
            rtbFeatures.TextChanged += rtbFeatures_TextChanged;
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 644);
            Controls.Add(rtbFeatures);
            Controls.Add(label9);
            Controls.Add(chkIsNew);
            Controls.Add(cmbTransmission);
            Controls.Add(label8);
            Controls.Add(cmbFuel);
            Controls.Add(label7);
            Controls.Add(nudMileage);
            Controls.Add(lblCountry);
            Controls.Add(nudHorsePower);
            Controls.Add(lblHorsePower);
            Controls.Add(lblEngine);
            Controls.Add(nudEngine);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCondition);
            Controls.Add(nudPrice);
            Controls.Add(nudYear);
            Controls.Add(txtCountry);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додавання автомобіля";
            Load += CarForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEngine).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHorsePower).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMileage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtCountry;
        private NumericUpDown nudYear;
        private NumericUpDown nudPrice;
        private ComboBox cmbCondition;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown nudEngine;
        private Label lblEngine;
        private Label lblHorsePower;
        private NumericUpDown nudHorsePower;
        private Label lblCountry;
        private NumericUpDown nudMileage;
        private Label label7;
        private ComboBox cmbFuel;
        private Label label8;
        private ComboBox cmbTransmission;
        private CheckBox chkIsNew;
        private Label label9;
        private RichTextBox rtbFeatures;
    }
}