using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            dataGridView_game.Rows.Clear();
            dataGridView_game.Columns.Clear();

            for (int i = 1; i <= numericUpDown_collumns.Value; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = 40;
                col.HeaderText = i.ToString();
                dataGridView_game.Columns.Add(col);
            }

            for (int i = 1; i <= numericUpDown_rows.Value; i++)
            {
                dataGridView_game.Rows.Add();
            }

            disableAllBoard();
        }

        private void disableAllBoard() //aka paintItBlack()
        {
            foreach (DataGridViewRow row in dataGridView_game.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataGridView_game[cell.ColumnIndex, cell.RowIndex].Style.BackColor = Color.Black;
                }
        }

        private void enableAvailableSlots()
        {

        }
    }
}
