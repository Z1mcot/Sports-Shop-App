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
        int selectedColumn;
        List<IComparer> comparersList = new List<IComparer> { new ItemIdComparer(), new ItemNameComparer(), new ItemPriceComparer() };

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
            IComparer comparerType = comparersList[e.Column];

            if (e.Column != selectedColumn)
            {
                ItemsDB.ItemsDB.Sort(comparerType);
                selectedColumn = e.Column;
            }
            else // в этом случае список уже должен быть отсортирован, поэтому остаётся только обратить порядок
            {
                ItemsDB.ItemsDB.Reverse();
            }
            
            FillTheTable();   
        }
    }
}
