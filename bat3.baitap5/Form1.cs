using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bat3.baitap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?","Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
               e.Cancel = true;
                txtmasv.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enabelfalse();
        }
        private void Enabelfalse ()
        {
            txtmasv.Enabled = false;
            txthoten.Enabled = false;
            txtdiachi.Enabled = false;
        }
        private void Enabeltrue()
        {
            txtmasv.Enabled = true;
            txthoten.Enabled = true;
            txtdiachi.Enabled = true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasv.Text = string.Empty;
            txthoten.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            dtngaysinh.Text = string.Empty;
            cblop.Text = string.Empty;
            Enabeltrue();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasv.Text)|| string.IsNullOrEmpty(txthoten.Text)|| string.IsNullOrEmpty(cblop.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
            } 
            else { 
                ListViewItem item = new ListViewItem();
                item.Text = txtmasv.Text;
                listView1.Items.Add(item);
                   
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, txthoten.Text);
                item.SubItems.Add(subitem);
                ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem(item, txtdiachi.Text);
                item.SubItems.Add(sub2);
                ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem(item, dtngaysinh.Text);
                item.SubItems.Add(sub3);
                ListViewItem.ListViewSubItem sub4 = new ListViewItem.ListViewSubItem(item, cblop.Text);
                item.SubItems.Add(sub4);
            }
            txtmasv.Text = string.Empty;
            txthoten.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            dtngaysinh.Text = string.Empty;
            cblop.Text = string.Empty;
            Enabelfalse();
            
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); 
            }
        }

        private void btnxoahet_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
