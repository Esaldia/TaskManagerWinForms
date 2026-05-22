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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gbFilters_Enter(object sender, EventArgs e)
        {

        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0 || e.Index >= listBoxTasks.Items.Count) return;

            var task = listBoxTasks.Items[e.Index] as TaskItem;
            if (task == null) return;

            // Определяем цвет текста по ТЗ
            Brush textBrush = task.IsCompleted ? Brushes.Black
                              : (task.DueDate < DateTime.Today ? Brushes.Red : Brushes.Black);

            // Рисуем текст
            e.Graphics.DrawString(task.ToString(), e.Font, textBrush, e.Bounds);
            e.DrawFocusRectangle(); // Подсветка при выделении клавиатурой
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
