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
    public partial class SidebySideSelection : Form
    {
        List<string> startSelectionAllList;
        List<string> startSelectedList;

        public List<string> DeletedList;
        public List<string> AddedList;

        public SidebySideSelection(List<string> listSelectionAll, List<string> listSelected, string Header)
        {
            InitializeComponent();
            Init();

            // Set form header text
            Text = Header;

            // Backup Selections
            startSelectionAllList = new List<string>(listSelectionAll);
            startSelectedList = new List<string>(listSelected);

            // Write list
            AddStringList(listSelectionAll, lv_Selection);
            AddStringList(listSelected, lv_Selected);
            Main.UpdateFonts(this);
            this.Text = Main.resManager.GetString("User_Permission_Header", Main.culInfo);
        }

        private void Init()
        {
            DeletedList = new List<string>();
            AddedList = new List<string>();
        }

        private void AddStringList(List<String> items, ListBox listView)
        {
            foreach (string item in items)
            {
                if (!startSelectedList.Contains(item) || listView.Name != "lv_Selection") listView.Items.Add(item);
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            AddSelected();
        }

        private void AddSelected()
        {
            for (int i = lv_Selection.SelectedItems.Count - 1; i >= 0; i--)
            {
                lv_Selected.Items.Add(lv_Selection.SelectedItems[i]);
                lv_Selection.Items.Remove(lv_Selection.SelectedItems[i]);
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void RemoveSelected()
        {
            for(int i = lv_Selected.SelectedItems.Count - 1; i >= 0; i--)
            {
                lv_Selection.Items.Add(lv_Selected.SelectedItems[i]);
                lv_Selected.Items.Remove(lv_Selected.SelectedItems[i]);
            }
        }

        private void RemoveAll()
        {
            for (int i = lv_Selected.Items.Count - 1; i >= 0; i--)
            {
                lv_Selection.Items.Add(lv_Selected.Items[i]);
                lv_Selected.Items.Remove(lv_Selected.Items[i]);
            }
        }

        private void bt_Erase_Click(object sender, EventArgs e)
        {
            RemoveAll();
        }

        private void bt_Accept_Click(object sender, EventArgs e)
        {
            GetDifferences();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void GetDifferences()
        {
            foreach (string perm in lv_Selected.Items)
            {
                if (!startSelectedList.Contains(perm)) AddedList.Add(perm);
            }

            foreach (string perm in startSelectedList)
            {
                if (!lv_Selected.Items.Contains(perm)) DeletedList.Add(perm);
            }
        }
    }
}
