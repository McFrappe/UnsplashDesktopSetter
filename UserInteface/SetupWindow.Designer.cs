namespace UnsplashDesktopSetter
{
    partial class SetupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.APIKeyInputTextBox = new System.Windows.Forms.TextBox();
            this.APIKeySubmitButton = new System.Windows.Forms.Button();
            this.APIKeyHelpText = new System.Windows.Forms.Label();
            this.IncorrectAPIKey = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.APIKeyInputTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.APIKeySubmitButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.APIKeyHelpText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IncorrectAPIKey, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your API access key from Unsplash below:";
            // 
            // APIKeyInputTextBox
            // 
            this.APIKeyInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.APIKeyInputTextBox.Location = new System.Drawing.Point(211, 83);
            this.APIKeyInputTextBox.Name = "APIKeyInputTextBox";
            this.APIKeyInputTextBox.Size = new System.Drawing.Size(203, 20);
            this.APIKeyInputTextBox.TabIndex = 1;
            // 
            // APIKeySubmitButton
            // 
            this.APIKeySubmitButton.Location = new System.Drawing.Point(211, 127);
            this.APIKeySubmitButton.Name = "APIKeySubmitButton";
            this.APIKeySubmitButton.Size = new System.Drawing.Size(75, 23);
            this.APIKeySubmitButton.TabIndex = 2;
            this.APIKeySubmitButton.Text = "Submit";
            this.APIKeySubmitButton.UseVisualStyleBackColor = true;
            this.APIKeySubmitButton.Click += new System.EventHandler(this.APIKeySubmitButtonClick);
            // 
            // APIKeyHelpText
            // 
            this.APIKeyHelpText.AutoSize = true;
            this.APIKeyHelpText.Dock = System.Windows.Forms.DockStyle.Left;
            this.APIKeyHelpText.Location = new System.Drawing.Point(3, 0);
            this.APIKeyHelpText.Name = "APIKeyHelpText";
            this.tableLayoutPanel1.SetRowSpan(this.APIKeyHelpText, 4);
            this.APIKeyHelpText.Size = new System.Drawing.Size(200, 186);
            this.APIKeyHelpText.TabIndex = 3;
            this.APIKeyHelpText.Text = resources.GetString("APIKeyHelpText.Text");
            // 
            // IncorrectAPIKey
            // 
            this.IncorrectAPIKey.AutoSize = true;
            this.IncorrectAPIKey.ForeColor = System.Drawing.Color.Red;
            this.IncorrectAPIKey.Location = new System.Drawing.Point(211, 154);
            this.IncorrectAPIKey.Name = "IncorrectAPIKey";
            this.IncorrectAPIKey.Size = new System.Drawing.Size(173, 13);
            this.IncorrectAPIKey.TabIndex = 4;
            this.IncorrectAPIKey.Text = "API key was not correct. Try again.";
            this.IncorrectAPIKey.Visible = false;
            // 
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 186);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SetupWindow";
            this.Text = "SetupWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox APIKeyInputTextBox;
        private System.Windows.Forms.Button APIKeySubmitButton;
        private System.Windows.Forms.Label APIKeyHelpText;
        private System.Windows.Forms.Label IncorrectAPIKey;
    }
}