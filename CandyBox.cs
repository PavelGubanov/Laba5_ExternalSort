using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba5_ExternalSort
{
    [Serializable]
    public class CandyBox
    {
        string _name; 
        double _weight;
        double _cost;
        string _producer;
        DateTime _issueDate;
        int _shelfLife;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Название конфет не может быть пустым.");
                }
                _name = value;
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Вес не может быть отрицательным или нулевым.");
                }
                _weight = value;
            }
        }
        public double Cost 
        { 
            get => _cost; 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Цена не может быть отрицательной или нулевой.");
                }
                _cost = value;
            }                  
        }
        public string Producer 
        { 
            get => _producer;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Название изготовителя не может быть пустым.");
                }
                _producer = value;
            }
        }
        public DateTime IssueDate 
        { 
            get => _issueDate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата изготовления не может быть позже сегодня.");
                }
                _issueDate = value;
            }
        }
        public int ShelfLife 
        {
            get => _shelfLife;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Срок годности не может быть отрицательным или нулевым.");
                }
                _shelfLife = value;
            }
        }

        public CandyBox(string name, double weight, double cost,
                        string producer, DateTime issueDate, int shelfLife)
        {
            _name = name;
            _weight = weight;
            _cost = cost;
            _producer = producer;
            _issueDate = issueDate;
            _shelfLife = shelfLife;
        }

        public void Write(FileStream fileStream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, this);
        }

        public static CandyBox GetNextFromStream(FileStream fileStream)
        {
            if (fileStream.Position == fileStream.Length)
                return null;
            BinaryFormatter formatter = new BinaryFormatter();
            return (CandyBox)formatter.Deserialize(fileStream);
        }
    }
}
