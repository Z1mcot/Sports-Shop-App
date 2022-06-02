using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sports__Shop_App
{
    public class Customers
    {
        private uint _orderId;

        private string _surname;
        private string _name;
        private uint _itemsQuantity;
        private int _costOfItems;
        private string _itemId;
        private Items _orderedItem;

        public uint OrderId { get => _orderId; set => _orderId = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Name { get => _name; set => _name = value; }
        public uint ItemsQuantity { get => _itemsQuantity; set => _itemsQuantity = value; }
        public int CostOfItems { get => _costOfItems; set => _costOfItems = value; }
        public string ItemId { get => _itemId; set => _itemId = value; }
        public Items OrderedItem { get => _orderedItem; set => _orderedItem = value; }

        public Customers(uint customerId, string surname, string name, uint quantity, int cost, string itemId) 
        {
            OrderId = customerId;
            Surname = surname;
            Name = name;
            ItemsQuantity = quantity;
            CostOfItems = cost;
            ItemId = itemId;
        }
        public Customers(uint customerId, string surname, string name, uint quantity, int cost, string items, Items mat)
        {
            OrderId = customerId;
            Surname = surname;
            Name = name;
            ItemsQuantity = quantity;
            CostOfItems = cost;
            ItemId = items;
            OrderedItem = mat;
        }
        /*public Customers(uint customerId, string surname, string name, uint quantity, int cost, string items, SportBag bag)
        {
            OrderId = customerId;
            Surname = surname;
            Name = name;
            ItemsQuantity = quantity;
            CostOfItems = cost;
            ItemId = items;
            OrderedItem = bag;
        }*/



        public string GenerateOutput()
        {
            return $"{OrderId} {Surname} {Name} " +
                    $"{ItemsQuantity} {CostOfItems} {ItemId}";
        }
    }
}
