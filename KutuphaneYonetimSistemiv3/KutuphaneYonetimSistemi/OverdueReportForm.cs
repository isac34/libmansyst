using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BLL;
using Kutuphane.DAL;
using Org.BouncyCastle.Utilities.Zlib;
using System.Windows.Forms.DataVisualization.Charting;

namespace KutuphaneYonetimSistemi
{

    public partial class OverdueReportForm : Form
    {
        ReportService _service = new ReportService();
        Chart chartStats;
        public OverdueReportForm()
        {
            InitializeComponent();
        }

        private void OverdueReportForm_Load(object sender, EventArgs e)
        {
            GrafigiHazirla();
            VerileriYukle();
            GrafigiDoldur();

        }
        private void VerileriYukle()
        {
            var sayilar = _service.GetKitapStatuSayilari();
            labelToplamKitap.Text = sayilar.Toplam.ToString(); // Toplam kitap label'ın
            labelOdunctekiKitap.Text = sayilar.Oduncte.ToString(); // Ödünçte label'ın

            PastaGrafigiHazirla(sayilar.Toplam, sayilar.Oduncte);
            try
            {

                DataTable dtLate = _service.LateBooks();
                label1.Text = dtLate.Rows.Count.ToString();


                DataTable dtMembers = _service.TopMembers();
                if (dtMembers.Rows.Count > 0)
                {
                    label2.Text = dtMembers.Rows[0]["FullName"].ToString();
                }


                DataTable dtBooks = _service.TopBooks();
                if (dtBooks.Rows.Count > 0)
                {
                    label3.Text = dtBooks.Rows[0]["BookName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PastaGrafigiHazirla(int toplam, int oduncte)
        {
            // Temizlik: Varsa eski grafiği uçur
            pnlPie.Controls.Clear();

            Chart pieChart = new Chart();
            pieChart.Dock = DockStyle.Fill;
            pieChart.BackColor = Color.Transparent;

            ChartArea area = new ChartArea("PieArea");
            area.BackColor = Color.Transparent;
            pieChart.ChartAreas.Add(area);

            Series seri = new Series("Durum");
            seri.ChartType = SeriesChartType.Pie;

            // Veriler: Ödünçte olanlar ve Kütüphanede kalanlar
            int mevcut = toplam - oduncte;
            seri.Points.AddXY("Ödünçte", oduncte);
            seri.Points.AddXY("Kütüphanede", mevcut);

            // Renkler: Senin kahve-bej paletine uygun
            seri.Points[0].Color = Color.FromArgb(89, 64, 42);   // Ödünçte (Koyu Kahve)
            seri.Points[1].Color = Color.FromArgb(217, 188, 154); // Mevcut (Bej)

            // Etiket ayarları
            seri.Label = "#PERCENT{P0}"; // Yüzde göster
            seri.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            pieChart.Series.Add(seri);
            pnlPie.Controls.Add(pieChart);
        }
        private void GrafigiHazirla()
        {
            chartStats = new Chart();
            chartStats.Dock = DockStyle.Fill;
            chartStats.Parent = pnlStats;
            chartStats.BackColor = Color.Transparent;


            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;


            Color eksenRengi = Color.FromArgb(89, 64, 42);
            area.AxisX.LineColor = eksenRengi;
            area.AxisY.LineColor = eksenRengi;
            area.AxisX.LabelStyle.ForeColor = eksenRengi;
            area.AxisY.LabelStyle.ForeColor = eksenRengi;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(50, 89, 64, 42);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(50, 89, 64, 42);

            chartStats.ChartAreas.Add(area);


            Series seri = new Series("Odunc");
            seri.ChartType = SeriesChartType.Candlestick;
            seri.Color = Color.FromArgb(180, 217, 188, 154);
            seri.BorderWidth = 4;

            chartStats.Series.Add(seri);
            chartStats.ChartAreas[0].AxisX.Title = "Günler (Son 30 Gün)";
            chartStats.ChartAreas[0].AxisY.Title = "Ödünç Sayısı";
            chartStats.ChartAreas[0].AxisX.TitleForeColor = Color.FromArgb(89, 64, 42);
            chartStats.ChartAreas[0].AxisY.TitleForeColor = Color.FromArgb(89, 64, 42);
        }
        private void GrafigiDoldur()
        {
            try
            {

                DataTable dt = _service.BorrowStats();

                chartStats.Series["Odunc"].Points.Clear();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime tarih = Convert.ToDateTime(row["Tarih"]);
                        int adet = Convert.ToInt32(row["Adet"]);
                        chartStats.Series["Odunc"].Points.AddXY(tarih.ToString("dd/MM"), adet);
                    }
                }
                else
                {
                    lblMainTitle.Text = "Son 7 günde ödünç işlemi yapılmamış.";
                }

                chartStats.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grafik yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void TabloyuHazirla(DataTable dt, string baslik)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Bu kategoriye ait gösterilecek veri bulunamadı.", "Bilgi");
                dgvReportDetails.DataSource = dt;
            }
            else
            {
                dgvReportDetails.DataSource = dt;
                dgvReportDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            lblMainTitle.Text = baslik;
            pnlStats.Visible = false;
            pnlDetails.Visible = true;
            pnlDetails.BringToFront();




        }
        private void btnBackToStats_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlStats.Visible = true;
            pnlStats.BringToFront();
            lblMainTitle.Text = "Genel Kütüphane İstatistikleri";
        }


        private void btnShowLate_Click(object sender, EventArgs e)
        {
            TabloyuHazirla(_service.LateBooks(), "Geciken Kitap Detayları");
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            TabloyuHazirla(_service.TopMembers(), "Üye Bazlı Ödünç Detayları");
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            TabloyuHazirla(_service.TopBooks(), "Kitap Popülerlik Detayları");
        }

        private void labelToplamKitap_Click(object sender, EventArgs e)
        {

        }
    }
}


        
    

    

