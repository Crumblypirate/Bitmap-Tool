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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.generateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.AllowUserToAddRows = false;
            this.drawingPanel.AllowUserToDeleteRows = false;
            this.drawingPanel.AllowUserToResizeColumns = false;
            this.drawingPanel.AllowUserToResizeRows = false;
            this.drawingPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.drawingPanel.ColumnHeadersVisible = false;
            this.drawingPanel.Location = new System.Drawing.Point(148, 12);
            this.drawingPanel.MultiSelect = false;
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.RowHeadersVisible = false;
            this.drawingPanel.ShowCellErrors = false;
            this.drawingPanel.ShowCellToolTips = false;
            this.drawingPanel.ShowEditingIcon = false;
            this.drawingPanel.ShowRowErrors = false;
            this.drawingPanel.Size = new System.Drawing.Size(501, 544);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.TabStop = false;
            this.drawingPanel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drawingPanel_CellMouseClick);
            this.drawingPanel.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.drawingPanel_CellMouseEnter);
            this.drawingPanel.SelectionChanged += new System.EventHandler(this.drawingPanel_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.heightTextBox);
            this.groupBox1.Controls.Add(this.widthTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
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
            this.generateBut.Location = new System.Drawing.Point(12, 142);
            this.generateBut.Name = "generateBut";
            this.generateBut.Size = new System.Drawing.Size(121, 38);
            this.generateBut.TabIndex = 1;
            this.generateBut.Text = "GENERATE!";
            this.generateBut.UseVisualStyleBackColor = true;
            this.generateBut.Click += new System.EventHandler(this.generateBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 568);
            this.Controls.Add(this.generateBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawingPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bitmap Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.drawingPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

