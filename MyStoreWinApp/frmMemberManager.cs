using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using As01.BusinessObject;
using DataAccess.Repository;
namespace MyStoreWinApp
{
    public partial class frmMemberManager : Form
    {

        IMemberRepository memRepository = new MemberRepository();
        public frmMemberManager()
        {
            InitializeComponent();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            tbId.Text = dgvList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            tbName.Text = dgvList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            tbMail.Text = dgvList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            tbPass.Text = dgvList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbCity.SelectedItem = dgvList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            cbCountry.SelectedItem = dgvList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberID = int.Parse(tbId.Text);
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem.ToString();
                mem.Country = cbCountry.SelectedItem.ToString();
                mem.Pass = tbPass.Text;

                memRepository.Delete(mem);
                MessageBox.Show("Delete succed!");
                List<MemberObject> li = memRepository.GetAllMembers().ToList();
                dgvList.DataSource = li;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberID = int.Parse(tbId.Text);
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem.ToString();
                mem.Country = cbCountry.SelectedItem.ToString();
                mem.Pass = tbPass.Text;

                memRepository.Update(mem);
                MessageBox.Show("Update succed!");
                List<MemberObject> li = memRepository.GetAllMembers().ToList();
                dgvList.DataSource = li;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem.ToString();
                mem.Country = cbCountry.SelectedItem.ToString();
                mem.Pass = tbPass.Text;

                memRepository.AddNew(mem);
                MessageBox.Show("Insert succed!");
                List<MemberObject> li = memRepository.GetAllMembers().ToList();
                dgvList.DataSource = li;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbId.Text = string.Empty;
            tbName.Text = string.Empty;
            tbMail.Text = string.Empty;
            tbPass.Text = string.Empty;
            cbCity.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            tbSearch.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MemberObject> li = null;
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                li = memRepository.GetAllMembers().ToList();
            }
            else
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    li = memRepository.getMembersByCountry(cbTitle.SelectedItem.ToString(), tbSearch.Text).ToList();
                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    li = memRepository.getMembersByCity(cbTitle.SelectedItem.ToString(), tbSearch.Text).ToList();
                }
            }
            if (cbFilOr.SelectedIndex == 0)
            {
                if (cbOrder.SelectedIndex == 0)
                {

                    li = li.OrderBy(mem => mem.MemberID).ToList();
                }
                else
                {
                    li = li.OrderByDescending(mem => mem.MemberID).ToList();
                }
            }
            else if (cbFilOr.SelectedIndex == 1)
            {
                if (cbOrder.SelectedIndex == 0)
                {
                    li = li.OrderBy(mem => mem.MemberName).ToList();
                }
                else
                {
                    li = li.OrderByDescending(mem => mem.MemberName).ToList();
                }
            }
            dgvList.DataSource = li;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                cbTitle.DataSource = memRepository.GetCountry();
                cbTitle.DisplayMember = "Country";
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                cbTitle.DataSource = memRepository.GetCities();
                cbTitle.DisplayMember = "City";
            }
        }

        private void frmMemberManager_Load(object sender, EventArgs e)
        {
            List<MemberObject> li = memRepository.GetAllMembers().ToList();
            dgvList.DataSource = li;
            cbFilter.SelectedIndex = 0;
            cbOrder.SelectedIndex = 0;
            cbFilOr.SelectedIndex = 0;
            cbCountry.DataSource = memRepository.GetCountry();
            cbCountry.SelectedIndex = 0;

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.DataSource = memRepository.GetCities(cbCountry.SelectedItem.ToString());
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
