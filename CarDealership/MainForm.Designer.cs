namespace CarDealership
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            tabMain = new TabControl();
            tabCars = new TabPage();
            dgvCars = new DataGridView();
            btnDeleteCar = new Button();
            btnEditCar = new Button();
            btnAddCar = new Button();
            txtCarSearch = new TextBox();
            lblSearch = new Label();
            tabBuyers = new TabPage();
            tabMatching = new TabPage();
            tabRequests = new TabPage();
            tabMain.SuspendLayout();
            tabCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.25F);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Автомобілі";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabCars);
            tabMain.Controls.Add(tabBuyers);
            tabMain.Controls.Add(tabMatching);
            tabMain.Controls.Add(tabRequests);
            tabMain.Location = new Point(12, 42);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1189, 535);
            tabMain.TabIndex = 5;
            tabMain.Tag = "";
            // 
            // tabCars
            // 
            tabCars.Controls.Add(dgvCars);
            tabCars.Controls.Add(btnDeleteCar);
            tabCars.Controls.Add(btnEditCar);
            tabCars.Controls.Add(btnAddCar);
            tabCars.Controls.Add(txtCarSearch);
            tabCars.Controls.Add(lblSearch);
            tabCars.Location = new Point(4, 24);
            tabCars.Name = "tabCars";
            tabCars.Padding = new Padding(3);
            tabCars.Size = new Size(1181, 507);
            tabCars.TabIndex = 0;
            tabCars.Text = "Автомобілі";
            tabCars.UseVisualStyleBackColor = true;
            tabCars.Click += tabCars_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = SystemColors.Control;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(6, 48);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1169, 417);
            dgvCars.TabIndex = 5;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(326, 18);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(75, 23);
            btnDeleteCar.TabIndex = 4;
            btnDeleteCar.Text = "Видалити";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Location = new Point(245, 19);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(75, 23);
            btnEditCar.TabIndex = 3;
            btnEditCar.Text = "Редагувати";
            btnEditCar.UseVisualStyleBackColor = true;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(164, 19);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(75, 23);
            btnAddCar.TabIndex = 2;
            btnAddCar.Text = "Додати";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // txtCarSearch
            // 
            txtCarSearch.Location = new Point(58, 19);
            txtCarSearch.Name = "txtCarSearch";
            txtCarSearch.Size = new Size(100, 23);
            txtCarSearch.TabIndex = 1;
            txtCarSearch.TextChanged += txtCarSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(6, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(46, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Пошук";
            // 
            // tabBuyers
            // 
            tabBuyers.Location = new Point(4, 24);
            tabBuyers.Name = "tabBuyers";
            tabBuyers.Padding = new Padding(3);
            tabBuyers.Size = new Size(1181, 507);
            tabBuyers.TabIndex = 1;
            tabBuyers.Text = "Покупці";
            tabBuyers.UseVisualStyleBackColor = true;
            // 
            // tabMatching
            // 
            tabMatching.Location = new Point(4, 24);
            tabMatching.Name = "tabMatching";
            tabMatching.Padding = new Padding(3);
            tabMatching.Size = new Size(1181, 507);
            tabMatching.TabIndex = 2;
            tabMatching.Text = "Підбір авто";
            tabMatching.UseVisualStyleBackColor = true;
            // 
            // tabRequests
            // 
            tabRequests.Location = new Point(4, 24);
            tabRequests.Name = "tabRequests";
            tabRequests.Padding = new Padding(3);
            tabRequests.Size = new Size(1181, 507);
            tabRequests.TabIndex = 3;
            tabRequests.Text = "Заявки";
            tabRequests.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 716);
            Controls.Add(tabMain);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "Form1";
            tabMain.ResumeLayout(false);
            tabCars.ResumeLayout(false);
            tabCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabMain;
        private TabPage tabCars;
        private TabPage tabBuyers;
        private TabPage tabMatching;
        private TabPage tabRequests;
        private Button btnDeleteCar;
        private Button btnEditCar;
        private Button btnAddCar;
        private TextBox txtCarSearch;
        private Label lblSearch;
        private DataGridView dgvCars;
    }
}
