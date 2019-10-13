using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace MainProject
{
    // Объявление делегатов для работы с файлами и объектами, не зависимо от их типа
    // Делегат для проверки строки на корректность
    public delegate bool RowCheck(DataGridViewRow row);
    // Делегат для перевода строки в объект
    public delegate object RowToObject(DataGridViewRow row);
    // Делегат для перевода объекта в строку
    public delegate DataGridViewRow ObjectToRow(object obj, DataGridView dgv);
    // Енам для типа файла
    public enum FileType { Text, Binary, XML };
    class FileManager
    {
        // Таблица, с которой производится работа
        DataGridView dgv;
        // Список из объектов, с которыми ведется работа
        List<object> objList;
        private string filepath;
        public string Filepath
        {
            get
            {
                return filepath;
            }
            set
            {
                filepath = value;
            }
        }
        // Переменные для делегатов
        private RowToObject rowToObject = null;
        private RowCheck rowCheck = null;
        private ObjectToRow objectToRow = null;
        public FileManager(DataGridView dgv, string filepath, List<object> objList = null)
        {
            this.dgv = dgv;
            this.objList = objList;
            this.filepath = filepath;
        }
        public void SetRowCheck(RowCheck rowCheck)
        {
            this.rowCheck = rowCheck;
        }
        public void SetRowToObject(RowToObject rowToObject)
        {
            this.rowToObject = rowToObject;
        }
        public void SetObjectToRow(ObjectToRow objectToRow)
        {
            this.objectToRow = objectToRow;
        }
        public bool Load(FileType fileType)
        {
            dgv.Rows.Clear();
            try
            {
                switch (fileType)
                {
                    case FileType.Text:
                        LoadTextFile();
                        break;
                    case FileType.Binary:
                        LoadBinaryFile();
                        break;
                    case FileType.XML:
                        LoadXmlFile();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
                return false;
            }
            return true;
        }
        public bool Save(FileType fileType)
        {
            try
            {
                switch (fileType)
                {
                    case FileType.Text:
                        SaveTextFile();
                        break;
                    case FileType.Binary:
                        SaveBinaryFile();
                        break;
                    case FileType.XML:
                        SaveXmlFile();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }
        /* 
         * Сохранение в текстовый файл. Формат: "Название столбаца": "Параметр строки в этом столбце"
         * Сверху единицы данных в текстовом файле находится индекс строки  
        */
        private bool SaveTextFile()
        {
            StreamWriter sw = new StreamWriter(filepath, false, Encoding.UTF8);
            int rowNum = 0;
            int columnNum = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                sw.Write((rowNum + 1) + "\r\n");
                columnNum = 0;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    sw.Write(column.HeaderCell.Value.ToString() + ": " + row.Cells[columnNum++].Value.ToString() + "\r\n");
                }
            }
            sw.Dispose();
            return true;
        }
        /* 
         * Загрузка из текстового файла. Ищется двоеточие, и после него берутся данные
        */
        private bool LoadTextFile()
        {
            StreamReader sr = new StreamReader(filepath, Encoding.UTF8);
            dgv.Rows.Clear();
            bool isFull = true;
            int rowAmount = 1;
            while (!sr.EndOfStream)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                foreach(DataGridViewCell cell in row.Cells)
                {
                    string tempStr;
                    int colon;
                    do
                    {
                        tempStr = sr.ReadLine();
                        colon = tempStr.IndexOf(':');
                    } while (colon == -1);
                    if (tempStr.Length >= colon + 2)
                    {
                        cell.Value = tempStr.Substring(colon + 2);
                    }
                    else
                    {
                        cell.Value = "";
                    }
                }
                if (rowCheck(row))
                {
                    row.HeaderCell.Value = rowAmount++.ToString();
                    dgv.Rows.Add(row);
                }
                else
                {
                    isFull = false;
                }
            }
            return isFull;
        }
        // Сохранение в бинарный файл
        private void SaveBinaryFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                List<object> objList = new List<object>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    objList.Add(rowToObject(row));
                }
                formatter.Serialize(fs, objList);
            }
        }
        // Загрузка бинарного файла
        private void LoadBinaryFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<object> objList = null;
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                objList = (List<object>)formatter.Deserialize(fs);
            }
            foreach(object obj in objList)
            {
                dgv.Rows.Add(objectToRow(obj, dgv));
            }

        }
        // Загрузку и сохранение xml файла не получилось сделать независимой от подстановки класса внутри методов
        // То есть в XmlSerializer нужно подставлять конкретный тип класса, а не объект
        // Подстановка переменной класса Type так же не помогла

        // Сохранение в Xml файл
        private void SaveXmlFile()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Movie>));
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                List<Movie> objList = new List<Movie>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    objList.Add((Movie)rowToObject(row));
                }
                formatter.Serialize(fs, objList);
            }
        }
        // Загрузка в Xml файл
        private void LoadXmlFile()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Movie>));
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                List<Movie> objList = (List<Movie>)formatter.Deserialize(fs);
                foreach (Movie obj in objList)
                {
                    dgv.Rows.Add(objectToRow(obj, dgv));
                }
            }
        } 
    }
}
