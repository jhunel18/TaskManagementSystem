using TaskManagementSystem.Forms;

namespace TaskManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
           AddTaskForm form = new AddTaskForm();
            form.ShowDialog();
        }
    }
}
