namespace Fernando_Caraballo_Assignment_2
{
    partial class MainMenu
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnBookingClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnExit.Location = new System.Drawing.Point(314, 272);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(163, 41);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnHelp.Location = new System.Drawing.Point(314, 229);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(163, 37);
            this.BtnHelp.TabIndex = 1;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnRegistration.Location = new System.Drawing.Point(314, 92);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(163, 41);
            this.BtnRegistration.TabIndex = 2;
            this.BtnRegistration.Text = "Registration";
            this.BtnRegistration.UseVisualStyleBackColor = true;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnSearch.Location = new System.Drawing.Point(314, 182);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(163, 37);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnBookingClass
            // 
            this.BtnBookingClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnBookingClass.Location = new System.Drawing.Point(314, 139);
            this.BtnBookingClass.Name = "BtnBookingClass";
            this.BtnBookingClass.Size = new System.Drawing.Size(163, 37);
            this.BtnBookingClass.TabIndex = 4;
            this.BtnBookingClass.Text = "Booking Class";
            this.BtnBookingClass.UseVisualStyleBackColor = true;
            this.BtnBookingClass.Click += new System.EventHandler(this.BtnBookingClass_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBookingClass);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRegistration);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnExit);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnBookingClass;
    }
}