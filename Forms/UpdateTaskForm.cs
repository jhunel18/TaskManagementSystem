using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Forms
{

    public partial class UpdateTaskForm : Form
    {
        private TaskItem _task;
        public UpdateTaskForm(TaskItem task)
        {
            InitializeComponent();
            _task = task;
            PopulateFormFields();
        }

        private void PopulateFormFields()
        {
            if (_task != null)
            {
                // Assuming the form has TextBox controls named `txtSubject` and `txtDescription`
                txtTaskName.Text = _task.TaskName;
                rtxtDescription.Text = _task.TaskDescription;
                cboStatus.Text = _task.Status;
                // Add more fields as needed
            }
        }
    }
}
