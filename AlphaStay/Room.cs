﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaStay
{
    public partial class Room : Form
    {
        public Room(string cust_id,string entrypoint)
        {
            InitializeComponent();
            s1 = cust_id;
            s2 = entrypoint;
        }
        public string s1 { get; set; }
        public string s2 { get; set; }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s2 == "")
            {
                search_customer try_again = new search_customer();
                try_again.Show();
                Hide();
            }
            else
            {
                Customer customer = new Customer();
                customer.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation reserve = new Reservation(s1,s2);
            reserve.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            int p = 0;
            String s;
            s = comboBox1.Text;
            if(s == "Simple")
            {
                p = 500;
            }
            if(s == "Deluxe")
            {
                p = 1000;
            }
            textBox3.Text = p.ToString();
            textBox3.Enabled = false;
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }
    }
}
