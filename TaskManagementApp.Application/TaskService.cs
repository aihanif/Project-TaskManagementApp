

using TaskManagementApp.Domain.Entities;    // ✅ TaskItem
using TaskManagementApp.Domain.Interfaces;  // ✅ ITaskRepository

namespace TaskManagementApp.Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _repo;

        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }

        public Task<List<TaskItem>> GetTasks() => _repo.GetAllAsync();
        public Task AddTask(TaskItem task) => _repo.AddAsync(task);
        public Task DeleteTask(int id) => _repo.DeleteAsync(id);
        public Task ToggleComplete(int id) => _repo.ToggleCompleteAsync(id);
        public Task UpdateTask(TaskItem task) => _repo.UpdateAsync(task);
    }
}
