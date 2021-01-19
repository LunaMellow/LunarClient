using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarClient
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void NextFormTimer_Tick(object sender, EventArgs e)
        {
            NextFormTimer.Start();
            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                if (this.Opacity == 0.0)
                {
                    this.Opacity -= 0.3;
                }
                else
                {
                    NextFormTimer.Stop();
                    Login form = new Login();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
