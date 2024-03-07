using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_and_Barcode_Generator
{
    public partial class QRBarcodeForm : Form
    {

        bool isGenerated = false;
        public QRBarcodeForm()
        {
            InitializeComponent();
        }

        private void QRBarcodeForm_Load(object sender, EventArgs e)
        {

        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;

            // Edit picture box size to fit image
            SavePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            // Display result image in picture box
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            SavePictureBox.Image = qrCode.Draw(BarcodeTextbox.Text, 200);
        }

        private void BarcodeButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;

            // Edit picture box size to fit image
            SavePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            // Display result image in picture box
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            SavePictureBox.Image = barcode.Draw(BarcodeTextbox.Text, 200);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                // Fetch Desktop path
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Save and name image using current time
                SavePictureBox.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg",
                    ImageFormat.Jpeg);
            }
        }
    }
}
