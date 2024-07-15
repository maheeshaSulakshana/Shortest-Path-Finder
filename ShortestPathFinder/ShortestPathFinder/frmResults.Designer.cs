namespace ShortestPathFinder
{
    partial class frmResults
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
            pictureBox1 = new PictureBox();
            lblDistance = new Label();
            label2 = new Label();
            lblPath = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 599);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistance.Location = new Point(441, 100);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(275, 50);
            lblDistance.TabIndex = 1;
            lblDistance.Text = "Total Distance: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(441, 188);
            label2.Name = "label2";
            label2.Size = new Size(106, 50);
            label2.TabIndex = 2;
            label2.Text = "Path:";
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPath.Location = new Point(441, 267);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(106, 50);
            lblPath.TabIndex = 3;
            lblPath.Text = "Path:";
            // 
            // button1
            // 
            button1.Location = new Point(748, 503);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmResults
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(929, 623);
            Controls.Add(button1);
            Controls.Add(lblPath);
            Controls.Add(label2);
            Controls.Add(lblDistance);
            Controls.Add(pictureBox1);
            Name = "frmResults";
            Text = "Shortest Path to Destination";
            FormClosing += frmResults_FormClosing;
            Load += frmResults_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDistance;
        private Label label2;
        private Label lblPath;
        private Button button1;
    }
}