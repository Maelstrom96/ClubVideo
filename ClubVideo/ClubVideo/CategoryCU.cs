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
    public partial class CategoryCU : Form
    {
        bool Modification_Mode = false;

        public CategoryCU()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public CategoryCU(CategoryObject obj) : this()
        {
            Modification_Mode = true;
            LoadLanguage();
        }

        private void LoadLanguage()
        {

            //Labels
            lb_Name_En.Text = Main.resManager.GetString("CategoryCU_Name_En", Main.culInfo);
            lb_Name_Fr.Text = Main.resManager.GetString("CategoryCU_Name_Fn", Main.culInfo);
            lb_Description_En.Text = Main.resManager.GetString("CategoryCU_Description_En", Main.culInfo);
            lb_Description_Fr.Text = Main.resManager.GetString("CategoryCU_Description_Fr", Main.culInfo);
            lb_Price.Text = Main.resManager.GetString("CategoryCU_Description_Fr", Main.culInfo);

            if (Modification_Mode)
            {
                bt_OK.Text = Main.resManager.GetString("CategoryCU_Modify", Main.culInfo);
                Text = Main.resManager.GetString("CategoryCU_Header_Modify", Main.culInfo);
            }
            else
            {
                bt_OK.Text = Main.resManager.GetString("CategoryCU_Add", Main.culInfo);
                Text = Main.resManager.GetString("CategoryCU_Header_Add", Main.culInfo);
            }
        }
    }
}
