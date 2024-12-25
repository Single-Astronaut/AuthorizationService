namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; } //Свойство Id выступает в качестве уникального ключа реляционной базы данных
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; } //Предотвращение избыточной публикации с применением DTO, добавляем поле секрета
}