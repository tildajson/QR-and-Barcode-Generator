namespace QR_and_Barcode_Generator
{
    partial class QRBarcodeForm
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
            this.QRLabel = new System.Windows.Forms.Label();
            this.QRTextBox = new System.Windows.Forms.TextBox();
            this.QRButton = new System.Windows.Forms.Button();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeTextbox = new System.Windows.Forms.TextBox();
            this.BarcodeButton = new System.Windows.Forms.Button();
            this.SavePictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SavePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRLabel
            // 
            this.QRLabel.AutoSize = true;
            this.QRLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRLabel.ForeColor = System.Drawing.Color.Black;
            this.QRLabel.Location = new System.Drawing.Point(23, 33);
            this.QRLabel.Name = "QRLabel";
            this.QRLabel.Size = new System.Drawing.Size(96, 30);
            this.QRLabel.TabIndex = 0;
            this.QRLabel.Text = "QR Code";
            // 
            // QRTextBox
            // 
            this.QRTextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRTextBox.Location = new System.Drawing.Point(125, 33);
            this.QRTextBox.Name = "QRTextBox";
            this.QRTextBox.Size = new System.Drawing.Size(502, 33);
            this.QRTextBox.TabIndex = 1;
            // 
            // QRButton
            // 
            this.QRButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.QRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QRButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QRButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRButton.ForeColor = System.Drawing.Color.Black;
            this.QRButton.Location = new System.Drawing.Point(654, 33);
            this.QRButton.Name = "QRButton";
            this.QRButton.Size = new System.Drawing.Size(94, 33);
            this.QRButton.TabIndex = 2;
            this.QRButton.Text = "Generate";
            this.QRButton.UseVisualStyleBackColor = false;
            this.QRButton.Click += new System.EventHandler(this.QRButton_Click);
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.Black;
            this.BarcodeLabel.Location = new System.Drawing.Point(26, 89);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(88, 30);
            this.BarcodeLabel.TabIndex = 3;
            this.BarcodeLabel.Text = "Barcode";
            // 
            // BarcodeTextbox
            // 
            this.BarcodeTextbox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextbox.Location = new System.Drawing.Point(125, 90);
            this.BarcodeTextbox.Name = "BarcodeTextbox";
            this.BarcodeTextbox.Size = new System.Drawing.Size(502, 33);
            this.BarcodeTextbox.TabIndex = 4;
            // 
            // BarcodeButton
            // 
            this.BarcodeButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BarcodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BarcodeButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeButton.ForeColor = System.Drawing.Color.Black;
            this.BarcodeButton.Location = new System.Drawing.Point(654, 89);
            this.BarcodeButton.Name = "BarcodeButton";
            this.BarcodeButton.Size = new System.Drawing.Size(94, 33);
            this.BarcodeButton.TabIndex = 5;
            this.BarcodeButton.Text = "Generate";
            this.BarcodeButton.UseVisualStyleBackColor = false;
            this.BarcodeButton.Click += new System.EventHandler(this.BarcodeButton_Click);
            // 
            // SavePictureBox
            // 
            this.SavePictureBox.Location = new System.Drawing.Point(43, 156);
            this.SavePictureBox.Name = "SavePictureBox";
            this.SavePictureBox.Size = new System.Drawing.Size(652, 228);
            this.SavePictureBox.TabIndex = 6;
            this.SavePictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveButton.Location = new System.Drawing.Point(320, 390);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 37);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QRBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SavePictureBox);
            this.Controls.Add(this.BarcodeButton);
            this.Controls.Add(this.BarcodeTextbox);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.QRButton);
            this.Controls.Add(this.QRTextBox);
            this.Controls.Add(this.QRLabel);
            this.Name = "QRBarcodeForm";
            this.Text = "QR & Barcode Generator";
            this.Load += new System.EventHandler(this.QRBarcodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SavePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QRLabel;
        private System.Windows.Forms.TextBox QRTextBox;
        private System.Windows.Forms.Button QRButton;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox BarcodeTextbox;
        private System.Windows.Forms.Button BarcodeButton;
        private System.Windows.Forms.PictureBox SavePictureBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

