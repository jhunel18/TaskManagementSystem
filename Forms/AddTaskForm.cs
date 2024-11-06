using TaskManagementSystem.Controllers;
using TaskManagementSystem.DAO;
using TaskManagementSystem.Data;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Forms
{
    public partial class AddTaskForm : Form
    {
        private readonly TaskController _taskController;
        public event Action TaskAdded;
        public AddTaskForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var taskRepository = new TaskRepository(context);
            var taskService = new TaskService(taskRepository);
            _taskController = new TaskController(taskService);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string description = rtxtDescription.Text;
            string status = cboStatus.Text;

            _taskController.AddTask(taskName, description, status);
            MessageBox.Show("Added Successfully", "Information");

            //Raise the event to notify the Main Form
            TaskAdded?.Invoke();
            this.Close();


        }
    }
}
