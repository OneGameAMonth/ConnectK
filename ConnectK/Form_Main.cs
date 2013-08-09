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
        private int currPlayerIndex;
        private int defaultCollumnWidth = 40;
        private LineCheck lineChecker;
        private Color[] playerColors = new Color[]{
            Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Fuchsia, Color.Pink, Color.Orange, Color.Aquamarine
        };
        private int currentTotalPlayers;
        private bool isGameOver;

        public Form_Main()
        {
            InitializeComponent();
            lineChecker = new LineCheck(dataGridView_game, (int)numericUpDown_connectk.Value);
            startGame();
        }

        private void updatePlayerColor()
        {
            currPlayerColor = playerColors[currPlayerIndex++];
            currPlayerIndex %= currentTotalPlayers;
            panel_currentPlayer.BackColor = currPlayerColor;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            isGameOver = false;
            currentTotalPlayers = (int)numericUpDown_players.Value;
            currPlayerIndex = 0;
            updatePlayerColor();

            dataGridView_game.Rows.Clear();
            dataGridView_game.Columns.Clear();
            lineChecker.lineSize = (int)numericUpDown_connectk.Value;

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
            if (isGameOver)
            {
                MessageBox.Show("Game Over. The winner is " + currPlayerColor.Name);
                return;
            }

            if (e.RowIndex == -1 || e.ColumnIndex == -1) return; //Header

            DataGridViewCell cell = dataGridView_game[e.ColumnIndex, e.RowIndex];
            if (cell.Style.BackColor == Color.White)
            {
                cell.Style.BackColor = currPlayerColor;
                if (e.RowIndex != 0) dataGridView_game[e.ColumnIndex, e.RowIndex - 1].Style.BackColor = Color.White;


                if (lineChecker.checkForWinner(cell.RowIndex, cell.ColumnIndex, currPlayerColor))
                {
                    MessageBox.Show("A winner is born " + currPlayerColor.Name);
                    isGameOver = true;
                }
                else updatePlayerColor();
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            new Form_Help().ShowDialog();
        }
    }
}
