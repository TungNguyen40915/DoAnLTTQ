using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace doan
{
    public partial class Form1 : Form
    {
        #region Biến toàn phần

        int[,] screen;
        int row;
        int column;
        int[] nhanvat;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void khoitao()
        {
            screen = new int[row, column];
            Random bom = new Random();
            int sobom = 10;
            while (sobom == 0)
            {
                int x = bom.Next(0, row * column);
                int rowbom = x / column - 1;
                int rowcolumn = x % column - 1;
                if (screen[rowbom - 1, rowcolumn - 1] != -1)
                {
                    screen[rowbom - 1, rowcolumn - 1] = -1;
                    sobom--;
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    screen[i, j] = 0;
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (screen[i, j] != -1)
                    {
                        if (i - 1 >= 0)
                        {
                            if (screen[i - 1, j] == -1)
                            {
                                screen[i, j]++;
                            }
                            if (j - 1 >= 0)
                            {
                                if (screen[i - 1, j - 1] == -1)
                                {
                                    screen[i, j]++;
                                }
                            }
                            if (j + 1 <= column)
                            {
                                if (screen[i - 1, j + 1] == -1)
                                {
                                    screen[i, j]++;
                                }
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            if (screen[i, j - 1] == -1)
                            {
                                screen[i, j]++;
                            }
                        }
                        if (i + 1 <= row)
                        {

                            if (screen[i + 1, j] == -1)
                            {
                                screen[i, j]++;
                            }
                            if (j - 1 >= 0)
                            {
                                if (screen[i + 1, j - 1] == -1)
                                {
                                    screen[i, j]++;
                                }
                            }
                            if (j + 1 <= column)
                            {
                                if (screen[i + 1, j + 1] == -1)
                                {
                                    screen[i, j]++;
                                }
                            }
                        }
                        if (j + 1 <= column)
                        {
                            if (screen[i, j + 1] == -1)
                            {
                                screen[i, j]++;
                            }
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
