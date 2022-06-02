using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sports__Shop_App
{    
    public abstract class Items
    {
        uint _id;
        string _itemName;
        int _itemPrice;

        public string Name
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public int Price
        {
            get { return _itemPrice; }
            set { _itemPrice = value < 0 ? -value : value; }
        }

        public uint Id { get => _id; set => _id = value; }


        public Items(string[] itemDescription) // Сразу заполнение всех полей
        {
            Id = UInt32.Parse(itemDescription[0]);
            Name = itemDescription[1];
            Price = Int32.Parse(itemDescription[2]);
        }

        public Items()
        {
            Id = 0;
            Name = "";
            Price = 0;
        }
        protected Items(Items item)
        {
            Name = item.Name;
            Price = item.Price;
            Id = item.Id;
        }

        protected Items(uint id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract double ShowCost();

        public abstract string GenerateOutput();

        public abstract string ShowWidth();
        public abstract string ShowLength();
        public abstract string ShowHeight();
    }

    public class Shoes : Items
    {
        public Shoes(string[] itemDescription) : base(itemDescription) { }

        public Shoes(Items item) : base(item) { }

        public Shoes(uint id, string name, int price) : base(id, name, price)
        {
        }

        public override double ShowCost() => Price;

        public override string GenerateOutput()
        {
            return $"{Id} {Name} {Price}";
        }

        public override string ShowWidth()
        {
            throw new Exception("У объекта класса Shoes не может быть ширины");
        }
        public override string ShowLength()
        {
            throw new Exception("У объекта класса Shoes не может быть длины");
        }
        public override string ShowHeight()
        {
            throw new Exception("У объекта класса Shoes не может быть высоты");
        }
    }

    // Для товаров с заданными размерами Price указывает стоимость за 1 м^2 (или м^3)
    public class ItemsWithSizes : Items
    {
        double _width;
        double _length;

        
        public double Width
        {
            get { return _width; }
            set { _width = value < 0 ? -value : value; }
        }
        public double Length
        {
            get { return _length; }
            set { _length = value < 0 ? -value : value; }
        }

        public ItemsWithSizes(string[] itemDescription) : base(itemDescription)
        {
            Width = Double.Parse(itemDescription[3]);
            Length = Double.Parse(itemDescription[4]);
        }

        public ItemsWithSizes(uint id, string name, int price, double width, double length) : base(id, name, price)
        {
            Width = width;
            Length = length;
        }

        public virtual double Size() => Width * Length;

        public override double ShowCost() => Size() * 1000;

        public override string GenerateOutput()
        {
            throw new NotImplementedException("Этот объект не должен был вызывать этот метод!");
        }

        public override string ShowWidth()
        {
            return $"{Width}";
        }
        public override string ShowLength()
        {
            return $"{Length}";
        }
        public override string ShowHeight()
        {
            throw new Exception("У объекта класса YogaMats не может быть высоты");
        }
    }

    public class YogaMats : ItemsWithSizes
    {
        public YogaMats(string[] itemDescription) : base(itemDescription) { }

        public YogaMats(uint id, string name, int price, double width, double length) : base(id, name, price, width, length)
        {
        }

        public override string GenerateOutput()
        {
            return $"{Id} {Name} {Price} {Width} {Length}";
        }
    }

    public class SportBag : ItemsWithSizes
    {
        private double Height;

        public SportBag(string[] itemDescription) : base(itemDescription)
        {
            Height = Double.Parse(itemDescription[5]);
        }

        public SportBag(uint id, string name, int price, double width, double length, double height) : base(id, name, price, width, length)
        {
            Height = height;
        }

        public override double Size() => Width * Height * Length;

        public override string GenerateOutput()
        {
            return $"{Id} {Name} {Price} {Width} {Length} {Height} ";
        }

        public override string ShowHeight()
        {
            return $"{Height}";
        }
    }
}
