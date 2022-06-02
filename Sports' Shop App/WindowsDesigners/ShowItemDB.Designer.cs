namespace Sports__Shop_App.WindowsDesigners
{
    partial class ShowItemDB
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
            this.listView_ItemDB = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_ItemDB
            // 
            this.listView_ItemDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.CustomerName,
            this.Price,
            this.itemWidth,
            this.itemLength,
            this.itemHeight});
            this.listView_ItemDB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_ItemDB.GridLines = true;
            this.listView_ItemDB.HideSelection = false;
            this.listView_ItemDB.Location = new System.Drawing.Point(12, 40);
            this.listView_ItemDB.Name = "listView_ItemDB";
            this.listView_ItemDB.Size = new System.Drawing.Size(776, 371);
            this.listView_ItemDB.TabIndex = 1;
            this.listView_ItemDB.UseCompatibleStateImageBehavior = false;
            this.listView_ItemDB.View = System.Windows.Forms.View.Details;
            this.listView_ItemDB.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // Number
            // 
            this.Number.Text = "№ Товара";
            this.Number.Width = 70;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Наименование";
            this.CustomerName.Width = 228;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость";
            this.Price.Width = 74;
            // 
            // itemWidth
            // 
            this.itemWidth.Text = "Ширина";
            this.itemWidth.Width = 144;
            // 
            // itemLength
            // 
            this.itemLength.Text = "Длина";
            this.itemLength.Width = 102;
            // 
            // itemHeight
            // 
            this.itemHeight.Text = "Высота";
            this.itemHeight.Width = 98;
            // 
            // ShowItemDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_ItemDB);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ShowItemDB";
            this.Text = "Отчёт по складу";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_ItemDB;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader itemWidth;
        private System.Windows.Forms.ColumnHeader itemLength;
        private System.Windows.Forms.ColumnHeader itemHeight;
    }
}