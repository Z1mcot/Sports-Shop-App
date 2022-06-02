using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Sports__Shop_App.WindowsDesigners
{
    public partial class ShowItemDB : Form
    {
        ItemsDatabase ItemsDB;
        int row_num = 0;
        int[] sortingOrders = new int[]{ 1, 1, 1 };

        public ShowItemDB()
        {
            InitializeComponent();
        }

        public ShowItemDB(MainMenu BackToMenu, ItemsDatabase Items_DB)
        {
            InitializeComponent();
            this.ItemsDB = Items_DB;
            FillTheTable();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillColumns()
        {
            listView_ItemDB.Columns.Add(Number);
            listView_ItemDB.Columns.Add(CustomerName);
            listView_ItemDB.Columns.Add(Price);
            listView_ItemDB.Columns.Add(itemWidth);
            listView_ItemDB.Columns.Add(itemLength);
            listView_ItemDB.Columns.Add(itemHeight);
        }

        private void FillTheTable()
        {
            listView_ItemDB.Clear();
            row_num = 0; // метод Clear и переменная row_num всегда будут вместе,
                         // иначе есть возможность, что мы при заполнении таблицы будем добавлять SubItem к несуществующему Item.
                         // А так, у нас всегда будет заполнение с первой строчки таблицы
            FillColumns();

            foreach (Items item in ItemsDB.ItemsDB) // Ключевое слово var указывает, что компилятор должен вывести тип переменной из выражения справа
            {
                AddItemsToTable(item, ref row_num);
            }
        }
         
        private void AddItemsToTable(Items item, ref int row)
        {
            listView_ItemDB.Items.Add(item.Id.ToString());
            listView_ItemDB.Items[row].SubItems.Add(item.Name);
            listView_ItemDB.Items[row].SubItems.Add(item.ShowCost().ToString());
            listView_ItemDB.Items[row].SubItems.Add(item.ShowWidth());
            listView_ItemDB.Items[row].SubItems.Add(item.ShowLength());
            listView_ItemDB.Items[row].SubItems.Add(item.ShowHeight());

            row++;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            IComparer comparerType = null;
            switch (e.Column)
            {
                case 0:
                    
                    comparerType = new ItemIdComparer();
                    sortingOrders[0] *= -1;
                    break;
                case 1:
                    comparerType = new ItemNameComparer();
                    sortingOrders[1] *= -1;
                    break;
                case 2:
                    comparerType = new ItemPriceComparer();
                    sortingOrders[2] *= -1;
                    break;
                default:
                    break;
            }
            if (comparerType != null)
            {
                ItemsDB.ItemsDB.Sort(comparerType);
                FillTheTable();
            }
        }
    }
}
