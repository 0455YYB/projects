using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace accessConnection
{
    public class initializeMenuStrip
    {
        MenuStrip MenuStrip;
        public static void createMenuStrip(MenuStrip ms)
        {
            ToolStripMenuItem topMenu = new ToolStripMenuItem();
            topMenu.Name = "top菜单1";
            topMenu.Text = "top菜单1";
            ms.Items.Add(topMenu);

            ToolStripDropDownMenu seccondMenu = new ToolStripDropDownMenu();
            seccondMenu.Name = "seccond菜单1";
            seccondMenu.Text = "seccond菜单1";
            
        }

        private void menu_click(object senders,EventArgs e)
        {

        }
    }
}
