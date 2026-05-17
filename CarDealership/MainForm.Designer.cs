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
            dgvBuyers = new DataGridView();
            btnDeleteBuyer = new Button();
            btnEditBuyer = new Button();
            btnAddBuyer = new Button();
            txtBuyerSearch = new TextBox();
            label2 = new Label();
            button3 = new Button();
            tabMatching = new TabPage();
            btnSupplierRequest = new Button();
            btnTransportRequest = new Button();
            btnFindCars = new Button();
            button1 = new Button();
            cmbBuyers = new ComboBox();
            label3 = new Label();
            dgvMatches = new DataGridView();
            tabRequests = new TabPage();
            btnDeleteTransportRequest = new Button();
            label4 = new Label();
            btnDeleteSupplierRequest = new Button();
            label1 = new Label();
            dgvTransportRequests = new DataGridView();
            dgvSupplierRequests = new DataGridView();
            tabMain.SuspendLayout();
            tabCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            tabBuyers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).BeginInit();
            tabMatching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            tabRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierRequests).BeginInit();
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
            tabMain.Font = new Font("Segoe UI", 12F);
            tabMain.Location = new Point(12, 42);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1575, 662);
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
            tabCars.Location = new Point(4, 30);
            tabCars.Name = "tabCars";
            tabCars.Padding = new Padding(3);
            tabCars.Size = new Size(1567, 628);
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
            dgvCars.Location = new Point(6, 44);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1555, 578);
            dgvCars.TabIndex = 5;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Font = new Font("Segoe UI", 12F);
            btnDeleteCar.Location = new Point(446, 7);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(106, 31);
            btnDeleteCar.TabIndex = 4;
            btnDeleteCar.Text = "Видалити";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Font = new Font("Segoe UI", 12F);
            btnEditCar.Location = new Point(334, 7);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(106, 31);
            btnEditCar.TabIndex = 3;
            btnEditCar.Text = "Редагувати";
            btnEditCar.UseVisualStyleBackColor = true;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Font = new Font("Segoe UI", 12F);
            btnAddCar.Location = new Point(222, 7);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(106, 31);
            btnAddCar.TabIndex = 2;
            btnAddCar.Text = "Додати";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // txtCarSearch
            // 
            txtCarSearch.Font = new Font("Segoe UI", 12F);
            txtCarSearch.Location = new Point(71, 9);
            txtCarSearch.Name = "txtCarSearch";
            txtCarSearch.Size = new Size(145, 29);
            txtCarSearch.TabIndex = 1;
            txtCarSearch.TextChanged += txtCarSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F);
            lblSearch.Location = new Point(6, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Пошук";
            // 
            // tabBuyers
            // 
            tabBuyers.Controls.Add(dgvBuyers);
            tabBuyers.Controls.Add(btnDeleteBuyer);
            tabBuyers.Controls.Add(btnEditBuyer);
            tabBuyers.Controls.Add(btnAddBuyer);
            tabBuyers.Controls.Add(txtBuyerSearch);
            tabBuyers.Controls.Add(label2);
            tabBuyers.Controls.Add(button3);
            tabBuyers.Location = new Point(4, 30);
            tabBuyers.Name = "tabBuyers";
            tabBuyers.Padding = new Padding(3);
            tabBuyers.Size = new Size(1567, 628);
            tabBuyers.TabIndex = 1;
            tabBuyers.Text = "Покупці";
            tabBuyers.UseVisualStyleBackColor = true;
            // 
            // dgvBuyers
            // 
            dgvBuyers.AllowUserToAddRows = false;
            dgvBuyers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuyers.BackgroundColor = SystemColors.Control;
            dgvBuyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuyers.Location = new Point(6, 44);
            dgvBuyers.MultiSelect = false;
            dgvBuyers.Name = "dgvBuyers";
            dgvBuyers.ReadOnly = true;
            dgvBuyers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuyers.Size = new Size(1555, 578);
            dgvBuyers.TabIndex = 10;
            dgvBuyers.CellContentClick += dgvBuyers_CellContentClick;
            // 
            // btnDeleteBuyer
            // 
            btnDeleteBuyer.Font = new Font("Segoe UI", 12F);
            btnDeleteBuyer.Location = new Point(446, 7);
            btnDeleteBuyer.Name = "btnDeleteBuyer";
            btnDeleteBuyer.Size = new Size(106, 31);
            btnDeleteBuyer.TabIndex = 9;
            btnDeleteBuyer.Text = "Видалити";
            btnDeleteBuyer.UseVisualStyleBackColor = true;
            btnDeleteBuyer.Click += btnDeleteBuyer_Click;
            // 
            // btnEditBuyer
            // 
            btnEditBuyer.Font = new Font("Segoe UI", 12F);
            btnEditBuyer.Location = new Point(334, 7);
            btnEditBuyer.Name = "btnEditBuyer";
            btnEditBuyer.Size = new Size(106, 31);
            btnEditBuyer.TabIndex = 8;
            btnEditBuyer.Text = "Редагувати";
            btnEditBuyer.UseVisualStyleBackColor = true;
            btnEditBuyer.Click += btnEditBuyer_Click;
            // 
            // btnAddBuyer
            // 
            btnAddBuyer.Font = new Font("Segoe UI", 12F);
            btnAddBuyer.Location = new Point(222, 7);
            btnAddBuyer.Name = "btnAddBuyer";
            btnAddBuyer.Size = new Size(106, 31);
            btnAddBuyer.TabIndex = 7;
            btnAddBuyer.Text = "Додати";
            btnAddBuyer.UseVisualStyleBackColor = true;
            btnAddBuyer.Click += btnAddBuyer_Click;
            // 
            // txtBuyerSearch
            // 
            txtBuyerSearch.Font = new Font("Segoe UI", 12F);
            txtBuyerSearch.Location = new Point(71, 9);
            txtBuyerSearch.Name = "txtBuyerSearch";
            txtBuyerSearch.Size = new Size(145, 29);
            txtBuyerSearch.TabIndex = 6;
            txtBuyerSearch.TextChanged += txtBuyerSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 5;
            label2.Text = "Пошук";
            // 
            // button3
            // 
            button3.Location = new Point(334, 115);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabMatching
            // 
            tabMatching.Controls.Add(btnSupplierRequest);
            tabMatching.Controls.Add(btnTransportRequest);
            tabMatching.Controls.Add(btnFindCars);
            tabMatching.Controls.Add(button1);
            tabMatching.Controls.Add(cmbBuyers);
            tabMatching.Controls.Add(label3);
            tabMatching.Controls.Add(dgvMatches);
            tabMatching.Location = new Point(4, 30);
            tabMatching.Name = "tabMatching";
            tabMatching.Padding = new Padding(3);
            tabMatching.Size = new Size(1567, 628);
            tabMatching.TabIndex = 2;
            tabMatching.Text = "Підбір авто";
            tabMatching.UseVisualStyleBackColor = true;
            // 
            // btnSupplierRequest
            // 
            btnSupplierRequest.Font = new Font("Segoe UI", 12F);
            btnSupplierRequest.Location = new Point(492, 8);
            btnSupplierRequest.Name = "btnSupplierRequest";
            btnSupplierRequest.Size = new Size(178, 31);
            btnSupplierRequest.TabIndex = 17;
            btnSupplierRequest.Text = "Заявка постачальнику";
            btnSupplierRequest.UseVisualStyleBackColor = true;
            btnSupplierRequest.Click += btnSupplierRequest_Click;
            // 
            // btnTransportRequest
            // 
            btnTransportRequest.Font = new Font("Segoe UI", 12F);
            btnTransportRequest.Location = new Point(676, 8);
            btnTransportRequest.Name = "btnTransportRequest";
            btnTransportRequest.Size = new Size(178, 31);
            btnTransportRequest.TabIndex = 16;
            btnTransportRequest.Text = "Заявка перевізнику";
            btnTransportRequest.UseVisualStyleBackColor = true;
            btnTransportRequest.Click += btnTransportRequest_Click;
            // 
            // btnFindCars
            // 
            btnFindCars.Font = new Font("Segoe UI", 12F);
            btnFindCars.Location = new Point(349, 7);
            btnFindCars.Name = "btnFindCars";
            btnFindCars.Size = new Size(137, 31);
            btnFindCars.TabIndex = 15;
            btnFindCars.Text = "Підібрати авто";
            btnFindCars.UseVisualStyleBackColor = true;
            btnFindCars.Click += btnFindCars_Click;
            // 
            // button1
            // 
            button1.Location = new Point(372, 12);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbBuyers
            // 
            cmbBuyers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuyers.FormattingEnabled = true;
            cmbBuyers.Location = new Point(93, 10);
            cmbBuyers.Name = "cmbBuyers";
            cmbBuyers.Size = new Size(250, 29);
            cmbBuyers.TabIndex = 13;
            cmbBuyers.SelectedIndexChanged += cmbBuyers_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 12);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 12;
            label3.Text = "Покупець";
            // 
            // dgvMatches
            // 
            dgvMatches.AllowUserToAddRows = false;
            dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.BackgroundColor = SystemColors.Control;
            dgvMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.Location = new Point(6, 45);
            dgvMatches.MultiSelect = false;
            dgvMatches.Name = "dgvMatches";
            dgvMatches.ReadOnly = true;
            dgvMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatches.Size = new Size(1555, 417);
            dgvMatches.TabIndex = 11;
            // 
            // tabRequests
            // 
            tabRequests.Controls.Add(btnDeleteTransportRequest);
            tabRequests.Controls.Add(label4);
            tabRequests.Controls.Add(btnDeleteSupplierRequest);
            tabRequests.Controls.Add(label1);
            tabRequests.Controls.Add(dgvTransportRequests);
            tabRequests.Controls.Add(dgvSupplierRequests);
            tabRequests.Location = new Point(4, 30);
            tabRequests.Name = "tabRequests";
            tabRequests.Padding = new Padding(3);
            tabRequests.Size = new Size(1567, 628);
            tabRequests.TabIndex = 3;
            tabRequests.Text = "Заявки";
            tabRequests.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransportRequest
            // 
            btnDeleteTransportRequest.Font = new Font("Segoe UI", 12F);
            btnDeleteTransportRequest.Location = new Point(202, 322);
            btnDeleteTransportRequest.Name = "btnDeleteTransportRequest";
            btnDeleteTransportRequest.Size = new Size(106, 31);
            btnDeleteTransportRequest.TabIndex = 17;
            btnDeleteTransportRequest.Text = "Видалити";
            btnDeleteTransportRequest.UseVisualStyleBackColor = true;
            btnDeleteTransportRequest.Click += btnDeleteTransportRequest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 327);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 16;
            label4.Text = "Заявки перевізникам";
            // 
            // btnDeleteSupplierRequest
            // 
            btnDeleteSupplierRequest.Font = new Font("Segoe UI", 12F);
            btnDeleteSupplierRequest.Location = new Point(202, 7);
            btnDeleteSupplierRequest.Name = "btnDeleteSupplierRequest";
            btnDeleteSupplierRequest.Size = new Size(106, 31);
            btnDeleteSupplierRequest.TabIndex = 15;
            btnDeleteSupplierRequest.Text = "Видалити";
            btnDeleteSupplierRequest.UseVisualStyleBackColor = true;
            btnDeleteSupplierRequest.Click += btnDeleteSupplierRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(190, 21);
            label1.TabIndex = 14;
            label1.Text = "Заявки постачальникам";
            // 
            // dgvTransportRequests
            // 
            dgvTransportRequests.AllowUserToAddRows = false;
            dgvTransportRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransportRequests.BackgroundColor = SystemColors.Control;
            dgvTransportRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransportRequests.Location = new Point(6, 359);
            dgvTransportRequests.MultiSelect = false;
            dgvTransportRequests.Name = "dgvTransportRequests";
            dgvTransportRequests.ReadOnly = true;
            dgvTransportRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransportRequests.Size = new Size(1555, 263);
            dgvTransportRequests.TabIndex = 13;
            dgvTransportRequests.CellContentClick += dgvTransportRequests_CellContentClick;
            // 
            // dgvSupplierRequests
            // 
            dgvSupplierRequests.AllowUserToAddRows = false;
            dgvSupplierRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplierRequests.BackgroundColor = SystemColors.Control;
            dgvSupplierRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierRequests.Location = new Point(6, 44);
            dgvSupplierRequests.MultiSelect = false;
            dgvSupplierRequests.Name = "dgvSupplierRequests";
            dgvSupplierRequests.ReadOnly = true;
            dgvSupplierRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierRequests.Size = new Size(1555, 263);
            dgvSupplierRequests.TabIndex = 12;
            dgvSupplierRequests.CellContentClick += dgvSupplierRequests_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 716);
            Controls.Add(tabMain);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "Form1";
            tabMain.ResumeLayout(false);
            tabCars.ResumeLayout(false);
            tabCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            tabBuyers.ResumeLayout(false);
            tabBuyers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).EndInit();
            tabMatching.ResumeLayout(false);
            tabMatching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            tabRequests.ResumeLayout(false);
            tabRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierRequests).EndInit();
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
        private Button btnDeleteBuyer;
        private Button btnEditBuyer;
        private Button btnAddBuyer;
        private TextBox txtBuyerSearch;
        private Label label2;
        private Button button3;
        private DataGridView dgvBuyers;
        private Label label3;
        private DataGridView dgvMatches;
        private Button btnFindCars;
        private Button button1;
        private ComboBox cmbBuyers;
        private Button btnSupplierRequest;
        private Button btnTransportRequest;
        private DataGridView dgvTransportRequests;
        private DataGridView dgvSupplierRequests;
        private Button btnDeleteTransportRequest;
        private Label label4;
        private Button btnDeleteSupplierRequest;
        private Label label1;
    }
}
