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
    public partial class MainForm : Form
    {
        FileType fileType;
        // Класс для работы с файлами
        FileManager fm = null;
        public MainForm()
        {
            InitializeComponent();
            dgv.TopLeftHeaderCell.Value = "№";
            fm = new FileManager(dgv, "");
            fm.SetRowCheck(Movie.CheckRow);
            fm.SetRowToObject(Movie.RowToMovie);
            fm.SetObjectToRow(Movie.MovieToRow);
        }
        // Обновление индексов
        public void RefreshIndex()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            InputMovieForm inForm = new InputMovieForm();
            if (inForm.ShowDialog() == DialogResult.OK)
            {
                dgv.Rows.Add(Movie.MovieToRow(inForm.movie, dgv));
            }
            inForm.Dispose();
        }
        private void ChangeRow(DataGridViewRow row)
        {
            InputMovieForm inForm = new InputMovieForm(Movie.RowToMovie(row));
            inForm.EditOrFind();
            if (inForm.DialogResult == DialogResult.OK)
            {
                int index = row.Index;
                dgv.Rows.RemoveAt(index);
                dgv.Rows.Insert(index, Movie.MovieToRow(inForm.movie, dgv));
                RefreshIndex();
            }
            inForm.Dispose();
        }
        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeRow(dgv.SelectedRows[0]);
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.Remove(row);
                }
                RefreshIndex();
            }
        }
        List<DataGridViewRow> backList = new List<DataGridViewRow>();
        private void BtTask_Click(object sender, EventArgs e)
        {
            InputQualityForm qualityForm = new InputQualityForm();
            InputForm timeForm = new InputForm("Введите максимальную длительность:");
            int time = 0;
            if (qualityForm.ShowDialog() == DialogResult.OK && timeForm.ShowDialog() == DialogResult.OK &&
                Int32.TryParse(timeForm.inText, out time) && time > 0)
            {
                enumQuality quality = qualityForm.quality;
                qualityForm.Dispose();
                timeForm.Dispose();
                List<DataGridViewRow> rowList = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (Movie.StringToQuality(row.Cells[1].Value.ToString()) != quality || Int32.Parse(row.Cells[2].Value.ToString()) > time)
                    {
                        rowList.Add(row);
                        backList.Add(Movie.MovieToRow(Movie.RowToMovie(row), dgv));
                    }
                }
                foreach (DataGridViewRow row in rowList)
                {
                    dgv.Rows.Remove(row);
                }
                dgv.Sort(dgv.Columns[2], ListSortDirection.Ascending);
            }
            else if (time <= 0)
            {
                MessageBox.Show("Вы ввели некорректное время");
            }

        }

        private void MenuOpenText_Click(object sender, EventArgs e)
        {
            fileType = FileType.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                fm.Load(fileType);
            }
        }

        private void MenuSaveAsText_Click(object sender, EventArgs e)
        {
            fileType = FileType.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                fm.Save(fileType);
            }
        }

        private void MenuSaveAsBinary_Click(object sender, EventArgs e)
        {
            fileType = FileType.Binary;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                fm.Save(fileType);
            }
        }

        private void MenuOpenBinary_Click(object sender, EventArgs e)
        {
            fileType = FileType.Binary;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                fm.Load(fileType);
            }
        }

        private void MenuOpenXml_Click(object sender, EventArgs e)
        {
            fileType = FileType.XML;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                fm.Load(fileType);
            }
        }

        private void MenuSaveAsXml_Click(object sender, EventArgs e)
        {
            fileType = FileType.XML;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                fm.Save(fileType);
            }
        }
        private void AddBackRows()
        {
            if (backList.Count != 0)
            {
                foreach (DataGridViewRow row in backList)
                {
                    dgv.Rows.Add(row);
                }
                backList.Clear();
                RefreshIndex();
            }
        }

        private void Dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
            //AddBackRows();
        }

        private void Dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
            //AddBackRows();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (fm.Filepath != "")
            {
                fm.Save(fileType);
            }
        }

        private void MenuCreate_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            fm.Filepath = "";
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void СброситьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBackRows();
        }
    }
}
