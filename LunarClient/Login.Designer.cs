namespace LunarClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.RoudingEdges = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftBarRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.User = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfileRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RightPanel.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoudingEdges
            // 
            this.RoudingEdges.ElipseRadius = 35;
            this.RoudingEdges.TargetControl = this;
            // 
            // ExitRounding
            // 
            this.ExitRounding.ElipseRadius = 5;
            this.ExitRounding.TargetControl = this.ExitButton;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1084, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.RightPanel.Controls.Add(this.UserID);
            this.RightPanel.Location = new System.Drawing.Point(6, 39);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(225, 643);
            this.RightPanel.TabIndex = 1;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Controls.Add(this.pictureBox2);
            this.MiddlePanel.Controls.Add(this.ExitButton);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.Location = new System.Drawing.Point(6, 6);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Padding = new System.Windows.Forms.Padding(6);
            this.MiddlePanel.Size = new System.Drawing.Size(1125, 676);
            this.MiddlePanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LeftBarRounding
            // 
            this.LeftBarRounding.ElipseRadius = 35;
            this.LeftBarRounding.TargetControl = this.RightPanel;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Agency FB", 20F);
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(79, 9);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(64, 32);
            this.User.TabIndex = 1;
            this.User.Text = "User: ";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Agency FB", 20F);
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(79, 41);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(39, 32);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID: ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Agency FB", 20F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(130, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(27, 32);
            this.Username.TabIndex = 3;
            this.Username.Text = "...";
            this.Username.Click += new System.EventHandler(this.username_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Agency FB", 20F);
            this.UserID.ForeColor = System.Drawing.Color.White;
            this.UserID.Location = new System.Drawing.Point(116, -17);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(27, 32);
            this.UserID.TabIndex = 4;
            this.UserID.Text = "...";
            this.UserID.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(900, 594);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.User);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 113);
            this.panel1.TabIndex = 5;
            // 
            // ProfileRounding
            // 
            this.ProfileRounding.ElipseRadius = 35;
            this.ProfileRounding.TargetControl = this.panel1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(91)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1137, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.MiddlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Login";
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.MiddlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoudingEdges;
        private Bunifu.Framework.UI.BunifuElipse ExitRounding;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse LeftBarRounding;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse ProfileRounding;
    }
}