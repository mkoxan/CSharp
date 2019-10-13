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
    public partial class InputMovieForm : Form
    {
        public Movie movie = null;
        public InputMovieForm(Movie movie = null)
        {
            InitializeComponent();
            if (movie != null)
            {
                tbName.Text = movie.Name;
                cbQuality.SelectedIndex = (int)movie.Quality;
                tbTime.Text = movie.Time.ToString();
            }
        }

        public void EditOrFind()
        {
            btAction.Text = "Изменить";
            this.ShowDialog();
        }
        private void BtAction_Click(object sender, EventArgs e)
        {
            int timeNum;
            if (tbName.Text != ""  && Int32.TryParse(tbTime.Text, out timeNum))
            {
                movie = new Movie(tbName.Text, Movie.StringToQuality(cbQuality.SelectedItem.ToString()), timeNum);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные. Повторите ввод.","Ошибка");
            }
        }
    }
}
