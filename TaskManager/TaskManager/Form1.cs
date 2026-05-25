using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    /// <summary>
    /// Главная форма приложения TaskManager.
    /// Предоставляет интерфейс для добавления, редактирования, удаления, сортировки и фильтрации задач. Все данные хранятся только в оперативной памяти.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Коллекция всех задач, хранящаяся в памяти во время работы приложения.
        /// </summary>
        private readonly List<TaskItem> _tasks = new List<TaskItem>();

        /// <summary>
        /// Счётчик для генерации уникальных идентификаторов задач.
        /// </summary>
        private int _nextId = 1;

        /// <summary>
        /// Инициализирует новый экземпляр формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Устанавливает значения по умолчанию для ComboBox'ов и дату.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Приоритет по умолчанию — Medium
            cbPriority.SelectedIndex = 1;

            // Сортировка по умолчанию — по дате (возрастание)
            cbSort.SelectedIndex = 0;

            // Фильтр по умолчанию — все задачи
            cbFilter.SelectedIndex = 0;

            // Дата выполнения по умолчанию — сегодня
            dtpDueDate.Value = DateTime.Today;
        }

        /// <summary>
        /// Обработчик нажатия кнопки «Добавить».
        /// Создаёт новую задачу на основе данных из полей ввода и добавляет её в коллекцию.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title;
            string description;
            DateTime dueDate;
            TaskPriority priority;

            if (!ValidateTaskInput(out title, out description, out dueDate, out priority))
            {
                return;
            }

            var newTask = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                DueDate = dueDate,
                Priority = priority,
                IsCompleted = chkCompleted.Checked
            };

            _tasks.Add(newTask);
            RefreshTaskList();
            ClearInputFields();
        }

        /// <summary>
        /// Обработчик нажатия кнопки «Редактировать».
        /// Обновляет данные выбранной в ListBox задачи значениями из полей ввода.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            TaskItem selected = GetSingleSelectedTask();
            if (selected == null)
            {
                return;
            }

            string title;
            string description;
            DateTime dueDate;
            TaskPriority priority;

            if (!ValidateTaskInput(out title, out description, out dueDate, out priority))
            {
                return;
            }

            selected.Title = title;
            selected.Description = description;
            selected.DueDate = dueDate;
            selected.Priority = priority;
            selected.IsCompleted = chkCompleted.Checked;

            RefreshTaskList();
            ClearInputFields();
        }

        /// <summary>
        /// Обработчик нажатия кнопки «Удалить выбранные».
        /// Удаляет из коллекции все задачи, выделенные в ListBox.
        /// Поддерживает множественное выделение.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Не выбрана задача для выполнения действия",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Копируем выделенные задачи в отдельный список,
            // чтобы избежать изменения коллекции во время итерации.
            var toRemove = new List<TaskItem>();
            foreach (object item in listBoxTasks.SelectedItems)
            {
                TaskItem task = item as TaskItem;
                if (task != null)
                {
                    toRemove.Add(task);
                }
            }

            foreach (TaskItem task in toRemove)
            {
                _tasks.Remove(task);
            }

            RefreshTaskList();
            ClearInputFields();
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в ListBox.
        /// Загружает данные выбранной задачи в поля ввода формы.
        /// </summary>
        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskItem selected = GetSingleSelectedTask(silent: true);
            if (selected == null)
            {
                return;
            }

            LoadTaskToFields(selected);
        }

        /// <summary>
        /// Обработчик изменения выбранного варианта сортировки.
        /// Перерисовывает список задач с учётом нового порядка.
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        /// <summary>
        /// Обработчик изменения выбранного фильтра по приоритету.
        /// Перерисовывает список задач с учётом нового фильтра.
        /// </summary>
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        /// <summary>
        /// Обработчик изменения приоритета в ComboBox.
        /// </summary>
        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Обработчик события входа в GroupBox «Сортировка и фильтры».
        /// </summary>
        private void gbFilters_Enter(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Обработчик события отрисовки элемента ListBox.
        /// Отображает просроченные невыполненные задачи красным цветом,
        /// остальные — чёрным.
        /// </summary>
        private void listBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0 || e.Index >= listBoxTasks.Items.Count)
            {
                return;
            }

            TaskItem task = listBoxTasks.Items[e.Index] as TaskItem;
            if (task == null)
            {
                return;
            }

            // Цвет текста:
            // - красный, если задача просрочена и не выполнена;
            // - чёрный во всех остальных случаях (в том числе для выполненных просроченных).
            Brush textBrush;
            if (!task.IsCompleted && task.DueDate.Date < DateTime.Today)
            {
                textBrush = Brushes.Red;
            }
            else
            {
                textBrush = Brushes.Black;
            }

            e.Graphics.DrawString(task.ToString(), e.Font, textBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Обновляет содержимое ListBox с учётом текущих настроек сортировки и фильтрации.
        /// </summary>
        private void RefreshTaskList()
        {
            listBoxTasks.BeginUpdate();
            try
            {
                listBoxTasks.Items.Clear();

                IEnumerable<TaskItem> query = _tasks.AsEnumerable();

                // Фильтрация по приоритету
                string filter = cbFilter.SelectedItem as string;
                if (!string.IsNullOrEmpty(filter) && filter != "All")
                {
                    TaskPriority filterPriority;
                    if (Enum.TryParse(filter, out filterPriority))
                    {
                        query = query.Where(t => t.Priority == filterPriority);
                    }
                }

                // Сортировка
                string sort = cbSort.SelectedItem as string;
                if (!string.IsNullOrEmpty(sort))
                {
                    if (sort.StartsWith("По дате"))
                    {
                        if (sort.Contains("↑"))
                        {
                            query = query.OrderBy(t => t.DueDate);
                        }
                        else
                        {
                            query = query.OrderByDescending(t => t.DueDate);
                        }
                    }
                    else if (sort.StartsWith("По приоритету"))
                    {
                        // High → Medium → Low (по убыванию "важности")
                        query = query.OrderByDescending(t => (int)t.Priority);
                    }
                }

                foreach (TaskItem task in query)
                {
                    listBoxTasks.Items.Add(task);
                }
            }
            finally
            {
                listBoxTasks.EndUpdate();
            }
        }

        /// <summary>
        /// Очищает поля ввода формы и сбрасывает значения на значения по умолчанию.
        /// </summary>
        private void ClearInputFields()
        {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtpDueDate.Value = DateTime.Today;
            cbPriority.SelectedIndex = 1;
            chkCompleted.Checked = false;

            listBoxTasks.ClearSelected();
        }

        /// <summary>
        /// Загружает данные указанной задачи в поля ввода формы.
        /// </summary>
        private void LoadTaskToFields(TaskItem task)
        {
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            dtpDueDate.Value = task.DueDate;
            cbPriority.SelectedItem = task.Priority.ToString();
            chkCompleted.Checked = task.IsCompleted;
        }

        /// <summary>
        /// Возвращает единственную выбранную в ListBox задачу.
        /// Если не выбрана ни одна задача — показывает предупреждение.
        /// Если выбрано несколько задач — возвращает null без предупреждения.
        /// </summary>
        private TaskItem GetSingleSelectedTask(bool silent = false)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                if (!silent)
                {
                    MessageBox.Show(
                        "Не выбрана задача для выполнения действия",
                        "Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return null;
            }

            return listBoxTasks.SelectedItem as TaskItem;
        }

        /// <summary>
        /// Проверяет корректность данных, введённых пользователем в поля формы.
        /// При ошибке отображает соответствующее сообщение.
        /// </summary>
        private bool ValidateTaskInput(
            out string title,
            out string description,
            out DateTime dueDate,
            out TaskPriority priority)
        {
            title = txtTitle.Text.Trim();
            description = txtDescription.Text.Trim();
            dueDate = dtpDueDate.Value;
            priority = TaskPriority.Medium;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(
                    "Название задачи не может быть пустым.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            object selectedPriority = cbPriority.SelectedItem;
            if (selectedPriority == null)
            {
                MessageBox.Show(
                    "Выберите приоритет задачи.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!Enum.TryParse(selectedPriority.ToString(), out priority))
            {
                MessageBox.Show(
                    "Некорректное значение приоритета.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Обработчик изменения текста в поле описания.
        /// </summary>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}