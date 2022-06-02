using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sports__Shop_App
{
    public interface IDatabases
    {
        void LoadDatabase(string[] delimiters, StreamReader inputFile);
        void SaveDatabase();
    }

    public class ItemsDatabase : IDatabases
    {
        ArrayList _itemsDB = new ArrayList();

        public ArrayList ItemsDB { get => _itemsDB; set => _itemsDB = value; }
        
        public Items DecideItemType(string[] itemDescriptionEntry)
        {
            uint itemId;
            if (!UInt32.TryParse(itemDescriptionEntry[0].Substring(0, 3), out itemId))
            {
                throw new ArgumentException();
            }
            // ID начинающиеся до 300 – кроссовки
            if (itemId < 300)
                return new Shoes(itemDescriptionEntry);
            // ID до 600 – коврики для йоги
            if (itemId < 600)
                return new YogaMats(itemDescriptionEntry);
            // Всё остальное – сумки
            return new SportBag(itemDescriptionEntry);
        }

        public void LoadDatabase(string[] delimiters, StreamReader inputFile)
        {
            string _anotherLine = inputFile.ReadLine();
            uint count = 0;

            while (!string.IsNullOrWhiteSpace(_anotherLine))
            {
                string[] inputLine = _anotherLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                var anotherItem = DecideItemType(inputLine);
                ItemsDB.Add(anotherItem);
                _anotherLine = inputFile.ReadLine();
                count++;
            }
        }

        public void SaveDatabase()
        {
            using (StreamWriter outputFile = new StreamWriter(@"../../IO/ItemsDatabase.txt"))
            {
                foreach (Items item in ItemsDB)
                {
                    outputFile.WriteLine(item.GenerateOutput());
                }
            }
        }

    }

    public class ItemPriceComparer : IComparer
    {
        public int Compare(object itemA, object itemB)
        {
            Items a, b;
            a = (Items) itemA;
            b = (Items) itemB;
            return a.Price - b.Price;
        }
    }

    public class ItemIdComparer : IComparer
    {
        public int Compare(object itemA, object itemB)
        {
            Items a, b;
            a = (Items)itemA;
            b = (Items)itemB;
            return (int)a.Id - (int)b.Id;
        }
    }

    public class ItemNameComparer : IComparer
    {
        public int Compare(object itemA, object itemB)
        {
            Items a, b;
            a = (Items) itemA;
            b = (Items) itemB;
            return a.Name.CompareTo(b.Name);
        }
    }

    /*public class ShoesDatabase : IDatabases
    {
        List<Shoes> _shoesDB = new List<Shoes> ();

        public List<Shoes> ShoesDB { get => _shoesDB; set => _shoesDB = value; }

        public void LoadDatabase(string[] delimiters, StreamReader inputFile)
        {
            string _anotherLine = inputFile.ReadLine();
            uint count = 0;

            while (!string.IsNullOrWhiteSpace(_anotherLine))
            {
                string[] input_line = _anotherLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                // ShoesDB.Add();
                _anotherLine = inputFile.ReadLine();
                count++;
            }
        }

        public void SaveDatabase()
        {
            using (StreamWriter outputFile = new StreamWriter(@"../../IO/ShoesDatabase.txt"))
            {
                foreach (var shoes in _shoesDB)
                {
                    outputFile.WriteLine(shoes.GenerateOutput());
                }
            }
        }
    }*/

    public class CustomersDatabase : IDatabases
    {
        List<Customers> _customersDB = new List<Customers> ();

        public List<Customers> CustomersDB { get => _customersDB; set => _customersDB = value; }

        public void LoadDatabase(string[] delimiters, StreamReader inputFile)
        {
            string _anotherLine = inputFile.ReadLine();
            uint count = 0;

            while (!string.IsNullOrWhiteSpace(_anotherLine))
            {
                string[] input_line = _anotherLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                CustomersDB.Add(new Customers(count, input_line[1], input_line[2], Convert.ToUInt32(input_line[3]), 
                    Convert.ToInt32(input_line[4]), input_line[5]));
                _anotherLine = inputFile.ReadLine();
                count++;
            }
        }

        public void SaveDatabase()
        {
            using (StreamWriter outputFile = new StreamWriter(@"../../IO/ClientelDatabase.txt"))
            {
                foreach (var client in _customersDB)
                {
                    outputFile.WriteLine(client.GenerateOutput());
                }
            }
        }
    }

    public class CustomersIDComparer : IComparer<Customers>
    {
        public int Compare(Customers customerA, Customers customerB)
        {
            return customerA.OrderId.CompareTo(customerB.OrderId);
        }
    }
    public class CustomersSurnameComparer : IComparer<Customers>
    {
        public int Compare(Customers customerA, Customers customerB)
        {
            return customerA.Surname.CompareTo(customerB.Surname);
        }
    }
    public class CustomersNameComparer : IComparer<Customers>
    {
        public int Compare(Customers customerA, Customers customerB)
        {
            return customerA.Name.CompareTo(customerB.Name);
        }
    }
    public class CustomersBoughtItemsQuantityComparer : IComparer<Customers>
    {
        public int Compare(Customers customerA, Customers customerB)
        {
            return customerA.ItemsQuantity.CompareTo(customerB.ItemsQuantity);
        }
    }
    public class CustomersSpendingsComparer : IComparer<Customers>
    {
        public int Compare(Customers customerA, Customers customerB)
        {
            return customerA.CostOfItems - customerB.CostOfItems;
        }
    }
    public class CustomersItemIDComparer : IComparer<Customers>
    {
        public int Compare(Customers customerA, Customers customerB)
        {
            return customerA.ItemId.CompareTo(customerB.ItemId);
        }
    }


    /*public class YogaMatsDatabase : IDatabases
    {
        List<YogaMats> _yogaMatsDB = new List<YogaMats> ();

        public List<YogaMats> YogaMatsDB { get => _yogaMatsDB; set => _yogaMatsDB = value; }

        public void LoadDatabase(string[] delimiters, StreamReader inputFile)
        {
            string another_line = inputFile.ReadLine();
            uint count = 0;

            while (!string.IsNullOrWhiteSpace(another_line))
            {
                string[] input_line = another_line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                YogaMatsDB.Add(new YogaMats(count, input_line[0], Convert.ToInt32(input_line[1]),
                    Convert.ToDouble(input_line[3]), Convert.ToDouble(input_line[4])));
                another_line = inputFile.ReadLine();
                count++;
            }
            inputFile.Close();
        }

        public void SaveDatabase()
        {
            using (StreamWriter outputFile = new StreamWriter(@"../../IO/YogaMatsDatabase.txt"))
            {
                foreach (var yogaMat in _yogaMatsDB)
                {
                    outputFile.WriteLine(yogaMat.GenerateOutput());
                }
            }
        }
    }*/
}
