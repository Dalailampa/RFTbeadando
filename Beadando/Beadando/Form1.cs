using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Beadando
{
    public partial class Form1 : Form
    {
        SQLFunctions database = new SQLFunctions();
        
        public Form1()
        {
            InitializeComponent();
            frissit();
        }
        public void frissit()
        {
           
            database.Refresh(dataGridViewKiszallitas);
            dataGridViewKiszallitas.Columns["id"].Visible = false;
        }
        System.IO.FileStream log = new System.IO.FileStream(@"C:\TaroloGithubra\RFTbeadando\log.txt", System.IO.FileMode.OpenOrCreate);
        /// <summary>
        /// Naplózik
        /// </summary>
        /// <param name="date"></param>
        /// <param name="msg"></param>
        public void Naploz(System.DateTime date, string msg)
        {
            //System.IO.FileStream log = new System.IO.FileStream(@"D:\log.txt", System.IO.FileMode.OpenOrCreate);
            TextWriterTraceListener logfile = new TextWriterTraceListener(log);
            Trace.Listeners.Add(logfile);
            logfile.Write(date);
            logfile.WriteLine(msg);
            logfile.Write("\n");
            logfile.Flush();
            //logfile.Close();
            Console.Read();
        }

        #region Pizzák
        AlapPizza Gombás = new Sajt(new Gomba(new AlapPizza32()));
        AlapPizza Sonkás = new Sajt(new Sonka(new AlapPizza32()));
        AlapPizza Szalámis = new Sajt(new Szalami(new AlapPizza32()));
        AlapPizza Bugacci = new Paradicsom(new Csirkemaj(new Erospaprika(new AlapPizza32())));
        AlapPizza Piedone = new Bab(new Erospaprika(new Chili(new Fokhagyma(new Csaszarszalonna(new AlapPizza32())))));
        AlapPizza Magyaros = new Erospaprika(new Szalami(new Sonka(new Sajt(new Hagyma(new AlapPizza32())))));
        AlapPizza Hawaii = new Sajt(new Ananasz(new Kukorica(new Sonka(new AlapPizza32()))));
        AlapPizza Mexikói = new Sajt(new Bab(new Chili(new Csaszarszalonna(new Kukorica(new AlapPizza32())))));
        AlapPizza Mindentbele = new Sajt(new Gomba(new Szalami(new Csaszarszalonna(new Olajbogyo(new Paradicsom(new Erospaprika(new Hagyma(new Fokhagyma(new AlapPizza32())))))))));
        AlapPizza Margharita = new Sajt(new Paradicsom(new AlapPizza32()));
        AlapPizza SajtosTejfölös = new Sajt(new Tejfol(new AlapPizza32()));
        AlapPizza TejfölösMagyaros = new Sajt(new Tejfol(new Szalami(new Csaszarszalonna(new Sonka(new AlapPizza32())))));



        #endregion




        /// <summary>
        /// Mentés gomb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnMentes_Click(object sender, EventArgs e)
        //{
        //    if (boxID.Text != "" && boxNev.Text != "" && boxCim.Text != "")
        //    {
        //        int osszeg = Arosszead();
        //        string PizzaInfo = InfotGyujt();
        //        //database.Insert("alam", "dsdsds", osszeg, PizzaInfo);
        //        database.Insert(int.Parse(boxID.Text), boxNev.Text, boxCim.Text, osszeg, PizzaInfo);
        //        frissit();
        //        Naploz(System.DateTime.Now, " Új rendelés felvétele");
        //        osszeg = 0;
        //        PizzaInfo = "";
        //    }
        //}


        /// <summary>
        /// Összeadja azon pizzák árát melyek a checkBoxban ki vannak pipálva
        /// </summary>
        /// <returns></returns>
        public int Arosszead()
        {
            int osszar = 0;
            if (checkBox10.Checked)
            {
                osszar += Margharita.ar;
            }
            if (checkBox1.Checked)
            {
                osszar += Gombás.ar;
            }
            if (checkBox2.Checked)
            {
                osszar += Sonkás.ar;
            }
            if (checkBox3.Checked)
            {
                osszar += Szalámis.ar;
            }
            if (checkBox4.Checked)
            {
                osszar += Bugacci.ar;
            }
            if (checkBox5.Checked)
            {
                osszar += Piedone.ar;
            }
            if (checkBox6.Checked)
            {
                osszar += Magyaros.ar;
            }
            if (checkBox7.Checked)
            {
                osszar += Hawaii.ar;
            }
            if (checkBox8.Checked)
            {
                osszar += Mexikói.ar;
            }
            if (checkBox9.Checked)
            {
                osszar += Mindentbele.ar;
            }
            if (checkBox11.Checked)
            {
                osszar += SajtosTejfölös.ar;
            }
            if (checkBox12.Checked)
            {
                osszar += TejfölösMagyaros.ar;
            }
            return osszar;
        }


        public string InfotGyujt()
        {
            string info = "";
            if (checkBox10.Checked)
            {
                info += " Margharita";
            }
            if (checkBox1.Checked)
            {
                info += " Gombás";
            }
            if (checkBox2.Checked)
            {
                info += " Sonkás";
            }
            if (checkBox3.Checked)
            {
                info += " Szalámis";
            }
            if (checkBox4.Checked)
            {
                info += " Bugacci";
            }
            if (checkBox5.Checked)
            {
                info += " Piedone";
            }
            if (checkBox6.Checked)
            {
                info += " Magyaros";
            }
            if (checkBox7.Checked)
            {
                info += " Hawaii";
            }
            if (checkBox8.Checked)
            {
                info += " Mexikói";
            }
            if (checkBox9.Checked)
            {
                info += " Mindentbele";
            }
            if (checkBox11.Checked)
            {
                info += " SajtosTejfölös";
            }
            if (checkBox12.Checked)
            {
                info += " TejfölösMagyaros";
            }
            return info;

        }

        #region checkBoxok
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnMentes_Click_1(object sender, EventArgs e)
        {
            if (boxNev.Text != "" && boxCim.Text != "")
            {
                int osszeg = Arosszead();
                string PizzaInfo = InfotGyujt();
                //database.Insert("alam", "dsdsds", osszeg, PizzaInfo);
                database.Insert(boxNev.Text, boxCim.Text, osszeg, PizzaInfo);
                frissit();
                Naploz(System.DateTime.Now, " Új rendelés felvétele");
                osszeg = 0;
                PizzaInfo = "";
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewKiszallitas.CurrentRow.Cells["Id"].Value;
            database.Delete(id);
            database.Refresh(this.dataGridViewKiszallitas);
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewKiszallitas.CurrentRow.Cells["Id"].Value;
            Modositas m = new Modositas(id);
            m.ShowDialog();
        }
    }
}
