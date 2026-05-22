namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.gbTaskData = new System.Windows.Forms.GroupBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.gbTaskData.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 22;
            this.listBoxTasks.Location = new System.Drawing.Point(410, 166);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTasks.Size = new System.Drawing.Size(420, 312);
            this.listBoxTasks.TabIndex = 0;
            this.listBoxTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxTasks_DrawItem);
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // gbTaskData
            // 
            this.gbTaskData.Controls.Add(this.chkCompleted);
            this.gbTaskData.Controls.Add(this.cbPriority);
            this.gbTaskData.Controls.Add(this.lblPriority);
            this.gbTaskData.Controls.Add(this.dtpDueDate);
            this.gbTaskData.Controls.Add(this.lblDate);
            this.gbTaskData.Controls.Add(this.txtDescription);
            this.gbTaskData.Controls.Add(this.lblDesc);
            this.gbTaskData.Controls.Add(this.txtTitle);
            this.gbTaskData.Controls.Add(this.lblTitle);
            this.gbTaskData.Location = new System.Drawing.Point(12, 12);
            this.gbTaskData.Name = "gbTaskData";
            this.gbTaskData.Size = new System.Drawing.Size(380, 350);
            this.gbTaskData.TabIndex = 1;
            this.gbTaskData.TabStop = false;
            this.gbTaskData.Text = "Данные задачи";
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnDelete);
            this.gbActions.Controls.Add(this.btnEdit);
            this.gbActions.Controls.Add(this.btnAdd);
            this.gbActions.Location = new System.Drawing.Point(12, 380);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(380, 100);
            this.gbActions.TabIndex = 2;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Действия";
            // 
            // gbFilters
            // 
            this.gbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilters.Controls.Add(this.cbFilter);
            this.gbFilters.Controls.Add(this.cbSort);
            this.gbFilters.Controls.Add(this.lblFilter);
            this.gbFilters.Controls.Add(this.lblSort);
            this.gbFilters.Location = new System.Drawing.Point(410, 12);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(420, 135);
            this.gbFilters.TabIndex = 3;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Сортировка и фильтры";
            this.gbFilters.Enter += new System.EventHandler(this.gbFilters_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(350, 25);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(15, 80);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(69, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(350, 80);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 195);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата выполнения:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(15, 215);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(350, 25);
            this.dtpDueDate.TabIndex = 5;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(15, 255);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(75, 17);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Приоритет:";
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbPriority.Location = new System.Drawing.Point(15, 275);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(160, 25);
            this.cbPriority.TabIndex = 7;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(190, 280);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(94, 21);
            this.chkCompleted.TabIndex = 8;
            this.chkCompleted.Text = "Выполнено";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(6, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(112, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(238, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить выбранные";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(15, 25);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(83, 17);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Сортировка:";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 80);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(145, 17);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Фильтр по приоритету:";
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "По дате ↑",
            "По дате ↓",
            "По приоритету"});
            this.cbSort.Location = new System.Drawing.Point(15, 45);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(190, 25);
            this.cbSort.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Low",
            "Medium",
            "High"});
            this.cbFilter.Location = new System.Drawing.Point(15, 100);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(190, 25);
            this.cbFilter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbTaskData);
            this.Controls.Add(this.listBoxTasks);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager — Управление задачами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTaskData.ResumeLayout(false);
            this.gbTaskData.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.GroupBox gbTaskData;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSort;
    }
}

