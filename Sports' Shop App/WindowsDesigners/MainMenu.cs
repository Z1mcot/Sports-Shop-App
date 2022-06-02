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
    public partial class MainMenu : Form
    {
        static string[] _delimiters = { "    ", " " };
        static uint _orderCount = 0;

        /*ShoesDatabase _shoesDB = new ShoesDatabase();
        YogaMatsDatabase _yogaMatsDB = new YogaMatsDatabase();*/

        /*public ShoesDatabase ShoesDB { get => _shoesDB; set => _shoesDB = value; }
        public YogaMatsDatabase YogaMatsDB { get => _yogaMatsDB; set => _yogaMatsDB = value; }*/
        
        public static uint OrderCount { get => _orderCount; set => _orderCount = value; }
        public static string[] Delimiters { get => _delimiters; } // мы не можем менять разделители
        
        ItemsDatabase _itemsDB = new ItemsDatabase();
        CustomersDatabase _customersDB = new CustomersDatabase();
        public CustomersDatabase CustomersDB { get => _customersDB; set => _customersDB = value; }
        public ItemsDatabase ItemsDB { get => _itemsDB; set => _itemsDB = value; }

        public MainMenu()
        {
            InitializeComponent();

            InitializeLoadingDB(ItemsDB, CustomersDB);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDB showDB = new ShowDB(this, CustomersDB, ItemsDB, OrderCount);
            showDB.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PutOrdersForm__ newForm = new PutOrdersForm__(this, ItemsDB, CustomersDB, OrderCount); // this передаёт в качестве аргумента ссылку на этоу форму
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public static void InitializeLoadingDB(ItemsDatabase itemsDB, CustomersDatabase customerDB)
        {
            StreamReader inputFile;

            using (inputFile = new StreamReader(@"../../IO/ClientelDatabase.txt"))
            {
                customerDB.LoadDatabase(Delimiters, inputFile);
                OrderCount = customerDB.CustomersDB.Last().OrderId;
            }
            using (inputFile = new StreamReader(@"../../IO/ItemsDatabase.txt"))
            {
                itemsDB.LoadDatabase(Delimiters, inputFile);
            } // Поток автоматически закрывается при достижении конца блока using
        }

        // Переход в окно отчета по складу
        private void button_AddItemToBD_Click(object sender, EventArgs e)
        {
            var showItemDB = new WindowsDesigners.ShowItemDB(this, ItemsDB);
            showItemDB.Show();
        }
    }
}
