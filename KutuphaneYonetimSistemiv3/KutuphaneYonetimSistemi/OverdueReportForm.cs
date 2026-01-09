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
using Org.BouncyCastle.Utilities.Zlib;

namespace KutuphaneYonetimSistemi
{
    
    public partial class OverdueReportForm : Form
    {
        public OverdueReportForm()
        {
            InitializeComponent();
        }

        private void OverdueReportForm_Load(object sender, EventArgs e)
        {
            ReportService service = new ReportService();

            dgvLate.DataSource = service.LateBooks();
            dgvTopBooks.DataSource = service.TopBooks();
            dgvTopMembers.DataSource = service.TopMembers();
        }
    }
}
