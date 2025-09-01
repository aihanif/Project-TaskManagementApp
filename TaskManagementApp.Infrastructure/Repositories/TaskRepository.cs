using System.Net.Http.Json;
using TaskManagementApp.Domain.Entities;
using TaskManagementApp.Domain.Interfaces;

namespace TaskManagementApp.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly HttpClient _http;
        private readonly string baseUrl = "https://hanifwork.com/TASK_project/Services";

        public TaskRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<TaskItem>> GetAllAsync() =>
            await _http.GetFromJsonAsync<List<TaskItem>>(baseUrl) ?? new List<TaskItem>();

        public async Task<TaskItem?> GetByIdAsync(int id)
        {
            var tasks = await GetAllAsync();
            return tasks.FirstOrDefault(t => t.Id == id);
        }

        public async Task AddAsync(TaskItem task) =>
            await _http.PostAsJsonAsync(baseUrl, task);

        public async Task UpdateAsync(TaskItem task) =>
            await _http.PutAsJsonAsync($"{baseUrl}?id={task.Id}", task);

        public async Task DeleteAsync(int id) =>
            await _http.DeleteAsync($"{baseUrl}?id={id}");

        public async Task ToggleCompleteAsync(int id) =>
            await _http.PostAsync($"{baseUrl}?toggle=1&id={id}", null);
    }
}
