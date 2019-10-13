using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class InputForm : Form
    {
        public string inText;
        public InputForm(string text = "Ввод")
        {
            InitializeComponent();
            lbInput.Text = text;
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            inText = tbInput.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
