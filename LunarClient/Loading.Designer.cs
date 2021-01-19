namespace LunarClient
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.Rounding_Edges = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SquidLoading = new System.Windows.Forms.PictureBox();
            this.NextFormTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SquidLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Rounding_Edges
            // 
            this.Rounding_Edges.ElipseRadius = 35;
            this.Rounding_Edges.TargetControl = this;
            // 
            // SquidLoading
            // 
            this.SquidLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.SquidLoading.Image = ((System.Drawing.Image)(resources.GetObject("SquidLoading.Image")));
            this.SquidLoading.Location = new System.Drawing.Point(-201, -104);
            this.SquidLoading.Name = "SquidLoading";
            this.SquidLoading.Size = new System.Drawing.Size(1174, 624);
            this.SquidLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SquidLoading.TabIndex = 0;
            this.SquidLoading.TabStop = false;
            // 
            // NextFormTimer
            // 
            this.NextFormTimer.Enabled = true;
            this.NextFormTimer.Tick += new System.EventHandler(this.NextFormTimer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(424, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-59, 337);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(425, 153);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.SquidLoading);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SquidLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Rounding_Edges;
        private System.Windows.Forms.PictureBox SquidLoading;
        private System.Windows.Forms.Timer NextFormTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox Logo;
    }
}

