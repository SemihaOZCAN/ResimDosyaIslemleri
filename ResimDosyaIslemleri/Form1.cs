using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimDosyaIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim;
        Bitmap bmp;
        Color renk;

       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRESIMSEC_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    resim = openFileDialog1.FileName; // Seçilen resmin dosya yolunu alıyoruz
                }
                else
                {
                    MessageBox.Show("Resim seçilmedi!"); // Eğer kullanıcı iptal ederse uyarı mesajı
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message); // Hata mesajı
            }
        }

        private void btnRENKSEC_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    renk = colorDialog1.Color; // Seçilen rengi alıyoruz
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message); // Hata mesajı
            }
        }

        private void btnYAZDIR_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(resim)) // Eğer bir resim seçildiyse
                {
                    bmp = new Bitmap(resim); // Seçilen resmi Bitmap'e çeviriyoruz
                    Graphics g = Graphics.FromImage(bmp); // Grafik nesnesi ile resmi düzenliyoruz

                    // Metni belirtilen font, renk ve pozisyonla resmin üzerine yazdırıyoruz
                    g.DrawString(textBoxMetin.Text,
                        new Font("Segoe UI", Convert.ToUInt16(textBoxBoyut.Text), FontStyle.Bold),
                        new SolidBrush(renk), 20, 30);

                    pictureBox1.Image = bmp; // İşlenen resmi PictureBox'ta gösteriyoruz
                }
                else
                {
                    MessageBox.Show("Lütfen önce bir resim seçin."); // Eğer resim seçilmemişse uyarı mesajı
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message); // Hata mesajı
            }
        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmp != null) // Eğer düzenlenmiş bir resim varsa
                {
                    saveFileDialog1.Filter = "JPEG Resim|*.jpg|PNG Resim|*.png"; // Kaydetme filtreleri
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string extension = System.IO.Path.GetExtension(saveFileDialog1.FileName).ToLower(); // Dosya uzantısını alıyoruz
                        switch (extension)
                        {
                            case ".jpg":
                                bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg); // JPEG formatında kaydetme
                                break;
                            case ".png":
                                bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png); // PNG formatında kaydetme
                                break;
                            default:
                                MessageBox.Show("Desteklenmeyen format!"); // Eğer farklı bir format seçilirse
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kaydedilecek bir resim yok."); // Eğer resim yoksa uyarı mesajı
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message); // Hata mesajı
            }
        }
    }
}
