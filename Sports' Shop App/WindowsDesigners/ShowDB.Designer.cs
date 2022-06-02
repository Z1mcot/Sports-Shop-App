
namespace Sports__Shop_App
{
    partial class ShowDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderedCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_DeleteEntry = new System.Windows.Forms.Button();
            this.button_FindEntry = new System.Windows.Forms.Button();
            this.button_AddEntry = new System.Windows.Forms.Button();
            this.button_FilterEntries = new System.Windows.Forms.Button();
            this.textBox_NumFilter = new System.Windows.Forms.TextBox();
            this.label_FilterDescription = new System.Windows.Forms.Label();
            this.label_ProductTypeFilter = new System.Windows.Forms.Label();
            this.checkedListBox_ProductTypeFilter = new System.Windows.Forms.CheckedListBox();
            this.label_PriceFilter = new System.Windows.Forms.Label();
            this.textBox_LowerPriceFilter = new System.Windows.Forms.TextBox();
            this.textBox_HigherPriceFilter = new System.Windows.Forms.TextBox();
            this.label_MinusBetweenPriceFilters = new System.Windows.Forms.Label();
            this.textBox_DeleteEntry = new System.Windows.Forms.TextBox();
            this.label_CheckBoxWarning = new System.Windows.Forms.Label();
            this.button_SaveEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.CustomerName,
            this.ItemName,
            this.Quantity,
            this.OrderedCost});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // Number
            // 
            this.Number.Text = "№ Заказа";
            this.Number.Width = 70;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "ФИО Заказчика";
            this.CustomerName.Width = 228;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Название товара";
            this.ItemName.Width = 210;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Количество";
            this.Quantity.Width = 74;
            // 
            // OrderedCost
            // 
            this.OrderedCost.Text = "Стоимость заказа";
            this.OrderedCost.Width = 144;
            // 
            // button_DeleteEntry
            // 
            this.button_DeleteEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteEntry.Location = new System.Drawing.Point(47, 433);
            this.button_DeleteEntry.Name = "button_DeleteEntry";
            this.button_DeleteEntry.Size = new System.Drawing.Size(142, 40);
            this.button_DeleteEntry.TabIndex = 1;
            this.button_DeleteEntry.Text = "Удалить заказ по номеру";
            this.button_DeleteEntry.UseVisualStyleBackColor = true;
            this.button_DeleteEntry.Click += new System.EventHandler(this.button_DeleteEntry_Click);
            // 
            // button_FindEntry
            // 
            this.button_FindEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_FindEntry.Location = new System.Drawing.Point(405, 433);
            this.button_FindEntry.Name = "button_FindEntry";
            this.button_FindEntry.Size = new System.Drawing.Size(142, 40);
            this.button_FindEntry.TabIndex = 2;
            this.button_FindEntry.Text = "Найти заказ по номеру";
            this.button_FindEntry.UseVisualStyleBackColor = true;
            this.button_FindEntry.Click += new System.EventHandler(this.button_FindEntry_Click);
            // 
            // button_AddEntry
            // 
            this.button_AddEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddEntry.Location = new System.Drawing.Point(226, 433);
            this.button_AddEntry.Name = "button_AddEntry";
            this.button_AddEntry.Size = new System.Drawing.Size(142, 40);
            this.button_AddEntry.TabIndex = 3;
            this.button_AddEntry.Text = "Добавить заказ";
            this.button_AddEntry.UseVisualStyleBackColor = true;
            this.button_AddEntry.Click += new System.EventHandler(this.button_AddEntry_Click);
            // 
            // button_FilterEntries
            // 
            this.button_FilterEntries.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_FilterEntries.Location = new System.Drawing.Point(813, 433);
            this.button_FilterEntries.Name = "button_FilterEntries";
            this.button_FilterEntries.Size = new System.Drawing.Size(190, 40);
            this.button_FilterEntries.TabIndex = 4;
            this.button_FilterEntries.Text = "Отобразить выборку по признаку";
            this.button_FilterEntries.UseVisualStyleBackColor = true;
            this.button_FilterEntries.Click += new System.EventHandler(this.button_FilterEntries_Click);
            // 
            // textBox_NumFilter
            // 
            this.textBox_NumFilter.Location = new System.Drawing.Point(405, 399);
            this.textBox_NumFilter.Name = "textBox_NumFilter";
            this.textBox_NumFilter.Size = new System.Drawing.Size(70, 20);
            this.textBox_NumFilter.TabIndex = 6;
            this.textBox_NumFilter.TextChanged += new System.EventHandler(this.textBox_NumFilter_TextChanged);
            // 
            // label_FilterDescription
            // 
            this.label_FilterDescription.AutoSize = true;
            this.label_FilterDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FilterDescription.Location = new System.Drawing.Point(826, 12);
            this.label_FilterDescription.Name = "label_FilterDescription";
            this.label_FilterDescription.Size = new System.Drawing.Size(164, 21);
            this.label_FilterDescription.TabIndex = 7;
            this.label_FilterDescription.Text = "Фильтр отображения";
            // 
            // label_ProductTypeFilter
            // 
            this.label_ProductTypeFilter.AutoSize = true;
            this.label_ProductTypeFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label_ProductTypeFilter.Location = new System.Drawing.Point(806, 141);
            this.label_ProductTypeFilter.Name = "label_ProductTypeFilter";
            this.label_ProductTypeFilter.Size = new System.Drawing.Size(89, 13);
            this.label_ProductTypeFilter.TabIndex = 8;
            this.label_ProductTypeFilter.Text = "По типу товара";
            // 
            // checkedListBox_ProductTypeFilter
            // 
            this.checkedListBox_ProductTypeFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.checkedListBox_ProductTypeFilter.FormattingEnabled = true;
            this.checkedListBox_ProductTypeFilter.Items.AddRange(new object[] {
            "Adidas",
            "Nike",
            "Puma"});
            this.checkedListBox_ProductTypeFilter.Location = new System.Drawing.Point(809, 174);
            this.checkedListBox_ProductTypeFilter.Name = "checkedListBox_ProductTypeFilter";
            this.checkedListBox_ProductTypeFilter.Size = new System.Drawing.Size(208, 72);
            this.checkedListBox_ProductTypeFilter.TabIndex = 9;
            // 
            // label_PriceFilter
            // 
            this.label_PriceFilter.AutoSize = true;
            this.label_PriceFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label_PriceFilter.Location = new System.Drawing.Point(806, 53);
            this.label_PriceFilter.Name = "label_PriceFilter";
            this.label_PriceFilter.Size = new System.Drawing.Size(81, 13);
            this.label_PriceFilter.TabIndex = 10;
            this.label_PriceFilter.Text = "По стоимости";
            // 
            // textBox_LowerPriceFilter
            // 
            this.textBox_LowerPriceFilter.Location = new System.Drawing.Point(809, 86);
            this.textBox_LowerPriceFilter.Name = "textBox_LowerPriceFilter";
            this.textBox_LowerPriceFilter.Size = new System.Drawing.Size(86, 20);
            this.textBox_LowerPriceFilter.TabIndex = 11;
            this.textBox_LowerPriceFilter.Text = "0";
            // 
            // textBox_HigherPriceFilter
            // 
            this.textBox_HigherPriceFilter.Location = new System.Drawing.Point(931, 86);
            this.textBox_HigherPriceFilter.Name = "textBox_HigherPriceFilter";
            this.textBox_HigherPriceFilter.Size = new System.Drawing.Size(86, 20);
            this.textBox_HigherPriceFilter.TabIndex = 12;
            this.textBox_HigherPriceFilter.Text = "999999";
            // 
            // label_MinusBetweenPriceFilters
            // 
            this.label_MinusBetweenPriceFilters.AutoSize = true;
            this.label_MinusBetweenPriceFilters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MinusBetweenPriceFilters.Location = new System.Drawing.Point(907, 88);
            this.label_MinusBetweenPriceFilters.Name = "label_MinusBetweenPriceFilters";
            this.label_MinusBetweenPriceFilters.Size = new System.Drawing.Size(13, 13);
            this.label_MinusBetweenPriceFilters.TabIndex = 13;
            this.label_MinusBetweenPriceFilters.Text = "–";
            // 
            // textBox_DeleteEntry
            // 
            this.textBox_DeleteEntry.Location = new System.Drawing.Point(47, 399);
            this.textBox_DeleteEntry.Name = "textBox_DeleteEntry";
            this.textBox_DeleteEntry.Size = new System.Drawing.Size(100, 20);
            this.textBox_DeleteEntry.TabIndex = 14;
            // 
            // label_CheckBoxWarning
            // 
            this.label_CheckBoxWarning.AutoSize = true;
            this.label_CheckBoxWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label_CheckBoxWarning.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_CheckBoxWarning.Location = new System.Drawing.Point(810, 268);
            this.label_CheckBoxWarning.Name = "label_CheckBoxWarning";
            this.label_CheckBoxWarning.Size = new System.Drawing.Size(137, 52);
            this.label_CheckBoxWarning.TabIndex = 15;
            this.label_CheckBoxWarning.Text = "Стоит заметить, что \r\nотсутствие флажков \r\nозначает, отсутствие \r\nфильтра по типу" +
    " товара";
            // 
            // button_SaveEdit
            // 
            this.button_SaveEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveEdit.Location = new System.Drawing.Point(584, 433);
            this.button_SaveEdit.Name = "button_SaveEdit";
            this.button_SaveEdit.Size = new System.Drawing.Size(142, 40);
            this.button_SaveEdit.TabIndex = 16;
            this.button_SaveEdit.Text = "Сохранить изменения";
            this.button_SaveEdit.UseVisualStyleBackColor = true;
            this.button_SaveEdit.Click += new System.EventHandler(this.button_SaveEdit_Click);
            // 
            // ShowDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 487);
            this.Controls.Add(this.button_SaveEdit);
            this.Controls.Add(this.label_CheckBoxWarning);
            this.Controls.Add(this.textBox_DeleteEntry);
            this.Controls.Add(this.label_MinusBetweenPriceFilters);
            this.Controls.Add(this.textBox_HigherPriceFilter);
            this.Controls.Add(this.textBox_LowerPriceFilter);
            this.Controls.Add(this.label_PriceFilter);
            this.Controls.Add(this.checkedListBox_ProductTypeFilter);
            this.Controls.Add(this.label_ProductTypeFilter);
            this.Controls.Add(this.label_FilterDescription);
            this.Controls.Add(this.textBox_NumFilter);
            this.Controls.Add(this.button_FilterEntries);
            this.Controls.Add(this.button_AddEntry);
            this.Controls.Add(this.button_FindEntry);
            this.Controls.Add(this.button_DeleteEntry);
            this.Controls.Add(this.listView1);
            this.Name = "ShowDB";
            this.Text = "Система управления спортивным магазином. Отчет по товарам";
            this.Load += new System.EventHandler(this.ShowDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader OrderedCost;
        private System.Windows.Forms.Button button_DeleteEntry;
        private System.Windows.Forms.Button button_FindEntry;
        private System.Windows.Forms.Button button_AddEntry;
        private System.Windows.Forms.Button button_FilterEntries;
        private System.Windows.Forms.TextBox textBox_NumFilter;
        private System.Windows.Forms.Label label_FilterDescription;
        private System.Windows.Forms.Label label_ProductTypeFilter;
        private System.Windows.Forms.CheckedListBox checkedListBox_ProductTypeFilter;
        private System.Windows.Forms.Label label_PriceFilter;
        private System.Windows.Forms.TextBox textBox_LowerPriceFilter;
        private System.Windows.Forms.TextBox textBox_HigherPriceFilter;
        private System.Windows.Forms.Label label_MinusBetweenPriceFilters;
        private System.Windows.Forms.TextBox textBox_DeleteEntry;
        private System.Windows.Forms.Label label_CheckBoxWarning;
        private System.Windows.Forms.Button button_SaveEdit;
    }
}