using System.Text.Json.Serialization;

namespace TaskManagementApp.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;   
        [JsonPropertyName("is_completed")]   
        public bool is_complete { get; set; }   
        [JsonPropertyName("created_at")]  
        public string created_at { get; set; } =  string.Empty;
    }
}