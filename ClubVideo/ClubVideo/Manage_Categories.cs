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
            LoadCategories();
            LoadLanguage();
            Main.UpdateFonts(this);
            //Main.RefreshColors(this);
        }

        private void LoadCategories()
        {
            dgv_View.DataSource = Database.GetData.Categories();
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
                column.HeaderText = Main.resManager.GetString("Manage_Categories_" + column.Name, Main.culInfo);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CategoryCU formCategory = new CategoryCU();
            DialogResult dr = formCategory.ShowDialog();

            if (dr == DialogResult.OK) LoadCategories();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_View.SelectedRows)
            {
                try
                {
                    Database_Connector.Delete.Category(int.Parse(row.Cells[0].Value.ToString()));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadCategories();
        }

        private CategoryObject GetCategoryFromSelected()
        {
            CategoryObject obj = new CategoryObject();

            DataGridViewRow dgvRow = dgv_View.SelectedRows[0];

            obj.ID = int.Parse(dgvRow.Cells[0].Value.ToString());
            obj.Name_En = dgvRow.Cells[1].Value.ToString();
            obj.Name_Fr = dgvRow.Cells[2].Value.ToString();
            obj.Description_En = dgvRow.Cells[3].Value.ToString();
            obj.Description_Fr = dgvRow.Cells[4].Value.ToString();
            obj.Price = decimal.Parse(dgvRow.Cells[5].Value.ToString());

            return obj;
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            CategoryCU formCategory = new CategoryCU(GetCategoryFromSelected());
            DialogResult dr = formCategory.ShowDialog();

            if (dr == DialogResult.OK) LoadCategories();
        }

        private void bt_MouseEnter(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToWhite(sender.Name.Substring(3));
            sender.FlatAppearance.MouseOverBackColor = Main.GetColor();
            sender.ForeColor = Color.White;
        }

        private void bt_MouseLeave(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToColor(sender.Name.Substring(3), false);
            sender.FlatAppearance.MouseOverBackColor = Color.White;
            sender.ForeColor = Main.GetColor();
        }
    }
}
