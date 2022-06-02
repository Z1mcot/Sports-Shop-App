
namespace Sports__Shop_App
{
    partial class PutOrdersForm__
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
            this.label_BigSignOnCentre = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_PutOrder = new System.Windows.Forms.Button();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.button_SaveEntries = new System.Windows.Forms.Button();
            this.label_Width = new System.Windows.Forms.Label();
            this.label_Length = new System.Windows.Forms.Label();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.label_Height = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label_VolumeOrArea = new System.Windows.Forms.Label();
            this.button_ShowSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_BigSignOnCentre
            // 
            this.label_BigSignOnCentre.AutoSize = true;
            this.label_BigSignOnCentre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BigSignOnCentre.Location = new System.Drawing.Point(75, 45);
            this.label_BigSignOnCentre.Name = "label_BigSignOnCentre";
            this.label_BigSignOnCentre.Size = new System.Drawing.Size(650, 30);
            this.label_BigSignOnCentre.TabIndex = 0;
            this.label_BigSignOnCentre.Text = "Заполните следующие поля для добавления заказа в базу данных";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.Location = new System.Drawing.Point(104, 121);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(75, 21);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(436, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(436, 168);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(250, 29);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Quantity.Location = new System.Drawing.Point(436, 270);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(93, 29);
            this.textBox_Quantity.TabIndex = 5;
            this.textBox_Quantity.Text = "1";
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(436, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество";
            // 
            // comboBox_ItemType
            // 
            this.comboBox_ItemType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ItemType.FormattingEnabled = true;
            this.comboBox_ItemType.Location = new System.Drawing.Point(104, 270);
            this.comboBox_ItemType.Name = "comboBox_ItemType";
            this.comboBox_ItemType.Size = new System.Drawing.Size(251, 29);
            this.comboBox_ItemType.TabIndex = 7;
            this.comboBox_ItemType.Text = "Выберите тип товара...";
            this.comboBox_ItemType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип товара";
            // 
            // button_PutOrder
            // 
            this.button_PutOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PutOrder.Location = new System.Drawing.Point(552, 494);
            this.button_PutOrder.Name = "button_PutOrder";
            this.button_PutOrder.Size = new System.Drawing.Size(192, 35);
            this.button_PutOrder.TabIndex = 9;
            this.button_PutOrder.Text = "Разместить заказ";
            this.button_PutOrder.UseVisualStyleBackColor = true;
            this.button_PutOrder.Click += new System.EventHandler(this.button_PutOrder_Click);
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Surname.Location = new System.Drawing.Point(104, 168);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(250, 29);
            this.textBox_Surname.TabIndex = 10;
            this.textBox_Surname.TextChanged += new System.EventHandler(this.textBox_Surname_TextChanged);
            // 
            // button_SaveEntries
            // 
            this.button_SaveEntries.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_SaveEntries.Location = new System.Drawing.Point(552, 555);
            this.button_SaveEntries.Name = "button_SaveEntries";
            this.button_SaveEntries.Size = new System.Drawing.Size(192, 35);
            this.button_SaveEntries.TabIndex = 11;
            this.button_SaveEntries.Text = "Сохранить изменения";
            this.button_SaveEntries.UseVisualStyleBackColor = true;
            this.button_SaveEntries.Click += new System.EventHandler(this.button_SaveEntries_Click);
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Width.Location = new System.Drawing.Point(108, 325);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(72, 21);
            this.label_Width.TabIndex = 12;
            this.label_Width.Text = "Ширина:";
            this.label_Width.Visible = false;
            // 
            // label_Length
            // 
            this.label_Length.AutoSize = true;
            this.label_Length.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Length.Location = new System.Drawing.Point(108, 395);
            this.label_Length.Name = "label_Length";
            this.label_Length.Size = new System.Drawing.Size(58, 21);
            this.label_Length.TabIndex = 13;
            this.label_Length.Text = "Длина:";
            this.label_Length.Visible = false;
            // 
            // textBox_Width
            // 
            this.textBox_Width.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Width.Location = new System.Drawing.Point(104, 356);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(115, 29);
            this.textBox_Width.TabIndex = 14;
            this.textBox_Width.Visible = false;
            // 
            // textBox_Length
            // 
            this.textBox_Length.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Length.Location = new System.Drawing.Point(104, 426);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(115, 29);
            this.textBox_Length.TabIndex = 15;
            this.textBox_Length.Visible = false;
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Height.Location = new System.Drawing.Point(108, 465);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(61, 21);
            this.label_Height.TabIndex = 16;
            this.label_Height.Text = "Высота";
            this.label_Height.Visible = false;
            // 
            // textBox_Height
            // 
            this.textBox_Height.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Height.Location = new System.Drawing.Point(104, 496);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(115, 29);
            this.textBox_Height.TabIndex = 17;
            this.textBox_Height.Visible = false;
            // 
            // label_VolumeOrArea
            // 
            this.label_VolumeOrArea.AutoSize = true;
            this.label_VolumeOrArea.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_VolumeOrArea.Location = new System.Drawing.Point(354, 349);
            this.label_VolumeOrArea.Name = "label_VolumeOrArea";
            this.label_VolumeOrArea.Size = new System.Drawing.Size(0, 21);
            this.label_VolumeOrArea.TabIndex = 18;
            // 
            // button_ShowSize
            // 
            this.button_ShowSize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_ShowSize.Location = new System.Drawing.Point(104, 555);
            this.button_ShowSize.Name = "button_ShowSize";
            this.button_ShowSize.Size = new System.Drawing.Size(192, 35);
            this.button_ShowSize.TabIndex = 19;
            this.button_ShowSize.Text = "Предпросмотр";
            this.button_ShowSize.UseVisualStyleBackColor = true;
            this.button_ShowSize.Click += new System.EventHandler(this.button_ShowSize_Click);
            // 
            // PutOrdersForm__
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.button_ShowSize);
            this.Controls.Add(this.label_VolumeOrArea);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.label_Length);
            this.Controls.Add(this.label_Width);
            this.Controls.Add(this.button_SaveEntries);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.button_PutOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ItemType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_BigSignOnCentre);
            this.Name = "PutOrdersForm__";
            this.Text = "Система управления спортивным магазином. Размещение заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BigSignOnCentre;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_ItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PutOrder;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.Button button_SaveEntries;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Label label_Length;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label label_VolumeOrArea;
        private System.Windows.Forms.Button button_ShowSize;
    }
}