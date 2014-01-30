using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AbstractCourse1
{
    public partial class EditForm : Form
    {
        public event Action<Task,EditForm> Save;
        public event Action<Task,EditForm> JustClose;
        public event Action<Task,EditForm> Cancel;
        public enum EditType
        {
            Edit,New
        }
        EditType _editmode;
        Task _task;
        public EditForm(EditType EditMode,Task StartValue)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(EditForm_FormClosing);
            _editmode = EditMode;
            _task = StartValue;
            Fill();
            switch (_editmode)
            {
                case EditType.New:
                    {
                        _task.ID = -1;
                        break;
                    }
                case EditType.Edit:
                    {
                        
                        break;
                    }
            }
        }
        private void  UpdateTask()
        {
            _task.Date=t_dates.Value  ;
            _task.Header=t_header.Text  ;
            _task.IsDone=t_IsDone.Checked  ;
            _task.Body=t_memo.Text  ;
             _task.Worker=t_worker.Text ;


        }
        
        private void Fill()
        {
            t_dates.Value = _task.Date;
            t_header.Text = _task.Header;
            t_IsDone.Checked = _task.IsDone;
            t_memo.Text = _task.Body;
            t_worker.Text = _task.Worker;
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTask();
                JustClose.Invoke(_task, this);
            }
            catch (Exception ex)
            {
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTask();
                Save.Invoke(_task, this);
            }
            catch (Exception ex)
            {
            }
        }
        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTask();
                Cancel.Invoke(_task, this);
            }
            catch (Exception ex)
            {
            }
        }
        void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
