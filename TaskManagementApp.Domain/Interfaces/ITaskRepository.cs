using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(int id);
        Task AddAsync(TaskItem task);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);
        Task ToggleCompleteAsync(int id);
    }
}
