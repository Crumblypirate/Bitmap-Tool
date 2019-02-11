using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        StringBuilder line, hexLine, byteLine;
        Bitmap bmp, uploadedBMP;

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

        public void UploadBMP()
        {
            line = new StringBuilder();
            hexLine = new StringBuilder();
            string text_temp_byte = "";

            int drawingPanelX = uploadedBMP.Width;
            int drawingPanelY = uploadedBMP.Height;

            widthTextBox.ForeColor = Color.Black;
            heightTextBox.ForeColor = Color.Black;
            widthTextBox.Text = drawingPanelX.ToString();
            heightTextBox.Text = drawingPanelY.ToString();

            generateBut_Click(null,null);

            for (int i = 0; i < uploadedBMP.Height; i++)
            {
                for (int j = 0; j < uploadedBMP.Width; j++)
                {
                    if (j != 0 && j % 8 == 0)
                    {
                        line.Append(" ");
                    }

                    if (uploadedBMP.GetPixel(j, i).A.ToString() == "255"
                            && uploadedBMP.GetPixel(j, i).B.ToString() == "255"
                            && uploadedBMP.GetPixel(j, i).G.ToString() == "255"
                            && uploadedBMP.GetPixel(j, i).R.ToString() == "255")
                    {
                        drawingPanel.Rows[i].Cells[j].Style.BackColor = Color.White;
                        text_temp_byte += "0";
                        line.Append("0");
                    }
                    else
                    {
                        drawingPanel.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        text_temp_byte += "1";
                        line.Append("1");
                    }

                    if (j % 8 == 0)
                    {
                        hexLine.Append("0x");
                        hexLine.AppendFormat("{0:X2}", Convert.ToByte(text_temp_byte, 2));
                        hexLine.Append(", ");

                        text_temp_byte = "";
                    }
                }

                line.AppendLine();
                hexLine.AppendLine();
            }

            binaryOutputTB.Text = line.ToString();
            hexOutputTB.Text = hexLine.ToString();

            binCTCB.Enabled = true;
            hexCTCB.Enabled = true;
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

        private void convertBut_Click(object sender, EventArgs e)
        {
            line = new StringBuilder();
            hexLine = new StringBuilder();
            byteLine = new StringBuilder();
            string text_temp_byte = "";
            int byteArrayIn = 0;
            Byte[] bmpImg = new Byte[(drawingPanel.RowCount * drawingPanel.Columns.Count)*4];

            for (int row = 0; row < drawingPanel.RowCount; row++)
            {
                for (int i = 0; i < drawingPanel.Columns.Count; i++)
                {
                    if (i != 0 && i % 8 == 0)
                    {
                        line.Append(" ");
                    }

                    if (drawingPanel.Rows[row].Cells[i].Style.BackColor == Color.Black)
                    {
                        line.Append("1");
                        text_temp_byte += "1";
                        byteLine.Append("1");

                        if(invertCB.Checked)
                        {
                            bmpImg[byteArrayIn] = 255;
                            bmpImg[byteArrayIn + 1] = 255;
                            bmpImg[byteArrayIn + 2] = 255;
                            bmpImg[byteArrayIn + 3] = 255;
                        }
                        else
                        {
                            bmpImg[byteArrayIn] = 0;
                            bmpImg[byteArrayIn + 1] = 0;
                            bmpImg[byteArrayIn + 2] = 0;
                            bmpImg[byteArrayIn + 3] = 255;
                        }

                        byteArrayIn+= 4;
                    }
                    else
                    {
                        line.Append("0");
                        text_temp_byte += "0";
                        byteLine.Append("0");

                        if (invertCB.Checked)
                        {
                            bmpImg[byteArrayIn] = 0;
                            bmpImg[byteArrayIn + 1] = 0;
                            bmpImg[byteArrayIn + 2] = 0;
                            bmpImg[byteArrayIn + 3] = 255;
                        }
                        else
                        {
                            bmpImg[byteArrayIn] = 255;
                            bmpImg[byteArrayIn + 1] = 255;
                            bmpImg[byteArrayIn + 2] = 255;
                            bmpImg[byteArrayIn + 3] = 255;
                        }

                        byteArrayIn +=4;
                    }

                    if(i % 8 == 0)
                    {
                        hexLine.Append("0x");
                        hexLine.AppendFormat("{0:X2}", Convert.ToByte(text_temp_byte, 2));
                        hexLine.Append(", ");

                        text_temp_byte = "";
                    }

                }
                line.AppendLine();
                hexLine.AppendLine();
            }

            binaryOutputTB.Text = line.ToString();
            hexOutputTB.Text = hexLine.ToString();

            binCTCB.Enabled = true;
            hexCTCB.Enabled = true;

            bmp = new Bitmap(drawingPanel.Columns.Count, drawingPanel.RowCount, PixelFormat.Format32bppArgb);

            BitmapData bmpData = bmp.LockBits(
                                 new Rectangle(0, 0, bmp.Width, bmp.Height),
                                 ImageLockMode.WriteOnly, bmp.PixelFormat);

            Marshal.Copy(bmpImg, 0, bmpData.Scan0, bmpImg.Length);

            bmp.UnlockBits(bmpData);

            //bmp.Save("C:\\Users\\Alex\\Desktop\\New folder (3)\\image24.bmp");

            bmpDisplay.Enabled = true;
            bmpDisplay.Image = bmp;

            saveImageBut.Enabled = true;
        }

        private void saveImageBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Bitmap Image|*.bmp|JPeg Image|*.jpg";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bmpDisplay.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 2:

                        bmpDisplay.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }

                fs.Close();
            }
        }

        private void bmpUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images"; 
            openFileDialog1.Filter = "All Images|*.jpg; *.bmp; *.png"; 
                                                                       
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.ToString() != "") 
            {
                bmpDisplay.ImageLocation = openFileDialog1.FileName.ToString();
                uploadedBMP = new Bitmap(openFileDialog1.FileName.ToString());

                saveImageBut.Enabled = true;

                UploadBMP();
            }
        }

        private void hexCTCB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(hexOutputTB.Text);
        }

        private void binCTCB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(binaryOutputTB.Text);
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
