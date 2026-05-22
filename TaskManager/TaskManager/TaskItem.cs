using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    /// <summary>
    /// Представляет задачу с названием, описанием, датой, приоритетом и статусом выполнения.
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// Уникальный идентификатор задачи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Дата выполнения
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public TaskPriority Priority { get; set; }
        /// <summary>
        /// Статус выполнения задачи
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Возвращает строковое представление задачи для отображения в списке.
        /// </summary>
        public override string ToString()
        {
            string status = IsCompleted ? "✔" : "○";
            string priorityStr = Enum.GetName(typeof(TaskPriority), Priority) ?? Priority.ToString();
            return $"{status} {Id}: {Title} ({DueDate.ToShortDateString()}, {priorityStr})";
        }
    }
}
