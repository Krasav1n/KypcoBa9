using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AbstractCourse1
{
    public partial class Form1 : Form
    {
        DataEngine dt;
        string tableName = "data";
        string fileName = "Database.mdb";
        public Form1() //Инициализация формы
        {
            InitializeComponent();
            foreach (IceButton.IceButton i in tmenu.Controls)
            {
                i.Text = i.Tag.ToString();
            }
            try
            {
                if (!System.IO.File.Exists(fileName))
                {
                    System.IO.File.WriteAllBytes(fileName, Source.template);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Threading.Thread.CurrentThread.Abort();
            }
            dt = new DataEngine(fileName, "ID", "Dates", "Header", "Body", "Worker", "IsDone");
            LoadToGrid(dt.SelectAllTasks(tableName));
            iceButton1.Click += new EventHandler(iceButton1_Click); //Sea
            iceButton2.Click += new EventHandler(iceButton2_Click); //Add
            iceButton5.Click += new EventHandler(iceButton5_Click); //Delete one
            iceButton6.Click += new EventHandler(iceButton6_Click); //ToDay
            iceButton4.Click += new EventHandler(iceButton4_Click);
            iceButton3.Click += new EventHandler(iceButton3_Click);
            t_search.KeyDown += new KeyEventHandler(t_search_KeyDown);
            dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView1_CellDoubleClick);
        }
        void t_search_KeyDown(object sender, KeyEventArgs e) //Поиск
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1_Click(sender, e);
            }
        }
        void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)// Открытие записи
        {
            if (e.RowIndex >= 0)
            {
                long id =Convert.ToInt64( dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Task tmp = dt.SelectById(tableName, id);
                UseE_Form(EditForm.EditType.Edit, tmp);
            }
        }
        void UseE_Form(EditForm.EditType editMode,Task StartValue)//Создание и отображение диалога создания/редактирования
        {
            EditForm e_form;
            e_form = new EditForm(editMode, StartValue);
            e_form.Cancel += new Action<Task, EditForm>(e_form_Cancel);
            e_form.JustClose += new Action<Task, EditForm>(e_form_JustClose);
            e_form.Save += new Action<Task, EditForm>(e_form_Save);
            e_form.ShowDialog();
        } 
        #region UsingEvents
        void e_form_Cancel(Task arg1, EditForm arg2)
        {
            arg2.Close();
        }
        void e_form_JustClose(Task arg1, EditForm arg2)
        {
            DialogResult d;
            d = MessageBox.Show("Хотите сохранить?", "Save", MessageBoxButtons.YesNoCancel);
            switch (d)
            {
                case DialogResult.Yes:
                    {
                        e_form_Save(arg1, arg2);
                        LoadToGrid(dt.SelectAllTasks(tableName));
                        arg2.Close();
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                case DialogResult.No:
                    {
                        arg2.Close();
                        LoadToGrid(dt.SelectAllTasks(tableName));
                        break;
                    }
            }

        }
        void e_form_Save(Task arg1, EditForm arg2)
        {
            if (arg1.ID >= 0)
            {
                dt.UpdateTask(arg1, tableName);
            }
            else
            {
                dt.InsertNewTask(arg1, tableName);
            }
            MessageBox.Show("Сохранено");
        }
        #endregion
        void iceButton2_Click(object sender, EventArgs e) //Добавление новой задачи. Выводит форму редактирования
        {
            Task tmp;
            tmp = new Task();
            tmp.Date = DateTime.Now;
            UseE_Form(EditForm.EditType.New, tmp);
        }
        void iceButton5_Click(object sender, EventArgs e) //Удаление. Удаление выбраной записи с подтверждением
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DialogResult d;
                long id = Convert.ToInt64(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                Task tmp = dt.SelectById(tableName, id);
                d = MessageBox.Show("Вы точно хотите удалить эту запись? " + "\n" + tmp.Header + "\n" +
                    tmp.Body.PadRight(100), "Удаление", MessageBoxButtons.YesNo);
                switch (d)
                {
                    case DialogResult.Yes:
                        {
                            dt.DeleteTask(tableName, tmp);
                            MessageBox.Show("Удалено");
                            break;
                        }
                }
                LoadToGrid(dt.SelectAllTasks(tableName));
            }
            else
            {
                MessageBox.Show("Сначала выберите запись");
            }
        }
        void iceButton1_Click(object sender, EventArgs e) //Загрузка элементов в форму
        {
            LoadToGrid(dt.SelectAllTasks(tableName));
        }
        void iceButton4_Click(object sender, EventArgs e) //Выход. Завершение текущего потока
        {
            System.Threading.Thread.CurrentThread.Abort();
        }
        void iceButton6_Click(object sender, EventArgs e) //Текущие дела. Выборка по дате. Дата считается по лоакльному времени
        {
            LoadToGrid(dt.SelectByDate(tableName, DateTime.Now));
        }
        void iceButton3_Click(object sender, EventArgs e) //Удаление всего. Очитстка базы задач.
        {
            DialogResult dr;
            dr = MessageBox.Show("Вы точно хотите удалить все записи?", "Стереть все", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        dt.DeleteAllTask(tableName);
                        LoadToGrid(dt.SelectAllTasks(tableName));
                        MessageBox.Show("Удалено");
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }

            }

        }
        private void LoadToGrid(Task Onetask) //Загрузка одного элемента в таблицу
        {
            dataGridView1.Rows.Add(Onetask.ToValues());
        }
        private void LoadToGrid(Angar  tasks) //Массовая загрузка элементов в таблицу из хранилища
        {
            dataGridView1.Rows.Clear();
            foreach (Task t in tasks.Storage )
            {
                dataGridView1.Rows.Add(t.ToValues());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        public enum WordEn
        {
            /*
              Номер,
            Заголовок,
            Описание,
            Дата,
            Исполнитель
             */
            ID, Header, Body, TargetDate, Worker
        }
        private void label1_Click(object sender, EventArgs e) //Поиск
        {
            WordEn we;
            we = (WordEn)comboBox1.SelectedIndex;

            try
            {
                switch (we)
                {
                    case WordEn.ID:
                        {
                            if (t_search.Text != "")
                                LoadToGrid(dt.SelectTask(tableName, we.ToString(), Convert.ToInt64(t_search.Text).ToString(), ""));
                            break;
                        }
                    default:
                        {
                            LoadToGrid(dt.SelectTask(tableName, we.ToString(),
                                t_search.Text.Replace("'", "`"), "'"));
                            break;
                        }
                }
                MessageBox.Show("Готово");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) //Об авторе
        {
            Author at;
            at = new Author();
            at.ShowDialog();
        }

        private void iceButton1_Load(object sender, EventArgs e)
        {

        }

        private void iceButton2_Load(object sender, EventArgs e)
        {

        }

    }
}
