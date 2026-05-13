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
            btnCars = new Button();
            btnBuyers = new Button();
            btnMatching = new Button();
            btnRequests = new Button();
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
            // btnCars
            // 
            btnCars.Location = new Point(12, 49);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(95, 23);
            btnCars.TabIndex = 1;
            btnCars.Text = "Автомобілі";
            btnCars.UseVisualStyleBackColor = true;
            btnCars.Click += btnCars_Click;
            // 
            // btnBuyers
            // 
            btnBuyers.Location = new Point(12, 78);
            btnBuyers.Name = "btnBuyers";
            btnBuyers.Size = new Size(95, 23);
            btnBuyers.TabIndex = 2;
            btnBuyers.Text = "Покупці";
            btnBuyers.UseVisualStyleBackColor = true;
            btnBuyers.Click += btnBuyers_Click;
            // 
            // btnMatching
            // 
            btnMatching.Location = new Point(12, 107);
            btnMatching.Name = "btnMatching";
            btnMatching.Size = new Size(95, 23);
            btnMatching.TabIndex = 3;
            btnMatching.Text = "Підбір авто";
            btnMatching.UseVisualStyleBackColor = true;
            btnMatching.Click += btnMatching_Click;
            // 
            // btnRequests
            // 
            btnRequests.Location = new Point(12, 136);
            btnRequests.Name = "btnRequests";
            btnRequests.Size = new Size(95, 23);
            btnRequests.TabIndex = 4;
            btnRequests.Text = "Заявки";
            btnRequests.UseVisualStyleBackColor = true;
            btnRequests.Click += btnRequests_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRequests);
            Controls.Add(btnMatching);
            Controls.Add(btnBuyers);
            Controls.Add(btnCars);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCars;
        private Button btnBuyers;
        private Button btnMatching;
        private Button btnRequests;
    }
}
