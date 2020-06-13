using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5_ExternalSort
{
    public partial class FormAddCandyBox : Form
    {
        private Action<CandyBox> OnAddCandyBox;
        public FormAddCandyBox(Action<CandyBox> onAddCandyBox)
        {
            InitializeComponent();
            OnAddCandyBox = onAddCandyBox;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double weight = 0, cost = 0;
            var checkFields = textBoxNameCandyBox.Text != ""
                              && textBoxProducerCandyBox.Text != ""
                              && double.TryParse(textBoxCostCandyBox.Text, out cost)
                              && double.TryParse(textBoxWeight.Text, out weight);
            if (checkFields)
            {
                var candyBox = new CandyBox(textBoxNameCandyBox.Text, weight, cost, textBoxProducerCandyBox.Text, pickerIssueDate.Value, (int)numericShelfTimeCandyBox.Value);
                OnAddCandyBox(candyBox);
                Close();
            }
            else
            {
                MessageBox.Show(this, "Проверьте корректность входных значений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
