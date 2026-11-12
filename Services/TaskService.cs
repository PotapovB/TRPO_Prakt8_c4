using TRPO_Prakt8.Models;
using Task = TRPO_Prakt8.Models.Task;

namespace TRPO_Prakt8.Services
{
    public class TaskService
    {
        private readonly MyDbContext _context = DbService.Instance.Context;

        private List<Task> tasks = new();

        public List<Task> GetAll()
        {
            var _tasks = _context.Tasks.ToList();

            tasks.Clear();
            foreach (var task in _tasks)
            {
                tasks.Add(task);
            }

            return tasks;
        }

        public void Add(Task task)
        {
            _context.Tasks.Add(task);
            Commit();
        }

        public void Delete(Task task)
        {
            _context.Tasks.Remove(task);
            Commit();
        }

        public int Commit() => _context.SaveChanges();
    }
}
