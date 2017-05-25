﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TCP_serwer_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener serwer = null;
        private TcpClient klient = null;

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            IPAddress adresIP = null;

            try
            {
                adresIP = IPAddress.Parse(adres.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP", "Błąd");
                adres.Text = string.Empty;
                return;
            }

            int port = Convert.ToUInt16(my_port.Value);

            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();

                klient = serwer.AcceptTcpClient();

                info_o_polaczeniach.Items.Add("Nawiązano połączenie!");

                przycisk_start.Enabled = false;
                przycisk_stop.Enabled = true;

                klient.Close();
                serwer.Stop();
            }
            catch (Exception ex)
            {
                info_o_polaczeniach.Items.Add("Błąd inicjacji serwera!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            przycisk_stop.Enabled = false;
        }

        private void przycisk_stop_Click(object sender, EventArgs e)
        {
            serwer.Stop();
            klient.Close();

            info_o_polaczeniach.Items.Add("Zakończono pracę serwera!");
            przycisk_start.Enabled = true;
            przycisk_stop.Enabled = false;
        }
    }
}
