using System;
using System.Windows.Forms;

namespace TrieTree
{
    public partial class FrmInputWord : Form
    {
        public string InputText { get; private set; } = string.Empty;

        public FrmInputWord(string txt) {
            InitializeComponent();
            lblWordInput.Text = txt;
        }

        private void btnOk_Click(object sender, EventArgs e) {

            if (!TrieTree.CheckWord(tbInputWord.Text.ToLower().Trim())) {
                MessageBox.Show(@"Данные введены некорректно");
                tbInputWord.Focus();
                return;
            }
            InputText = tbInputWord.Text.ToLower().Trim();
            DialogResult = DialogResult.OK;
        }


        private void tbInputWord_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) &&
                !(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&      //!(e.KeyChar >= 'а' && e.KeyChar <= 'я') &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') )       // && !(e.KeyChar >= 'А' && e.KeyChar <= 'Я'))
                e.Handled = true;
        }
    }
}
