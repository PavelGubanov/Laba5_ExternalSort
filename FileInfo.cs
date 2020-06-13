using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5_ExternalSort
{
    public class FileInfo
    {
        private string _fileName;
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

        private FileStream _fileStream;
        private Func<CandyBox, CandyBox, bool> _comparator;
        public bool EOF { get; set; }
        public bool EOS { get; set; }
        public CandyBox Element { get; private set; }

        public FileInfo(string fileName, Func<CandyBox, CandyBox, bool> comparator)
        {
            FileName = fileName;
            Element = null;
            _comparator = comparator;
        }

        public void GetNextElement()
        {
            EOF = _fileStream.Position == _fileStream.Length;
            if (!EOF)
            {
                Element = CandyBox.GetNextFromStream(_fileStream);
            }
        }

        public void Close()
        {
            _fileStream.Close();
        }

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

        public void BeginWrite()
        {
            _fileStream = File.Create(FileName);
        }
        public void CopyTo(FileInfo fileInfo)
        {
            fileInfo.Element = Element;
            Element.Write(fileInfo._fileStream);
            GetNextElement();
            EOS = EOF || _comparator(Element, fileInfo.Element);
        }
    }
}
