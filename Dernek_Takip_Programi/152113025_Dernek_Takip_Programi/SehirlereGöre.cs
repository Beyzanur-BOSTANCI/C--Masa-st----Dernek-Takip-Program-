﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _152113025_Dernek_Takip_Programi
{
    public partial class SehirlereGöre : Form
    {
        public SehirlereGöre()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataAdapter dtst = new OleDbDataAdapter();
        //listeye ekleme işlemleri
        List<string> shrad = new List<string>();
        List<int> shradet = new List<int>();
        List<string> cop = new List<string>();
        private void SehirlereGöre_Load(object sender, EventArgs e)
        {
            

      
            baglanti.Open();//Bağlantı açılır.
            OleDbCommand komut = new OleDbCommand("select IlAdi from UyeEklemeTablosu", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            OleDbCommand kmt = new OleDbCommand("select IlAdi from UyeEklemeTablosu", baglanti);
            OleDbDataReader dread = kmt.ExecuteReader();

            while (dread.Read())
            {
                shrad.Add(dread["IlAdi"].ToString());

            }
            dread.Dispose();

            int k = 0;
            OleDbCommand kmt2;
            OleDbDataReader dread2;
            for (int i = 0; i < shrad.Count; i++)
            {
                cop.Clear();
                k = 0;
                kmt2 = new OleDbCommand("select IlAdi from UyeEklemeTablosu where IlAdi='" + shrad[i] + "'", baglanti);
                dread2 = kmt2.ExecuteReader();
                while (dread2.Read())
                {
                    cop.Add(dread2["IlAdi"].ToString());


                }
                k = cop.Count;
                shradet.Add(k);
                dread2.Dispose();
            }

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();

            }
            int z = 0;
            while (oku.Read())
            {
                if (shradet[z] != 0)
                {
                    chart1.Series["Series1"].Points.AddXY(shrad[z], shradet[z]);
                }
                z++;
            }
            baglanti.Close();
        }
    }
}
