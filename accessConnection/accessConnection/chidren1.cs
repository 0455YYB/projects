using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace accessConnection
{
   public class chidren1:Form
    {
        public chidren1()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // chidren1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "chidren1";
            this.Load += new System.EventHandler(this.chidren1_Load);
            this.ResumeLayout(false);

        }

        private void chidren1_Load(object sender, EventArgs e)
        {

        }
    }
}
