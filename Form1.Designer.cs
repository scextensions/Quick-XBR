namespace QuickXBR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openImageButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.xbrFormatImage = new System.Windows.Forms.Button();
            this.xbrNoBlendFormatImage = new System.Windows.Forms.Button();
            this.xbrzFormatImage = new System.Windows.Forms.Button();
            this.outputImage = new System.Windows.Forms.PixelBox();
            this.inputImage = new System.Windows.Forms.PixelBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resolutionOriginal = new System.Windows.Forms.Label();
            this.resolutionConverted = new System.Windows.Forms.Label();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(12, 12);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(75, 23);
            this.openImageButton.TabIndex = 0;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(12, 182);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(107, 23);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save Output Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // xbrFormatImage
            // 
            this.xbrFormatImage.Location = new System.Drawing.Point(12, 67);
            this.xbrFormatImage.Name = "xbrFormatImage";
            this.xbrFormatImage.Size = new System.Drawing.Size(37, 23);
            this.xbrFormatImage.TabIndex = 2;
            this.xbrFormatImage.Text = "XBR";
            this.xbrFormatImage.UseVisualStyleBackColor = true;
            this.xbrFormatImage.Click += new System.EventHandler(this.xbrFormatImage_Click);
            // 
            // xbrNoBlendFormatImage
            // 
            this.xbrNoBlendFormatImage.Location = new System.Drawing.Point(12, 96);
            this.xbrNoBlendFormatImage.Name = "xbrNoBlendFormatImage";
            this.xbrNoBlendFormatImage.Size = new System.Drawing.Size(81, 23);
            this.xbrNoBlendFormatImage.TabIndex = 3;
            this.xbrNoBlendFormatImage.Text = "XBR NoBlend";
            this.xbrNoBlendFormatImage.UseVisualStyleBackColor = true;
            this.xbrNoBlendFormatImage.Click += new System.EventHandler(this.xbrNoBlendFormatImage_Click);
            // 
            // xbrzFormatImage
            // 
            this.xbrzFormatImage.Location = new System.Drawing.Point(12, 125);
            this.xbrzFormatImage.Name = "xbrzFormatImage";
            this.xbrzFormatImage.Size = new System.Drawing.Size(42, 23);
            this.xbrzFormatImage.TabIndex = 4;
            this.xbrzFormatImage.Text = "XBRz";
            this.xbrzFormatImage.UseVisualStyleBackColor = true;
            this.xbrzFormatImage.Click += new System.EventHandler(this.xbrzFormatImage_Click);
            // 
            // outputImage
            // 
            this.outputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputImage.Location = new System.Drawing.Point(320, 27);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(164, 164);
            this.outputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImage.TabIndex = 5;
            this.outputImage.TabStop = false;
            // 
            // inputImage
            // 
            this.inputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputImage.Location = new System.Drawing.Point(150, 27);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(164, 164);
            this.inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImage.TabIndex = 6;
            this.inputImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Scalers Up Resolution 2x";
            // 
            // resolutionOriginal
            // 
            this.resolutionOriginal.AutoSize = true;
            this.resolutionOriginal.Location = new System.Drawing.Point(150, 198);
            this.resolutionOriginal.Name = "resolutionOriginal";
            this.resolutionOriginal.Size = new System.Drawing.Size(24, 13);
            this.resolutionOriginal.TabIndex = 8;
            this.resolutionOriginal.Text = "0x0";
            // 
            // resolutionConverted
            // 
            this.resolutionConverted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resolutionConverted.AutoSize = true;
            this.resolutionConverted.Location = new System.Drawing.Point(460, 198);
            this.resolutionConverted.Name = "resolutionConverted";
            this.resolutionConverted.Size = new System.Drawing.Size(24, 13);
            this.resolutionConverted.TabIndex = 9;
            this.resolutionConverted.Text = "0x0";
            this.resolutionConverted.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "PNG Images|*.png";
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.Transparent;
            this.loadingPanel.Controls.Add(this.label3);
            this.loadingPanel.Controls.Add(this.label2);
            this.loadingPanel.Enabled = false;
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(496, 217);
            this.loadingPanel.TabIndex = 10;
            this.loadingPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "This may take some time for especially large images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Converting Image...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.resolutionConverted);
            this.Controls.Add(this.resolutionOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputImage);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.xbrzFormatImage);
            this.Controls.Add(this.xbrNoBlendFormatImage);
            this.Controls.Add(this.xbrFormatImage);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.openImageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 256);
            this.MinimumSize = new System.Drawing.Size(512, 256);
            this.Name = "Form1";
            this.Text = "Quick XBR Scaler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button xbrFormatImage;
        private System.Windows.Forms.Button xbrNoBlendFormatImage;
        private System.Windows.Forms.Button xbrzFormatImage;
        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.PictureBox inputImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resolutionOriginal;
        private System.Windows.Forms.Label resolutionConverted;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

