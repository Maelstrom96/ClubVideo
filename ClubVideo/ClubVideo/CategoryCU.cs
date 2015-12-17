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
        int obj_id = -1;

        CategoryObject category;

        public CategoryObject Category { get { return category; } }

        public CategoryCU()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public CategoryCU(CategoryObject obj) : this()
        {
            Modification_Mode = true;
            LoadLanguage();
            FillTextboxes(obj);
        }

        private void LoadLanguage()
        {

            //Labels
            lb_Name_En.Text = Main.resManager.GetString("CategoryCU_Name_En", Main.culInfo);
            lb_Name_Fr.Text = Main.resManager.GetString("CategoryCU_Name_Fr", Main.culInfo);
            lb_Description_En.Text = Main.resManager.GetString("CategoryCU_Description_En", Main.culInfo);
            lb_Description_Fr.Text = Main.resManager.GetString("CategoryCU_Description_Fr", Main.culInfo);
            lb_Price.Text = Main.resManager.GetString("CategoryCU_Price", Main.culInfo);

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

        private void FillTextboxes(CategoryObject obj)
        {
            obj_id = obj.ID;
            tb_Name_En.Text = obj.Name_En;
            tb_Name_Fr.Text = obj.Name_Fr;
            tb_Description_En.Text = obj.Description_En;
            tb_Description_Fr.Text = obj.Description_Fr;
            tb_Price.Text = obj.Price.ToString();
        }

        private CategoryObject GetFilledCategoryObject()
        {
            if (tb_Name_En.Text.Equals(string.Empty)) throw new Exception("NAME_EN_EMPTY");
            if (tb_Name_Fr.Text.Equals(string.Empty)) throw new Exception("NAME_FR_EMPTY");

            CategoryObject obj = new CategoryObject();

            obj.ID = obj_id;
            obj.Name_En = tb_Name_En.Text;
            obj.Name_Fr = tb_Name_Fr.Text;
            obj.Description_En = tb_Description_En.Text;
            obj.Description_Fr = tb_Description_Fr.Text;
            obj.Price = decimal.Parse(tb_Price.Text);

            return obj;
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (Modification_Mode)
            {

            }
            else
            {
                InsertCategory();
            }
        }

        private void InsertCategory()
        {
            // Checks
            // Should check if name already exist /*********TODO*********/

            CategoryObject obj = null;
            try
            {
                obj = GetFilledCategoryObject();
                Database_Connector.Insert.Category(obj);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("PRICE_IS_NULL");
            }
            catch (FormatException)
            {
                MessageBox.Show("PRICE_INVALIDE_FORMAT");
            }
            catch (OverflowException)
            {
                MessageBox.Show("PRICE_VALUE_OVERFLOW");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
