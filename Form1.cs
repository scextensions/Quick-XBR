using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace QuickXBR
{
    public partial class Form1 : Form
    {
        string tempDir = string.Empty;
        string inputPath = string.Empty;
        string outputPath = string.Empty;

        public static Bitmap LoadBitmap(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                return new Bitmap(memoryStream);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempDir = Path.Combine(Application.StartupPath, @"temp\");
            inputPath = Path.Combine(tempDir, @"input.png");
            outputPath = Path.Combine(tempDir, @"output.png");
            updateImages();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void updateImages()
        {
            if (File.Exists(inputPath))
            {
                inputImage.Image = LoadBitmap(inputPath);
            }
            if (File.Exists(outputPath))
            {
                outputImage.Image = LoadBitmap(outputPath);
            }
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                File.Delete(inputPath);
                Console.WriteLine(tempDir);
                Directory.CreateDirectory(tempDir);
                File.Copy(openImageDialog.FileName, inputPath, true);
                updateImages();
            }
        }

        private bool canDoXBR()
        {
            if (File.Exists(inputPath))
            {
                if (File.Exists(Path.Combine(Application.StartupPath, @"xbr.exe")))
                {
                    return true;
                }
                else MessageBox.Show("xbr.exe is missing from application directory!", "Error while converting", MessageBoxButtons.OK);
            }
            else MessageBox.Show("No images available to convert", "Error while converting", MessageBoxButtons.OK);
            return false;
        }

        private void doXBR(string command)
        {
            File.Delete(outputPath);
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = Application.StartupPath;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            loadingPanel.Enabled = true;
            loadingPanel.Visible = true;
            process.WaitForExit();
            loadingPanel.Enabled = false;
            loadingPanel.Visible = false;
            process.Close();
            updateImages();
        }

        private void xbrFormatImage_Click(object sender, EventArgs e)
        {
            if (canDoXBR()) doXBR("/C xbr \"XBR\" temp\\input.png temp\\output.png");
        }

        private void xbrNoBlendFormatImage_Click(object sender, EventArgs e)
        {
            if (canDoXBR()) doXBR("/C xbr \"XBR-NoBlend\" temp\\input.png temp\\output.png");
        }

        private void xbrzFormatImage_Click(object sender, EventArgs e)
        {
            if (canDoXBR()) doXBR("/C xbr \"XBRz\" temp\\input.png temp\\output.png");
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
