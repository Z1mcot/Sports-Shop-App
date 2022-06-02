using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sports__Shop_App
{
    delegate void PutOrderDelegate();

    public partial class PutOrdersForm__ : Form
    {
        uint ChosenItemId;
        uint ChosenQuantity = 1;
        string ChosenItemType = "";

        private Items _anotherItem;
        private PutOrderDelegate orderType = null;

        CustomersDatabase CustomersDB;
        ItemsDatabase ItemsDB;

        uint CustomersCount;
        private string _recieptText; // Текст, выводящийся при оформлении заказа
        public PutOrdersForm__()
        {
            InitializeComponent();
        }
        
        public PutOrdersForm__(MainMenu BackToMenu, ItemsDatabase shoes, CustomersDatabase customers, uint count)
        {
            InitializeComponent();
            ItemsDB = shoes;
            CustomersDB = customers;
            CustomersCount = count + 1;
            FillTextBox();
        }

        public PutOrdersForm__(ShowDB ShowDB, ItemsDatabase shoes, CustomersDatabase customers, uint count)
        {
            InitializeComponent();
            ItemsDB = shoes;
            CustomersDB = customers;
            CustomersCount = count + 1;
            FillTextBox();
        }

        private void textBox_Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            ChosenQuantity = Convert.ToUInt32(textBox_Quantity.Text);
        }

        private void comboBox_ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenItemId = (uint) comboBox_ItemType.SelectedIndex;
            ChosenItemType = comboBox_ItemType.SelectedItem.ToString();

            switch (ChosenItemType) {
                case "Коврик для йоги":
                    ChosenItemId += 300;
                    ShowElements(true, false);
                    break;
                case "Спортивная сумка":
                    ChosenItemId += 600;
                    ShowElements(true, true);
                    break;
                default:
                    ChosenItemId += 100;
                    ShowElements(false, false);
                    label_VolumeOrArea.Text = "";
                    ChosenItemType = "Прочее";
                    break;
            }
        }

        public Items FindElement()
        {
            foreach (Items item in ItemsDB.ItemsDB)
            {
                if (item.Id == ChosenItemId)
                {
                    return item;
                }
            }

            throw new Exception();
        }

        private void button_PutOrder_Click(object sender, EventArgs e)
        {
            Items _item;
            GenerateReciept(out _item);
            
            DialogResult result = MessageBox.Show(text: _recieptText, caption: "Подтверждение заказа", buttons: MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                switch (ChosenItemType)
                {
                    case "Коврик для йоги":
                        orderType = PutYogaMatOrder; // На всякий случай, если кнопка Предпросмотра не была нажата, иначе мы будем обращаться к несуществующему классу
                        ItemsDB.ItemsDB.Add(_anotherItem);
                        break;
                    case "Спортивная сумка":
                        orderType = PutSportBagOrder;
                        ItemsDB.ItemsDB.Add(_anotherItem);
                        break;
                    default:
                        _anotherItem = FindElement();
                        break;
                }
                orderType?.Invoke(); // вместо if (orderType != null) orderType();
                
                CustomersDB.CustomersDB.Add(new Customers(CustomersCount, textBox_Name.Text, textBox_Surname.Text, ChosenQuantity,
                    Convert.ToInt32(_anotherItem.ShowCost() * ChosenQuantity), _anotherItem.Name, _anotherItem));
                CustomersCount++;
                _anotherItem.Price = (int)_anotherItem.ShowCost();
            }
        }
        private void button_SaveEntries_Click(object sender, EventArgs e)
        {
            CustomersDB.SaveDatabase();
            ItemsDB.SaveDatabase();
        }

        private void FillTextBox()
        {
            foreach (Items item in ItemsDB.ItemsDB)
            {
                if (item.Id < 300) comboBox_ItemType.Items.Add($"Кроссовки \"{item.Name}\"");
            }
            comboBox_ItemType.Items.Add("Коврик для йоги");
            comboBox_ItemType.Items.Add("Спортивная сумка");
        }

        private void PutYogaMatOrder()
        {
            if (!string.IsNullOrWhiteSpace(textBox_Length.Text) && !string.IsNullOrWhiteSpace(textBox_Width.Text))
            {
                _anotherItem = new YogaMats(ChosenItemId, "Коврик", 1000, 
                    Convert.ToDouble(textBox_Width.Text), Convert.ToDouble(textBox_Length.Text));
                label_VolumeOrArea.Text = $"Площадь коврика: {((ItemsWithSizes)_anotherItem).Size()}";
            }
            else
            {
                DialogResult error = MessageBox.Show(text: $"Недопустимый формат данных.", caption: "Ошибка!", buttons: MessageBoxButtons.OK);
            }
        }

        private void PutSportBagOrder()
        {
            if (!string.IsNullOrWhiteSpace(textBox_Length.Text) && !string.IsNullOrWhiteSpace(textBox_Width.Text) && !string.IsNullOrWhiteSpace(textBox_Height.Text))
            {
                _anotherItem = new SportBag(ChosenItemId, "Спортивная сумка", 5999, 
                    Convert.ToDouble(textBox_Width.Text), Convert.ToDouble(textBox_Length.Text), Convert.ToDouble(textBox_Height.Text));
                label_VolumeOrArea.Text = $"Объем сумки: {((ItemsWithSizes)_anotherItem).Size()}";
            }
            else
            {
                DialogResult error = MessageBox.Show(text: $"Недопустимый формат данных.", caption: "Ошибка!", buttons: MessageBoxButtons.OK);
            }
        }

        private void ShowElements(bool IsToBeShown, bool IsBag) // Включает и выключает доступность полей с вводом размеров
        {
            label_Width.Visible = IsToBeShown;
            label_Length.Visible = IsToBeShown;
            textBox_Width.Enabled = IsToBeShown;
            textBox_Width.Visible = IsToBeShown;
            textBox_Length.Enabled = IsToBeShown;
            textBox_Length.Visible = IsToBeShown;
            button_ShowSize.Visible = IsToBeShown;
            button_ShowSize.Enabled = IsToBeShown;
            
            textBox_Height.Enabled = IsBag;
            textBox_Height.Visible = IsBag;
            label_Height.Visible = IsBag;
        }

        private void button_ShowSize_Click(object sender, EventArgs e)
        {
            switch (ChosenItemType)
            {
                case "Коврик для йоги":
                    PutYogaMatOrder();
                    break;
                case "Спортивная сумка":
                    PutSportBagOrder();
                    break;
                default:
                    break;
            }
        }

        private void GenerateReciept(out Items item)
        {
            item = null;
            
            switch (ChosenItemType)
            {
                case "Коврик для йоги":
                    PutYogaMatOrder();
                    _recieptText = $"Заказ №{CustomersCount + 1}\n" +
                        $"Товар: Коврик для йоги {Convert.ToDouble(textBox_Width.Text)}x{Convert.ToDouble(textBox_Length.Text)}\n" +
                        $"Итого: {_anotherItem.ShowCost() * ChosenQuantity}";
                    break;
                case "Спортивная сумка":
                    PutSportBagOrder();
                    _recieptText = $"Заказ №{CustomersCount + 1}\n" +
                        $"Товар: Спортивная сумка {Convert.ToDouble(textBox_Width.Text)}x{Convert.ToDouble(textBox_Length.Text)}x{Convert.ToDouble(textBox_Height.Text)}\n" +
                        $"Итого: {_anotherItem.Price * ChosenQuantity}";
                    break;
                default:
                    item = FindElement();
                    _recieptText = $"Заказ №{CustomersCount + 1}\n" +
                        $"Товар: {comboBox_ItemType.SelectedItem}\n" +
                        $"Итого: {item.Price * ChosenQuantity}";
                    break;
            }
        }
    }
}
