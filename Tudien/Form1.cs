using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tudien.BLL;
using Tudien.DTO;

namespace Tudien
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        DictionaryData dicData;
        DictionaryBLL dicBLL;
        public Form1()
        {
            InitializeComponent();
            cbWord.DisplayMember = "Key";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToCombobox(cbWord);
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.DataSource == null)
                return;

            DictionaryData data = cb.SelectedItem as DictionaryData;
            tbMeanning.Text = data.Meaning;
            tbExplanation.Text = data.Explanation;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Key = "";
            string Meaning = "";
            string Explanation = "";
            if (cbWord.Text.ToString() != "")
            {
                Key = cbWord.Text;
            }
            if (tbMeanning.Text.ToString() != "") { 
                Meaning = tbMeanning.Text;
            }
            if (tbExplanation.Text.ToString() != "") {
                Explanation = tbExplanation.Text;
            }
            dicData = new DictionaryData();
            dicData.setUp(Key,Meaning,Explanation);

            dicBLL = new DictionaryBLL();
            dicBLL.Them(dicData);

            dictionary = new DictionaryManager();
            dictionary.LoadDataToCombobox(cbWord);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Key = "";
            string Meaning = "";
            string Explanation = "";
            if (cbWord.Text.ToString() != "")
            {
                Key = cbWord.Text;
            }
            if (tbMeanning.Text.ToString() != "")
            {
                Meaning = tbMeanning.Text;
            }
            if (tbExplanation.Text.ToString() != "")
            {
                Explanation = tbExplanation.Text;
            }
            dicData = new DictionaryData();
            dicData.setUp(Key, Meaning, Explanation);

            dicBLL = new DictionaryBLL();
            dicBLL.Xoa(dicData);

            dictionary = new DictionaryManager();
            dictionary.LoadDataToCombobox(cbWord);
        }
    }
}
