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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FetchNewPictureButton = new System.Windows.Forms.Button();
            this.SetWallpaperButton = new System.Windows.Forms.Button();
            this.ImageFitLabel = new System.Windows.Forms.Label();
            this.WallpaperStyleSelector = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.ResolutionSelector = new System.Windows.Forms.ComboBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ImageDetailsLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoSize = true;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.PictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.ImageDetailsLabel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(784, 561);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.TableLayoutPanel.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.FetchNewPictureButton);
            this.flowLayoutPanel1.Controls.Add(this.SetWallpaperButton);
            this.flowLayoutPanel1.Controls.Add(this.ImageFitLabel);
            this.flowLayoutPanel1.Controls.Add(this.WallpaperStyleSelector);
            this.flowLayoutPanel1.Controls.Add(this.ResolutionLabel);
            this.flowLayoutPanel1.Controls.Add(this.ResolutionSelector);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 530);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // FetchNewPictureButton
            // 
            this.FetchNewPictureButton.AutoSize = true;
            this.FetchNewPictureButton.Location = new System.Drawing.Point(3, 3);
            this.FetchNewPictureButton.Name = "FetchNewPictureButton";
            this.FetchNewPictureButton.Size = new System.Drawing.Size(105, 23);
            this.FetchNewPictureButton.TabIndex = 0;
            this.FetchNewPictureButton.Text = "Fetch New Picutre";
            this.FetchNewPictureButton.UseVisualStyleBackColor = true;
            this.FetchNewPictureButton.Click += new System.EventHandler(this.FetchNewPictureButtonClick);
            // 
            // SetWallpaperButton
            // 
            this.SetWallpaperButton.AutoSize = true;
            this.SetWallpaperButton.Location = new System.Drawing.Point(114, 3);
            this.SetWallpaperButton.Name = "SetWallpaperButton";
            this.SetWallpaperButton.Size = new System.Drawing.Size(94, 23);
            this.SetWallpaperButton.TabIndex = 1;
            this.SetWallpaperButton.Text = "Set Wallpaper";
            this.SetWallpaperButton.UseVisualStyleBackColor = true;
            this.SetWallpaperButton.Click += new System.EventHandler(this.SetWallpaperButtonClick);
            // 
            // ImageFitLabel
            // 
            this.ImageFitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageFitLabel.AutoSize = true;
            this.ImageFitLabel.Location = new System.Drawing.Point(214, 8);
            this.ImageFitLabel.Name = "ImageFitLabel";
            this.ImageFitLabel.Size = new System.Drawing.Size(132, 13);
            this.ImageFitLabel.TabIndex = 3;
            this.ImageFitLabel.Text = "Choose a fit for your image";
            // 
            // WallpaperStyleSelector
            // 
            this.WallpaperStyleSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WallpaperStyleSelector.FormattingEnabled = true;
            this.WallpaperStyleSelector.Items.AddRange(new object[] {
            "Fit",
            "Center",
            "Stretch",
            "Tile",
            "Span"});
            this.WallpaperStyleSelector.Location = new System.Drawing.Point(352, 3);
            this.WallpaperStyleSelector.Name = "WallpaperStyleSelector";
            this.WallpaperStyleSelector.Size = new System.Drawing.Size(121, 21);
            this.WallpaperStyleSelector.TabIndex = 2;
            this.WallpaperStyleSelector.SelectedIndex = 4;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(479, 8);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(130, 13);
            this.ResolutionLabel.TabIndex = 4;
            this.ResolutionLabel.Text = "Choose resolution to fetch";
            // 
            // ResolutionSelector
            // 
            this.ResolutionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionSelector.FormattingEnabled = true;
            this.ResolutionSelector.Items.AddRange(new object[] {
            "regular",
            "raw",
            "full",
            "small",
            "thumb",
            "small_s3"});
            this.ResolutionSelector.Location = new System.Drawing.Point(615, 3);
            this.ResolutionSelector.Name = "ResolutionSelector";
            this.ResolutionSelector.Size = new System.Drawing.Size(121, 21);
            this.ResolutionSelector.TabIndex = 5;
            this.ResolutionSelector.SelectedIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(542, 521);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // ImageDetailsLabel
            // 
            this.ImageDetailsLabel.AutoSize = true;
            this.ImageDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageDetailsLabel.Location = new System.Drawing.Point(551, 0);
            this.ImageDetailsLabel.Name = "ImageDetailsLabel";
            this.ImageDetailsLabel.Size = new System.Drawing.Size(107, 18);
            this.ImageDetailsLabel.TabIndex = 4;
            this.ImageDetailsLabel.Text = "Image details";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG/PNG/BMP Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unsplash Wallpaper Setter";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button FetchNewPictureButton;
        private System.Windows.Forms.Button SetWallpaperButton;
        private System.Windows.Forms.ComboBox WallpaperStyleSelector;
        private System.Windows.Forms.Label ImageFitLabel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox ResolutionSelector;
        private System.Windows.Forms.Label ImageDetailsLabel;
    }
}

