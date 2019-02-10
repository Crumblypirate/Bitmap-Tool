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
        DataTable table;
        Graphics g;
        SolidBrush sbr;
        Font font;
        int xSpace = 10, ySpace = 12;

        public Form1()
        {
            InitializeComponent();

            widthEntered = false;
            heightEntered = false;
        }

        public DataTable GetResultsTable(int width, int height)
        {
            table = new DataTable();
            DataColumn col;
            DataRow ro;

            for (int x = 0; x < width; x++)
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

        public void PanelTextInit(Panel target)
        {
            sbr = new SolidBrush(Color.Black);
            g = target.CreateGraphics();
            FontFamily fam = new FontFamily("Microsoft Sans Serif");
            font = new System.Drawing.Font(fam, 10, FontStyle.Regular);
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

                    convertBut.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("AYYYYYYYYYYYYYY");
        }

        private void convertBut_Click(object sender, EventArgs e)
        {
            PanelTextInit(binaryOutput);

            binaryOutput.Refresh();
            //Max lenght of string before new line for binary panel.
            //string rand = "00000000 00000000 00000000 00000000 00000000 00000000 00000000";
            //g.DrawString(rand, font, sbr, new Point(1, 1));
            string rand = "00000000 00000000 00000000 00000000 00000000 00000000 00000000";
            int spaceIndex = 8;
           // extBox1.Text = DataGridView1.Rows[3].Cells[1].Value.ToString();
            for (int row = 0; row < drawingPanel.RowCount; row++)
            {
                StringBuilder line = new StringBuilder();
                xSpace = 8;
                ySpace = 12;
                for (int i = 0; i < drawingPanel.Columns.Count; i++)
                {
                    //if(i == 0)
                    //{
                    //    spaceIndex = 7;
                    //}
                    //else
                    //{
                        spaceIndex = 8;
                   // }

                    //String header = GridView2.Columns[i].HeaderText;
                    //String cellText = row.Cells[i].Text;
                    // g.DrawString(rand, font, sbr, new Point(1, row * 12));
                    // Convert.ToString(row1.Cells[i].Value);

                    if (i != 0 && i % 8 == 0)
                    {
                        line.Append(" ");
                        //xSpace += 8;
                    }

                    if (drawingPanel.Rows[row].Cells[i].Style.BackColor == Color.Black)
                    {
                        //if (i != 0 && i % spaceIndex == 0)
                        //{
                        //    line.Append("1 ");
                        //    //g.DrawString("1  ", font, sbr, new Point(i * xSpace, row * ySpace));
                        //}
                        //else
                        //{
                            line.Append("1");
                            //g.DrawString("1", font, sbr, new Point(i * xSpace, row * ySpace));
                       // }
                      
                        
                    }
                    else
                    {
                        //if (i != 0 && i % spaceIndex == 0)
                        //{
                        //    line.Append("0 ");
                        //    //g.DrawString("0  ", font, sbr, new Point(i * xSpace, row * ySpace));
                        //}
                        //else
                        //{
                            line.Append("0");
                            //g.DrawString("0", font, sbr, new Point(i * xSpace, row * ySpace));
                      //  }

                    }

                    //xSpace = 8;
                }
                g.DrawString(line.ToString(), font, sbr, new Point(1, row * ySpace));
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
