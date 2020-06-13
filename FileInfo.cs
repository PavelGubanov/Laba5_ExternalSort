using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5_ExternalSort
{
    //Класс для сортировочного файла
    public class FileInfo
    {
        private string _fileName; //имя файла
        public string FileName
        {
            get => _fileName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Имя файла не может быть пустым.");
                }
                _fileName = value;
            }
        }

        private FileStream _fileStream; // поток для файла с заданным именем
        private Func<CandyBox, CandyBox, bool> _comparator; // компаратор для сравнения элементов

        public bool EOF { get; set; } //флажок конца файла
        public bool EOS { get; set; } //флажок конца серии

        public CandyBox Element { get; private set; } //последний считанный элемент из файла

        public FileInfo(string fileName, Func<CandyBox, CandyBox, bool> comparator)
        {
            FileName = fileName;
            Element = null;
            _comparator = comparator;
        }
        //Считывает следующий элемент из файла
        public void GetNextElement()
        {
            EOF = _fileStream.Position == _fileStream.Length;
            if (!EOF)
            {
                Element = CandyBox.GetNextFromStream(_fileStream);
            }
        }
        //Закрывает файловый поток
        public void Close()
        {
            _fileStream.Close();
        }
        //Подготовка файла к чтению элементов
        public void BeginRead()
        {
            if (File.Exists(FileName))
            {
                _fileStream = File.OpenRead(FileName);
            }
            else
            {
                _fileStream = File.Create(FileName);
            }
            GetNextElement();
            EOS = EOF;
        }
        //Подготовка файла к записи элементов
        public void BeginWrite()
        {
            _fileStream = File.Create(FileName);
        }
        //Копирует последний элемент из этого файла в заданный
        public void CopyTo(FileInfo fileInfo)
        {
            fileInfo.Element = Element;
            Element.Write(fileInfo._fileStream);
            GetNextElement();
            EOS = EOF || _comparator(Element, fileInfo.Element);
        }
    }
}
