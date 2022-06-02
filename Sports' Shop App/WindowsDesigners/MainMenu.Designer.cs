
namespace Sports__Shop_App
{
    partial class MainMenu
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
            this.ShopName = new System.Windows.Forms.Label();
            this.PutOrders = new System.Windows.Forms.Button();
            this.CreateReportOnItem = new System.Windows.Forms.Button();
            this.CreateFinancialReport = new System.Windows.Forms.Button();
            this.button_ShowItemBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopName
            // 
            this.ShopName.AutoSize = true;
            this.ShopName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopName.Location = new System.Drawing.Point(253, 30);
            this.ShopName.Name = "ShopName";
            this.ShopName.Size = new System.Drawing.Size(282, 37);
            this.ShopName.TabIndex = 0;
            this.ShopName.Text = "Спротивный магазин";
            this.ShopName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PutOrders
            // 
            this.PutOrders.Location = new System.Drawing.Point(234, 105);
            this.PutOrders.Name = "PutOrders";
            this.PutOrders.Size = new System.Drawing.Size(320, 60);
            this.PutOrders.TabIndex = 1;
            this.PutOrders.Text = "Разместить заказы";
            this.PutOrders.UseVisualStyleBackColor = true;
            this.PutOrders.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateReportOnItem
            // 
            this.CreateReportOnItem.Location = new System.Drawing.Point(234, 192);
            this.CreateReportOnItem.Name = "CreateReportOnItem";
            this.CreateReportOnItem.Size = new System.Drawing.Size(320, 60);
            this.CreateReportOnItem.TabIndex = 2;
            this.CreateReportOnItem.Text = "Создать отчет по заказам";
            this.CreateReportOnItem.UseVisualStyleBackColor = true;
            this.CreateReportOnItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateFinancialReport
            // 
            this.CreateFinancialReport.Enabled = false;
            this.CreateFinancialReport.Location = new System.Drawing.Point(234, 279);
            this.CreateFinancialReport.Name = "CreateFinancialReport";
            this.CreateFinancialReport.Size = new System.Drawing.Size(320, 60);
            this.CreateFinancialReport.TabIndex = 3;
            this.CreateFinancialReport.Text = "Создать финансовый отчет";
            this.CreateFinancialReport.UseVisualStyleBackColor = true;
            // 
            // button_ShowItemBD
            // 
            this.button_ShowItemBD.Location = new System.Drawing.Point(234, 366);
            this.button_ShowItemBD.Name = "button_ShowItemBD";
            this.button_ShowItemBD.Size = new System.Drawing.Size(320, 60);
            this.button_ShowItemBD.TabIndex = 4;
            this.button_ShowItemBD.Text = "Отчет по складу";
            this.button_ShowItemBD.UseVisualStyleBackColor = true;
            this.button_ShowItemBD.Click += new System.EventHandler(this.button_AddItemToBD_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 473);
            this.Controls.Add(this.button_ShowItemBD);
            this.Controls.Add(this.CreateFinancialReport);
            this.Controls.Add(this.CreateReportOnItem);
            this.Controls.Add(this.PutOrders);
            this.Controls.Add(this.ShopName);
            this.Name = "MainMenu";
            this.Text = "Система управления спортивным магазином. Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopName;
        private System.Windows.Forms.Button PutOrders;
        private System.Windows.Forms.Button CreateReportOnItem;
        private System.Windows.Forms.Button CreateFinancialReport;
        private System.Windows.Forms.Button button_ShowItemBD;
    }
}