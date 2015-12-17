using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubVideo
{
    public partial class Manage_Categories : Form
    {
        public Manage_Categories()
        {
            InitializeComponent();
            LoadLanguage();
        }

        private void LoadLanguage()
        {
            Text = Main.resManager.GetString("Manage_Categories_Header", Main.culInfo);
            lb_Search.Text = Main.resManager.GetString("Manage_Categories_Search", Main.culInfo);

            // Tooltips
            toolTip.SetToolTip(btn_Add, Main.resManager.GetString("Manage_Categories_Add_Tip", Main.culInfo));
            toolTip.SetToolTip(btn_Modify, Main.resManager.GetString("Manage_Categories_Modify_Tip", Main.culInfo));
            toolTip.SetToolTip(btn_Delete, Main.resManager.GetString("Manage_Categories_Delete_Tip", Main.culInfo));
            toolTip.SetToolTip(tb_Search, Main.resManager.GetString("Manage_Categories_Search_Tip", Main.culInfo));
            toolTip.SetToolTip(lb_Search, Main.resManager.GetString("Manage_Categories_Search_Tip", Main.culInfo));

            // DGV Column Header Text
            foreach (DataGridViewColumn column in dgv_View.Columns)
            {
                column.HeaderText = Main.resManager.GetString("Manage_Members_" + column.Name, Main.culInfo);
            }
        }
    }
}
