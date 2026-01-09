using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{

    public partial class MemberForm : Form
    {
        Member _user;
        public MemberForm(Member user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            MemberService service = new MemberService();
            dataGridView1.DataSource = service.GetMembers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            cmbRole.Text = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Role = cmbRole.Text,                   


                };

                MemberService service = new MemberService();
                service.AddMember(member);

                MessageBox.Show("Üye eklendi");
                dataGridView1.DataSource = service.GetMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
        dataGridView1.CurrentRow.Cells["MemberId"].Value);

            Member member = new Member
            {
                MemberId = id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Role = cmbRole.Text,              

            };

            MemberService service = new MemberService();
            service.UpdateMember(member);

            MessageBox.Show("Üye güncellendi");
            dataGridView1.DataSource = service.GetMembers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
        dataGridView1.CurrentRow.Cells["MemberId"].Value);

            MemberService service = new MemberService();
            service.DeleteMember(id);

            MessageBox.Show("Üye silindi");
            dataGridView1.DataSource = service.GetMembers();
        }

       
    }
}
