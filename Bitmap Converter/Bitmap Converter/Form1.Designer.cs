namespace Bitmap_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invertCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.generateBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.convertBut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.binaryOutputTB = new System.Windows.Forms.TextBox();
            this.binCTCB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hexCTCB = new System.Windows.Forms.Button();
            this.hexOutputTB = new System.Windows.Forms.TextBox();
            this.bmpDisplay = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveImageBut = new System.Windows.Forms.Button();
            this.bmpUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmpDisplay)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.AllowUserToAddRows = false;
            this.drawingPanel.AllowUserToDeleteRows = false;
            this.drawingPanel.AllowUserToResizeColumns = false;
            this.drawingPanel.AllowUserToResizeRows = false;
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.drawingPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.drawingPanel.ColumnHeadersVisible = false;
            this.drawingPanel.Location = new System.Drawing.Point(9, 19);
            this.drawingPanel.MultiSelect = false;
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.RowHeadersVisible = false;
            this.drawingPanel.ShowCellErrors = false;
            this.drawingPanel.ShowCellToolTips = false;
            this.drawingPanel.ShowEditingIcon = false;
            this.drawingPanel.ShowRowErrors = false;
            this.drawingPanel.Size = new System.Drawing.Size(671, 499);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.TabStop = false;
            this.drawingPanel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drawingPanel_CellMouseClick);
            this.drawingPanel.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.drawingPanel_CellMouseEnter);
            this.drawingPanel.SelectionChanged += new System.EventHandler(this.drawingPanel_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invertCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.heightTextBox);
            this.groupBox1.Controls.Add(this.widthTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // invertCB
            // 
            this.invertCB.AutoSize = true;
            this.invertCB.Location = new System.Drawing.Point(6, 129);
            this.invertCB.Name = "invertCB";
            this.invertCB.Size = new System.Drawing.Size(91, 17);
            this.invertCB.TabIndex = 7;
            this.invertCB.Text = "Invert Colours";
            this.invertCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Image Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Image Width";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.heightTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.heightTextBox.Location = new System.Drawing.Point(6, 91);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(76, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.TabStop = false;
            this.heightTextBox.Text = "Height (Y)";
            this.heightTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.heightTextBox_MouseClick);
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            this.heightTextBox.Leave += new System.EventHandler(this.heightTextBox_Leave);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.widthTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.widthTextBox.Location = new System.Drawing.Point(6, 39);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(76, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.TabStop = false;
            this.widthTextBox.Text = "Width (X)";
            this.widthTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.widthTextBox_MouseClick);
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.widthTextBox.Leave += new System.EventHandler(this.widthTextBox_Leave);
            // 
            // generateBut
            // 
            this.generateBut.Enabled = false;
            this.generateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBut.Location = new System.Drawing.Point(12, 179);
            this.generateBut.Name = "generateBut";
            this.generateBut.Size = new System.Drawing.Size(121, 38);
            this.generateBut.TabIndex = 1;
            this.generateBut.Text = "GENERATE!";
            this.generateBut.UseVisualStyleBackColor = true;
            this.generateBut.Click += new System.EventHandler(this.generateBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.convertBut);
            this.groupBox2.Controls.Add(this.drawingPanel);
            this.groupBox2.Location = new System.Drawing.Point(139, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 565);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Grid";
            // 
            // convertBut
            // 
            this.convertBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertBut.Enabled = false;
            this.convertBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBut.Location = new System.Drawing.Point(158, 524);
            this.convertBut.Name = "convertBut";
            this.convertBut.Size = new System.Drawing.Size(336, 34);
            this.convertBut.TabIndex = 6;
            this.convertBut.Text = "Convert";
            this.convertBut.UseVisualStyleBackColor = true;
            this.convertBut.Click += new System.EventHandler(this.convertBut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.binaryOutputTB);
            this.groupBox3.Controls.Add(this.binCTCB);
            this.groupBox3.Location = new System.Drawing.Point(831, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 565);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Binary Output";
            // 
            // binaryOutputTB
            // 
            this.binaryOutputTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.binaryOutputTB.BackColor = System.Drawing.Color.Gainsboro;
            this.binaryOutputTB.Location = new System.Drawing.Point(9, 19);
            this.binaryOutputTB.Multiline = true;
            this.binaryOutputTB.Name = "binaryOutputTB";
            this.binaryOutputTB.ReadOnly = true;
            this.binaryOutputTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.binaryOutputTB.Size = new System.Drawing.Size(601, 499);
            this.binaryOutputTB.TabIndex = 0;
            // 
            // binCTCB
            // 
            this.binCTCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.binCTCB.Enabled = false;
            this.binCTCB.Location = new System.Drawing.Point(161, 530);
            this.binCTCB.Name = "binCTCB";
            this.binCTCB.Size = new System.Drawing.Size(291, 23);
            this.binCTCB.TabIndex = 0;
            this.binCTCB.Text = "Copy to Clipboard";
            this.binCTCB.UseVisualStyleBackColor = true;
            this.binCTCB.Click += new System.EventHandler(this.binCTCB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.hexCTCB);
            this.groupBox4.Controls.Add(this.hexOutputTB);
            this.groupBox4.Location = new System.Drawing.Point(1453, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 565);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hex Output";
            // 
            // hexCTCB
            // 
            this.hexCTCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexCTCB.Enabled = false;
            this.hexCTCB.Location = new System.Drawing.Point(173, 530);
            this.hexCTCB.Name = "hexCTCB";
            this.hexCTCB.Size = new System.Drawing.Size(149, 23);
            this.hexCTCB.TabIndex = 1;
            this.hexCTCB.Text = "Copy to Clipboard";
            this.hexCTCB.UseVisualStyleBackColor = true;
            this.hexCTCB.Click += new System.EventHandler(this.hexCTCB_Click);
            // 
            // hexOutputTB
            // 
            this.hexOutputTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hexOutputTB.BackColor = System.Drawing.Color.Gainsboro;
            this.hexOutputTB.Location = new System.Drawing.Point(9, 19);
            this.hexOutputTB.Multiline = true;
            this.hexOutputTB.Name = "hexOutputTB";
            this.hexOutputTB.ReadOnly = true;
            this.hexOutputTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hexOutputTB.Size = new System.Drawing.Size(459, 499);
            this.hexOutputTB.TabIndex = 1;
            // 
            // bmpDisplay
            // 
            this.bmpDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bmpDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.bmpDisplay.Enabled = false;
            this.bmpDisplay.Location = new System.Drawing.Point(6, 19);
            this.bmpDisplay.Name = "bmpDisplay";
            this.bmpDisplay.Size = new System.Drawing.Size(113, 101);
            this.bmpDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bmpDisplay.TabIndex = 2;
            this.bmpDisplay.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.saveImageBut);
            this.groupBox5.Controls.Add(this.bmpDisplay);
            this.groupBox5.Location = new System.Drawing.Point(1933, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(129, 169);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image";
            // 
            // saveImageBut
            // 
            this.saveImageBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImageBut.Enabled = false;
            this.saveImageBut.Location = new System.Drawing.Point(6, 126);
            this.saveImageBut.Name = "saveImageBut";
            this.saveImageBut.Size = new System.Drawing.Size(115, 28);
            this.saveImageBut.TabIndex = 2;
            this.saveImageBut.Text = "Save Image";
            this.saveImageBut.UseVisualStyleBackColor = true;
            this.saveImageBut.Click += new System.EventHandler(this.saveImageBut_Click);
            // 
            // bmpUpload
            // 
            this.bmpUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmpUpload.Location = new System.Drawing.Point(12, 250);
            this.bmpUpload.Name = "bmpUpload";
            this.bmpUpload.Size = new System.Drawing.Size(121, 38);
            this.bmpUpload.TabIndex = 7;
            this.bmpUpload.Text = "Upload .BMP";
            this.bmpUpload.UseVisualStyleBackColor = true;
            this.bmpUpload.Click += new System.EventHandler(this.bmpUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 574);
            this.Controls.Add(this.bmpUpload);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generateBut);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bitmap Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.drawingPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmpDisplay)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drawingPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button generateBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button convertBut;
        private System.Windows.Forms.Button binCTCB;
        private System.Windows.Forms.TextBox binaryOutputTB;
        private System.Windows.Forms.TextBox hexOutputTB;
        private System.Windows.Forms.Button hexCTCB;
        private System.Windows.Forms.PictureBox bmpDisplay;
        private System.Windows.Forms.CheckBox invertCB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button saveImageBut;
        private System.Windows.Forms.Button bmpUpload;
    }
}

