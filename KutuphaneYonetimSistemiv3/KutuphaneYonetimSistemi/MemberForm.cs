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
        private List<Member> _memberList;
        private BindingSource _bs = new BindingSource();
        public MemberForm(Member user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            RefreshMemberList();
        }

        private void RefreshMemberList()
        {
            MemberService service = new MemberService();
            _memberList = service.GetMembers();

            dataGridView1.AutoGenerateColumns = true;
            _bs.DataSource = _memberList;
            dataGridView1.DataSource = _bs;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_memberList == null) return;

            string text = txtSearch.Text.ToLower();

            var filtered = _memberList
                .Where(m =>
                    (m.FirstName ?? "").ToLower().Contains(text) ||
                    (m.LastName ?? "").ToLower().Contains(text) ||
                    (m.Email ?? "").ToLower().Contains(text) ||
                    (m.Phone ?? "").ToLower().Contains(text) ||
                    (m.Role ?? "").ToLower().Contains(text)
                )
                .ToList();

            _bs.DataSource = filtered;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                cmbRole.Text = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(cmbRole.Text))
                {
                    MessageBox.Show("Tüm alanları doldurun!");
                    return;
                }

                Member member = new Member
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Role = cmbRole.Text
                };

                MemberService service = new MemberService();
                service.AddMember(member);

                MessageBox.Show("Üye eklendi");
                RefreshMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen bir üye seçin!");
                    return;
                }

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MemberId"].Value);

                Member member = new Member
                {
                    MemberId = id,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Role = cmbRole.Text
                };

                MemberService service = new MemberService();
                service.UpdateMember(member);

                MessageBox.Show("Üye güncellendi");
                RefreshMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen bir üye seçin!");
                    return;
                }

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MemberId"].Value);

                MemberService service = new MemberService();
                service.DeleteMember(id);

                MessageBox.Show("Üye silindi");
                RefreshMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
