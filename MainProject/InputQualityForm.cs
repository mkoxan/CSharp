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
    public partial class InputQualityForm : Form
    {
        public enumQuality quality = enumQuality.Low;
        public InputQualityForm()
        {
            InitializeComponent();
            cbQuality.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            quality = Movie.StringToQuality(cbQuality.SelectedItem.ToString());
        }
    }
}
