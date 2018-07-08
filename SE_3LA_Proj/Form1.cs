using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DL;
using BL;

namespace SE_3LA_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLR b = new BLR();
            dataGridView1.DataSource = b.customerdisplay();
        }

        private void btnroomdisplay_Click(object sender, EventArgs e)
        {
            BLR b = new BLR();
            dataGridView1.DataSource = b.roomdisplay();
        }

        private void btnreservedisplay_Click(object sender, EventArgs e)
        {
            BLR b = new BLR();
            dataGridView1.DataSource = b.reservedisplay();
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            BLR b = new BLR();
            b.deleteall();
        }

        private void btnroomreserve_Click(object sender, EventArgs e)
        {
            BLR b = new BLR();
            b.ReservationID = txtreserveid.Text;
            b.CustomerID = txtcustomerid.Text;
            b.Date = mtxtreservedate.Text;
            b.RoomNum = txtroomnum.Text;
            b.DateFrom = mtxtreservefrom.Text;
            b.DateTo = mtxtreserveto.Text;
            b.roomreserve();
            txtreserveid.Text = "";
            txtcustomerid.Text = "";
            mtxtreservedate.Text = "";
            txtroomnum.Text = "";
            mtxtreservefrom.Text = "";
            mtxtreserveto.Text = "";
        }

        public void ex()
        {
            MessageBox.Show("***");
        }

        
    }
}
