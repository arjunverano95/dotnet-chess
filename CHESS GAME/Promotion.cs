using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHESS_GAME
{
    public partial class Promotion : Form
    {
        public Promotion()
        {
            InitializeComponent();
        }
        public string color = "";
        Image icon;
        string name = "";
        private void Promotion_Load(object sender, EventArgs e)
        {
            if (color == "white")
            {
                pnlWhite.Visible = true;
            }
            else
            {
                pnlBlack.Visible = true;
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            Promote.name = name;
            Promote.icon = icon;
            this.Close();
        }

        private void w_rook_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked == true)
            {
                name = rdb.Name;
                foreach (Control ctrl in pnlBlack.Controls)
                {
                    if (ctrl.Name == rdb.Name + "icon")
                    {
                        icon = ctrl.BackgroundImage;
                        break;
                    }
                }
                foreach (Control ctrl in pnlWhite.Controls)
                {
                    if (ctrl.Name == rdb.Name + "icon")
                    {
                        icon = ctrl.BackgroundImage;
                        break;
                    }
                }
            }
        }
    }
}
