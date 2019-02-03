using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Bitmap_Converter
{
    public partial class Form1 : Form
    {

        bool widthEntered, heightEntered;

        public Form1()
        {
            InitializeComponent();

            widthEntered = false;
            heightEntered = false;

        }

        public DataTable GetResultsTable(int width, int height)
        {
           DataTable table = new DataTable();
            DataColumn col;
            DataRow ro;

            for(int x = 0; x < width; x++)
            {
                col = new DataColumn();
                col.ReadOnly = true;
                table.Columns.Add(col);
            }

            for(int y = 0; y < height; y++)
            {
                ro = table.NewRow();
                table.Rows.Add(ro);
            }

            //for(int i = 0; i<32; i++)
            //{
            //    table.Columns.Add();
            //    DataRow dr = table.NewRow();
            //    table.Rows.Add(dr);
            //}

            return table;
        }

        public void EnableGenerateButtonCheck()
        {
            if(widthEntered && heightEntered)
            {
                generateBut.Enabled = true;
            }
            else
            {
                generateBut.Enabled = false;
            }
        }

        private void widthTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(widthTextBox.Text == "Width (X)")
            {
                widthTextBox.Text = "";
                widthTextBox.ForeColor = Color.Black;
            }
            EnableGenerateButtonCheck();
        }

        private void heightTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (heightTextBox.Text == "Height (Y)")
            {
                heightTextBox.Text = "";
                heightTextBox.ForeColor = Color.Black;
            }
            EnableGenerateButtonCheck();
        }

        private void widthTextBox_Leave(object sender, EventArgs e)
        {
            if (widthTextBox.Text == "" || widthTextBox.Text == " ")
            {
                widthTextBox.Text = "Width (X)";
                widthTextBox.ForeColor = Color.DimGray;
                widthEntered = false;
            }
            else
            {
                widthEntered = true;
                EnableGenerateButtonCheck();
            }
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (heightTextBox.Text == "" || heightTextBox.Text == " ")
            {
                heightEntered = false;
                EnableGenerateButtonCheck();
            }
            else
            {
                heightEntered = true;
                EnableGenerateButtonCheck();
            }
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (widthTextBox.Text == "" || widthTextBox.Text == " ")
            {
                widthEntered = false;
                EnableGenerateButtonCheck();
            }
            else
            {
                widthEntered = true;
                EnableGenerateButtonCheck();
            }
        }

        private void generateBut_Click(object sender, EventArgs e)
        {
            int wValue, hValue;

            if (generateBut.Enabled)
            {
                if (int.TryParse(widthTextBox.Text, out wValue) && int.TryParse(heightTextBox.Text, out hValue))
                {
                    drawingPanel.DataSource = GetResultsTable(wValue, hValue);

                    int colw = 20;

                    //datagrid has calculated it's widths so we can store them
                    for (int i = 0; i <= drawingPanel.Columns.Count - 1; i++)
                    {
                        drawingPanel.Columns[i].Width = colw;
                    }

                }
                else
                {
                    MessageBox.Show("Please enter whole intgers only.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in both the width and height fields.");
            }
        }

        private void drawingPanel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                        CellStyle.BackColor = Color.Black;
                        drawingPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
                    }
                    break;
                case MouseButtons.Right:
                    {
                        DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                        CellStyle.BackColor = Color.White;
                        drawingPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
                    }
                    break;
                default:
                    break;
            }
        }

        private void drawingPanel_SelectionChanged(object sender, EventArgs e)
        {
            this.drawingPanel.ClearSelection();
        }

        private void drawingPanel_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(MouseButtons.HasFlag(MouseButtons.Left))
            {
                DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                CellStyle.BackColor = Color.Black;
                drawingPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
            }

            if(MouseButtons.HasFlag(MouseButtons.Right))
            {
                DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                CellStyle.BackColor = Color.White;
                drawingPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
            }
        }

        private void heightTextBox_Leave(object sender, EventArgs e)
        {
            if (heightTextBox.Text == "" || heightTextBox.Text == " ")
            {
                heightTextBox.Text = "Height (Y)";
                heightTextBox.ForeColor = Color.DimGray;
                heightEntered = false;
            }
            else
            {
                heightEntered = true;
                EnableGenerateButtonCheck();
            }
        }
    }
}
