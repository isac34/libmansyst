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
namespace KutuphaneYonetimSistemi
{
    public partial class BookRequestAdminForm : Form
    {
        public BookRequestAdminForm()
        {
            InitializeComponent();
        }
        BookRequestService service = new BookRequestService();
        private void BookRequestAdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAllRequests();
        }
        int selectedRequestId;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRequestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["RequestId"].Value);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            service.Approve(selectedRequestId);
            MessageBox.Show("Talep onaylandı");
            dataGridView1.DataSource = service.GetAllRequests();
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            service.Reject(selectedRequestId);
            MessageBox.Show("Talep reddedildi");
            dataGridView1.DataSource = service.GetAllRequests();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
