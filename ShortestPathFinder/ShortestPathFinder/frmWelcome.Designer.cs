namespace ShortestPathFinder
{
    partial class frmWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboSource = new ComboBox();
            cboDestination = new ComboBox();
            btnFind = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 22.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(650, 32);
            label1.Name = "label1";
            label1.Size = new Size(363, 43);
            label1.TabIndex = 0;
            label1.Text = "Shortest Path Finder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(650, 130);
            label2.Name = "label2";
            label2.Size = new Size(109, 35);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(650, 258);
            label3.Name = "label3";
            label3.Size = new Size(164, 35);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // cboSource
            // 
            cboSource.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboSource.Location = new Point(650, 168);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(283, 43);
            cboSource.TabIndex = 3;
            // 
            // cboDestination
            // 
            cboDestination.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDestination.FormattingEnabled = true;
            cboDestination.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboDestination.Location = new Point(650, 296);
            cboDestination.Name = "cboDestination";
            cboDestination.Size = new Size(283, 43);
            cboDestination.TabIndex = 4;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Ivory;
            btnFind.Font = new Font("Georgia", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.SeaGreen;
            btnFind.Location = new Point(665, 414);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(257, 72);
            btnFind.TabIndex = 5;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ROAD_MAP;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(595, 757);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 690);
            Controls.Add(btnFind);
            Controls.Add(cboDestination);
            Controls.Add(cboSource);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmWelcome";
            Text = "Path Finder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboSource;
        private ComboBox cboDestination;
        private Button btnFind;
        private PictureBox pictureBox1;
    }
}
