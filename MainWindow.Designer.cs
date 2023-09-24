namespace UnsplashDesktopSetter
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showAPictureButton = new System.Windows.Forms.Button();
            this.SetWallpaperButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WallpaperStyleSelector = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showAPictureButton);
            this.flowLayoutPanel1.Controls.Add(this.SetWallpaperButton);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.WallpaperStyleSelector);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 530);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // showAPictureButton
            // 
            this.showAPictureButton.AutoSize = true;
            this.showAPictureButton.Location = new System.Drawing.Point(3, 3);
            this.showAPictureButton.Name = "showAPictureButton";
            this.showAPictureButton.Size = new System.Drawing.Size(88, 23);
            this.showAPictureButton.TabIndex = 0;
            this.showAPictureButton.Text = "Show a picture";
            this.showAPictureButton.UseVisualStyleBackColor = true;
            this.showAPictureButton.Click += new System.EventHandler(this.ShowAPictureButtonClick);
            // 
            // SetWallpaperButton
            // 
            this.SetWallpaperButton.AutoSize = true;
            this.SetWallpaperButton.Location = new System.Drawing.Point(97, 3);
            this.SetWallpaperButton.Name = "SetWallpaperButton";
            this.SetWallpaperButton.Size = new System.Drawing.Size(94, 23);
            this.SetWallpaperButton.TabIndex = 1;
            this.SetWallpaperButton.Text = "Set Wallpaper";
            this.SetWallpaperButton.UseVisualStyleBackColor = true;
            this.SetWallpaperButton.Click += new System.EventHandler(this.SetWallpaperButtonClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a fit for your image";
            // 
            // WallpaperStyleSelector
            // 
            this.WallpaperStyleSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WallpaperStyleSelector.FormattingEnabled = true;
            this.WallpaperStyleSelector.Items.AddRange(new object[] {
            "Center",
            "Fit",
            "Stretch",
            "Tile",
            "Span"});
            this.WallpaperStyleSelector.Location = new System.Drawing.Point(335, 3);
            this.WallpaperStyleSelector.Name = "WallpaperStyleSelector";
            this.WallpaperStyleSelector.Size = new System.Drawing.Size(121, 21);
            this.WallpaperStyleSelector.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG/PNG/BMP Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showAPictureButton;
        private System.Windows.Forms.Button SetWallpaperButton;
        private System.Windows.Forms.ComboBox WallpaperStyleSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

