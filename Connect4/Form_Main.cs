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
        private Color currPlayerColor = Color.Red;
        private int defaultCollumnWidth = 40;
        private LineCheck lineChecker;

        public Form_Main()
        {
            InitializeComponent();
            startGame();
            updatePlayerColor();
            lineChecker = new LineCheck(dataGridView_game, 4);
        }

        private void updatePlayerColor()
        {
            panel_currentPlayer.BackColor = currPlayerColor;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            startGame();
            updatePlayerColor();
        }

        private void startGame()
        {
            dataGridView_game.Rows.Clear();
            dataGridView_game.Columns.Clear();

            for (int i = 1; i <= numericUpDown_collumns.Value; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = defaultCollumnWidth;
                col.HeaderText = i.ToString();
                dataGridView_game.Columns.Add(col);
            }

            for (int i = 1; i <= numericUpDown_rows.Value; i++)
            {
                dataGridView_game.Rows.Add();
            }

            disableAllBoard();
            enableAvailableSlots();
        }

        private void disableAllBoard() //aka paintItBlack()
        {
            foreach (DataGridViewRow row in dataGridView_game.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataGridView_game[cell.ColumnIndex, cell.RowIndex].Style.BackColor = Color.Black;
                    dataGridView_game[cell.ColumnIndex, cell.RowIndex].ReadOnly = true;
                }
        }

        private void enableAvailableSlots()
        {
            for (int col = 0; col < dataGridView_game.ColumnCount; col++)
            {
                for (int row = dataGridView_game.RowCount-1; row >= 0; row--)
                {
                    DataGridViewCellStyle currStyle = dataGridView_game[col, row].Style;

                    if (currStyle.BackColor == Color.Black)
                    {
                        currStyle.BackColor = Color.White;
                        break;
                    }
                }
            }
        }

        private void dataGridView_game_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_game.ClearSelection();
        }

        private void dataGridView_game_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return; //Header

            DataGridViewCell cell = dataGridView_game[e.ColumnIndex, e.RowIndex];
            if (cell.Style.BackColor == Color.White)
            {
                cell.Style.BackColor = currPlayerColor;
                
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            if (lineChecker.checkForWinner(cell.RowIndex, cell.ColumnIndex, currPlayerColor))
            {
                MessageBox.Show("A winner is made");
            }
        }
    }
}
