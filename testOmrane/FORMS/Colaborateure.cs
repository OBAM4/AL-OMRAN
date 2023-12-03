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

namespace testOmrane.FORMS
{
    public partial class Colaborateure : Form
    {
        public Colaborateure()
        {
            InitializeComponent();
        }
        Conee c = new Conee();


        public void Actualiser()
        {
            c.connecter();
            c.query.CommandText = "select * from Collaborateure";
            c.query.Connection = c.cnx;
            c.dr = c.query.ExecuteReader();
            c.dt.Load(c.dr);
            dataGridView1.DataSource = c.dt;
            c.deconnecter();
        }

        bool isShow;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Spanel.Visible)
            {
                isShow = false;

                timer1.Start();
            }
            else

                
            {
                isShow = true;
                Spanel.Show();
                timer1.Start();
            }
        }
        private void Colaborateure_Load(object sender, EventArgs e)
        {
            Spanel.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (Spanel.Width >= 200)
                    timer1.Stop();
                Spanel.Width += 50;
            }
            else
            {
                if (Spanel.Width <= 0)
                {

                    Spanel.Hide();
                    timer1.Stop();
                }
                Spanel.Width -= 50;
            }
        }
        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
