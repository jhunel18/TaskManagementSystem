using TaskManagementSystem.Data;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.DAO
{
    public class TaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<TaskItem> GetAllTasks()
        {
            return _context.TaskItems.ToList();
        }

        public TaskItem GetTaskById(int id)
        {
            return _context.TaskItems.Find(id);
        }

        public void AddTask(TaskItem taskItem)
        {
            _context.TaskItems.Add(taskItem);
            _context.SaveChanges();
        }
        public void UpdateTask(TaskItem taskItem)
        {
            _context.TaskItems.Update(taskItem);
            _context.SaveChanges();
        }
        public void DeleteTask(int id)
        {
            var task = _context.TaskItems.Find(id);
            if (task != null)
            {
                _context.TaskItems.Remove(task);
                _context.SaveChanges();
            }
        }
    }
}
