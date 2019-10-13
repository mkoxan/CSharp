using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    [Serializable]
    public enum enumQuality { Low, Medium, High, Null = -1}
    [Serializable]
    public class Movie
    {
        private enumQuality quality;
        private string name;
        private int time;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Название фильма задано пустой строкой!");
                }
            }
        }
        public enumQuality Quality
        {
            get
            {
                return quality;
            }
            set
            {
                quality = value;
            }
        }
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                time = value;
            }
        }

        public Movie()
        {
            this.Name = "MovieName";
            this.Quality = enumQuality.Low;
            this.Time = 0;
        }
        public Movie(string Name, enumQuality Quality, int Time)
        {
            this.Name = Name;
            this.Quality = Quality;
            this.Time = Time;
        }
        public static enumQuality StringToQuality(string Quality)
        {
            Quality = Quality.Trim();
            if (Quality.ToLower() == "низкое")
            {
                return enumQuality.Low;
            }
            if (Quality.ToLower() == "среднее")
            {
                return enumQuality.Medium;
            }
            if (Quality.ToLower() == "высокое")
            {
                return enumQuality.High;
            }
            return enumQuality.Null;
        }
        public static string QualityToString(enumQuality Quality)
        {
            if (Quality == enumQuality.Low)
            {
                return "Низкое";
            }
            if (Quality == enumQuality.Medium)
            {
                return "Среднее";
            }
            if (Quality == enumQuality.High)
            {
                return "Высокое";
            }
            return "Неизвестно";
        }
        // Проверка строки на правильность
        public static bool CheckRow(DataGridViewRow row)
        {
            if (row.Cells[0].Value.ToString() == "")
            {
                return false;
            }
            int time = 0;
            if (!(Int32.TryParse(row.Cells[2].Value.ToString(), out time) && time >= 0))
            {
                return false;
            }
            enumQuality tempEnum = StringToQuality(row.Cells[1].Value.ToString());
            if (tempEnum == enumQuality.Null)
            {
                row.Cells[1].Value = "Неизвестно";
            }
            return true;
        }

        // Перевод из строки в экзмепляр Movie
        public static Movie RowToMovie(DataGridViewRow row)
        {
            return new Movie(row.Cells[0].Value.ToString(), StringToQuality(row.Cells[1].Value.ToString()), Int32.Parse(row.Cells[2].Value.ToString()));
        }
        // Перевод из Movie в строку
        public static DataGridViewRow MovieToRow(object obj, DataGridView dgv)
        {
            Movie movie = (Movie)obj;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv);
            row.HeaderCell.Value = (dgv.RowCount + 1).ToString();
            row.Cells[0].Value = movie.Name;
            row.Cells[1].Value = QualityToString(movie.Quality);
            row.Cells[2].Value = movie.Time;
            return row;
        }
    }
}
