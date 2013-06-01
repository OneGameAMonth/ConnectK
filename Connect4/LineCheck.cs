using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public class LineCheck
{
    private DataGridView data;
    private int lineSize;

    public LineCheck(DataGridView dataGrid, int lineCheckSize)
    {
        data = dataGrid;
        lineSize = lineCheckSize;
    }

    public bool checkForWinner(int row, int column, Color playerColor)
    {
        return 
            verticalCheck(row, column, playerColor) || 
            horizontalCheck(row, column, playerColor) ||
            leftUpDiagonalCheck(row, column, playerColor) ||
            rightUpDiagonalCheck(row, column, playerColor);
    }     

    private bool horizontalCheck(int row, int column, Color playerColor)
    {  
        int counter = 1;

        for(int i = column-1; i>=0; i--)  
        {  
            if(data[i, row].Style.BackColor != playerColor)  
                break;  

            counter++;  
        }

        for(int j = column-1;  j<data.ColumnCount; j++)  
        {  
            if(data[j, row].Style.BackColor != playerColor)  
                break;  

            counter++;  
        }
                    
        return counter >= lineSize;
    }  


    private bool verticalCheck(int row, int column, Color playerColor)
    {  
        if (row >= data.RowCount - lineSize - 1)  {  
            return false;  
        }

        for (int i = row + 1; i <= row + lineSize - 1; i++)  
        {  
            if (data[column, i].Style.BackColor != playerColor)  
            {  
                return false;  
            }  
        }  
        return true;  
    }  

    
    private bool leftUpDiagonalCheck(int row, int column, Color playerColor)
    {
        int counter = 1;

        int tempRow = row - 1;
        int tempColumn = column - 1;

        while (row >= 0 && column >= 0)
        {
            if (data[column, row].Style.BackColor == playerColor)
            {
                counter++;
                tempRow--;
                tempColumn--;
            }
            else break;
        }

        row++;
        column++;

        while (row < data.RowCount && column < data.ColumnCount)
        {
            if (data[column, row].Style.BackColor == playerColor)
            {
                counter++;
                row++;
                column++;
            }
            else break;
        }

        return counter >= lineSize;
    }

    private bool rightUpDiagonalCheck(int row, int column, Color playerColor)
    {
        int counter = 1;

        int tempRow = row + 1;
        int tempColumn = column - 1;

        while (row < data.RowCount && column >= 0)
        {
            if (data[column, row].Style.BackColor == playerColor)
            {
                counter++;
                tempRow++;
                tempColumn--;
            }
            else break;
        }

        row--;
        column++;

        while (row >= 0 && column < data.ColumnCount)
        {
            if (data[column, row].Style.BackColor == playerColor)
            {
                counter++;
                row--;
                column++;
            }
            else break;
        }

        return counter >= lineSize;
    }
}
