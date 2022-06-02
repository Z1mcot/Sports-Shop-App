using System;
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
    public partial class ShowDB : Form
    {
        CustomersDatabase CustomersDB;
        ItemsDatabase ItemsDB;
        uint customers_count;
        int row_num = 0;
        int selectedColumn;
        List<IComparer<Customers>> comparersList = new List<IComparer<Customers>> { new CustomersIDComparer(), 
            new CustomersSurnameComparer(), 
            new CustomersNameComparer(),
            new CustomersBoughtItemsQuantityComparer(),
            new CustomersSpendingsComparer(), 
            new CustomersItemIDComparer()
        };

        public ShowDB()
        {
            InitializeComponent();
        }
        public ShowDB(MainMenu BackToMenu, CustomersDatabase Customers_DB, ItemsDatabase Items_DB, uint count)
        {
            InitializeComponent();
            this.CustomersDB = Customers_DB;
            this.ItemsDB = Items_DB;
            customers_count = count;
            FillTheTable();
        }

        private void ShowDB_Load(object sender, EventArgs e)
        {

        }

        private void button_AddEntry_Click(object sender, EventArgs e)
        {
            PutOrdersForm__ newForm = new PutOrdersForm__(this, ItemsDB, CustomersDB, customers_count);
            newForm.Show();
        }

        private void FillColumns()
        {
            listView1.Columns.Add(Number);
            listView1.Columns.Add(CustomerName);
            listView1.Columns.Add(ItemName);
            listView1.Columns.Add(Quantity);
            listView1.Columns.Add(OrderedCost);
        }
        private void FillTheTable()
        {
            listView1.Clear();
            row_num = 0; // метод Clear и переменная row_num всегда будут вместе,
                         // иначе есть возможность, что мы при заполнении таблицы будем добавлять SubItem к несуществующему Item.
                         // А так, у нас всегда будет заполнение с первой строчки таблицы
            FillColumns();

            foreach (var customer in CustomersDB.CustomersDB) // Ключевое слово var указывает, что компилятор должен вывести тип переменной из выражения справа
            {
                AddItemsToTable(customer, ref row_num);
            }
        }

        private void FillTheTable(uint MinPrice, uint MaxPrice, bool check, params string[] BrandFilter) // С учетом фильтров
        {
            listView1.Clear();
            row_num = 0;
            FillColumns();

            foreach (var customer in CustomersDB.CustomersDB)
            {
                foreach (string filter in BrandFilter) 
                {
                    if ((customer.ItemId == filter || !check) && 
                        customer.CostOfItems >= MinPrice && customer.CostOfItems <= MaxPrice)
                    {
                        AddItemsToTable(customer, ref row_num);
                        break;
                    }
                }
            }
        }

        // Поиск заказа по его номеру
        private void button_FindEntry_Click(object sender, EventArgs e)
        {
            uint num_filter;
            if (UInt32.TryParse(textBox_NumFilter.Text, out num_filter))
            {
                listView1.Clear();
                row_num = 0;
                FillColumns();
                AddItemsToTable(CustomersDB.CustomersDB.Find(id => id.OrderId == num_filter), ref row_num);                
            }
            else
            {
                DialogResult error = MessageBox.Show(text: $"Недопустимый формат данных.", caption: "Ошибка!", buttons: MessageBoxButtons.OK);
            }
        }

        private void AddItemsToTable(Customers customer, ref int row)
        {
            listView1.Items.Add(customer.OrderId.ToString());
            listView1.Items[row].SubItems.Add(customer.Surname + " " + customer.Name);
            listView1.Items[row].SubItems.Add(customer.ItemId);
            listView1.Items[row].SubItems.Add(customer.ItemsQuantity.ToString());
            listView1.Items[row].SubItems.Add(customer.CostOfItems.ToString());
            row++;
        }

        private void textBox_NumFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_DeleteEntry_Click(object sender, EventArgs e)
        {
            uint DeleteFilter;
            if (UInt32.TryParse(textBox_DeleteEntry.Text, out DeleteFilter))
            {
                var order = CustomersDB.CustomersDB.Find(customer => customer.OrderId == DeleteFilter);
                CustomersDB.CustomersDB.Remove(order);

                FillTheTable();
            }
            else
            {
                DialogResult error = MessageBox.Show(text: $"Недопустимый формат данных.", caption: "Ошибка!", buttons: MessageBoxButtons.OK);
            }
        }

        private void button_FilterEntries_Click(object sender, EventArgs e)
        {
            uint lower_price = Convert.ToUInt32(textBox_LowerPriceFilter.Text);
            uint higher_price = Convert.ToUInt32(textBox_HigherPriceFilter.Text);
            string[] brand_selection = new string[3];
            bool check_selected = false; // в методе есть условие !check, если ни один бренд не выбран, то выводятся все бренды

            for (int i = 0; i < checkedListBox_ProductTypeFilter.CheckedItems.Count; i++)
            {
                check_selected = true;
                brand_selection[i] = checkedListBox_ProductTypeFilter.CheckedItems[i].ToString();
            }

            FillTheTable(lower_price, higher_price, check_selected, brand_selection);
        }

        private void button_SaveEdit_Click(object sender, EventArgs e)
        {
            CustomersDB.SaveDatabase();
        }

        // Сортировка при нажатии по столбцу
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            IComparer<Customers> comparerType = comparersList[e.Column];

            if (e.Column != selectedColumn)
            {
                CustomersDB.CustomersDB.Sort(comparerType);
                selectedColumn = e.Column;
            }
            else // в этом случае список уже должен быть отсортирован, поэтому остаётся только обратить порядок
            {
                CustomersDB.CustomersDB.Reverse();
            }

            FillTheTable();
        }
    }
}
