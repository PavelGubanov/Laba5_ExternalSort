using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5_ExternalSort
{
    //Класс внешней сортировки 
    //с помощью многопутевого однофазного естественного несбалансированного слияния
    public class ExternalSorter
    {
        public const int DefaultCountWays = 3; //количество путей для сортировки по умолчанию
        public const string PrefixForSortFiles = "sort_file_"; //префикс для создания имён сортировочных файлов

        //Количество путей
        private int _countWays;
        public int CountWays
        {
            get => _countWays;
            set
            {
                if (value < 3)
                {
                    throw new ArgumentException("Количество путей в многофазной сортировке должно быть больше и равно 3");
                }
                _countWays = value;
            }
        }
        //Двумерный массив для хранения сортировочных файлов
        private FileInfo[][] _files;
        //Компаратор для упорядочивания записей 
        public Func<CandyBox, CandyBox, bool> Comparator { get; private set; }

        public ExternalSorter(Func<CandyBox, CandyBox, bool> comparator, int countWays = DefaultCountWays)
        {
            CountWays = countWays;
            Comparator = comparator;
        }
        //Возвращает индекс следующего файла с минимальным элементом
        private int GetIndexOfNextFile(FileInfo[] files)
        {
            int minIndex = -1;
            int index = 0;
            while (index < files.Length && files[index].EOS)
            {
                index++;
            }
            if (index < files.Length)
            {
                CandyBox minElement = files[index].Element;
                minIndex = index;
                index++;
                while (index < files.Length)
                {
                    if (!files[index].EOS && Comparator(files[index].Element, minElement))
                    {
                        minIndex = index;
                        minElement = files[index].Element;
                    }
                    index++;
                }
            }
            return minIndex;
        }
        //Проверяет сортировочные файлы на конец файла
        private bool CheckFilesOnEnd(FileInfo[] files)
        {
            bool check = true;
            for (int i = 0; i < files.Length && check; i++)
                check = files[i].EOF;
            return check;
        }
        //Единственная фаза сортировки
        private int PhaseSortingElements(int indexOfPhase)
        {
            int indexRowForRead = indexOfPhase % 2;
            int indexRowForWrite = (indexOfPhase + 1) % 2;
            for (int i = 0; i < CountWays; i++)
            {
                _files[indexRowForRead][i].BeginRead(); //одну группу файлов готовим к чтению элементов
                _files[indexRowForWrite][i].BeginWrite(); //другую группу файлов готовим к записи элементов
            }

            int countSeries = 0;
            do
            {
                int index = GetIndexOfNextFile(_files[indexRowForRead]);
                while (index != -1)
                {
                    //Копируем элементы из файлов с минимальными элементами в текущий для данной серии файл для записи
                    _files[indexRowForRead][index].CopyTo(_files[indexRowForWrite][countSeries % CountWays]);
                    index = GetIndexOfNextFile(_files[indexRowForRead]);
                }

                countSeries++;
                foreach (FileInfo fileInfo in _files[indexRowForRead])
                    fileInfo.EOS = fileInfo.EOF;

            } while (!CheckFilesOnEnd(_files[indexRowForRead]));

            //Закрываем все сортировочные файлы
            for (int i = 0; i < CountWays; i++)
            {
                _files[indexRowForRead][i].Close();
                _files[indexRowForWrite][i].Close();
            }

            return countSeries;
        }
        //Основной метод сортировки
        public void Sort(string fileName)
        {
            //Исходный файл становится первым сортировочным файлом
            File.Move(fileName, PrefixForSortFiles + "00");
            _files = new FileInfo[2][];
            for (int i = 0; i < 2; i++)
            {
                _files[i] = new FileInfo[CountWays];
                for (int j = 0; j < CountWays; j++)
                {
                    _files[i][j] = new FileInfo(PrefixForSortFiles + i + j, Comparator);
                }
            }

            int indexOfPhase = 0;
            //Выполняем фазу сортировки, пока количество серий не станет равным единице
            while(PhaseSortingElements(indexOfPhase) != 1)
            {
                indexOfPhase++;
            }
            //Возвращаем исходному файлу прежнее имя
            File.Move(PrefixForSortFiles + (indexOfPhase + 1) % 2 + 0, fileName);
            //Удаляем все сортировочные файлы
            for (int i = 0; i < CountWays; i++)
            {
                if (File.Exists(_files[0][i].FileName))
                {
                    File.Delete(_files[0][i].FileName);
                }
                if (File.Exists(_files[1][i].FileName))
                {
                    File.Delete(_files[1][i].FileName);
                }
            }
        }
    }
}
