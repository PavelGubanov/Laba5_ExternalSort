using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5_ExternalSort
{
    public partial class FormMain : Form
    {
        const string BASE_NAME = "base.bin";
        private string _fileName = "";

        public FormMain()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dgvCandyBoxes.ColumnCount = 6;
            dgvCandyBoxes.Columns[0].Name = "Название";
            dgvCandyBoxes.Columns[0].Width = 100;
            dgvCandyBoxes.Columns[1].Name = "Вес упаковки";
            dgvCandyBoxes.Columns[1].Width = 120;
            dgvCandyBoxes.Columns[2].Name = "Цена упаковки";
            dgvCandyBoxes.Columns[2].Width = 120;
            dgvCandyBoxes.Columns[3].Name = "Изготовитель";
            dgvCandyBoxes.Columns[3].Width = 150;
            dgvCandyBoxes.Columns[4].Name = "Дата выпуска";
            dgvCandyBoxes.Columns[4].Width = 100;
            dgvCandyBoxes.Columns[5].Name = "Срок хранения";
            dgvCandyBoxes.Columns[5].Width = 110;

            int widthDGV = 0;
            foreach (DataGridViewColumn column in dgvCandyBoxes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                widthDGV += column.Width;
            }

            dgvCandyBoxes.Width = widthDGV + dgvCandyBoxes.ColumnCount - 3;
            if (File.Exists(BASE_NAME))
            {
                RefreshFileInfo(BASE_NAME);
                RefreshDataGrid();
            }
        }
        
        private void RefreshFileInfo(string fileName) 
        {
            _fileName = fileName;
            fileAddress.Text = fileName;
            buttonAddInfo.Enabled = true;
            buttonSort.Enabled = true;
        }

        private void RefreshDataGrid()
        {
            FileStream file = File.OpenRead(_fileName);
            dgvCandyBoxes.Rows.Clear();
            while (file.Length != file.Position)
            {
                CandyBox candyBox = CandyBox.GetNextFromStream(file);
                AddRowToDataGrid(candyBox);
            }
            file.Close();
        }

        private void AddRowToDataGrid(CandyBox candyBox)
        {
            dgvCandyBoxes.Rows.Add(candyBox.Name, candyBox.Weight, candyBox.Cost, candyBox.Producer, candyBox.IssueDate.ToShortDateString(), candyBox.ShelfLife);
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RefreshFileInfo(openFileDialog.FileName);
                RefreshDataGrid();
            }
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgvCandyBoxes.Rows.Clear();
                var file = File.Create(saveFileDialog.FileName);
                file.Close();
                RefreshFileInfo(saveFileDialog.FileName);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var sorter = new ExternalSorter((first, second) =>
            {
                return first.ShelfLife < second.ShelfLife;
            });
            sorter.Sort(_fileName);
            RefreshDataGrid();
        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            var form = new FormAddCandyBox(candyBox =>
            {
                var file = File.Open(_fileName, FileMode.Append, FileAccess.Write);
                candyBox.Write(file);
                file.Close();
                AddRowToDataGrid(candyBox);
            });
            form.ShowDialog();
        }
    }
}
