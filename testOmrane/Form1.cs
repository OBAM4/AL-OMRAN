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

namespace testOmrane
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeform;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            pictureclose.Visible = false;
        }  
        private Color selecteThemColor()
        {
            int index = random.Next(ThemeColor.colorlist.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.colorlist.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void activateButton(object btnSender)
        {
            if(btnSender!= null)
            {
                if(currentButton!=(Button)btnSender)
                {
                    Disablebutton();
                    Color color = selecteThemColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;


                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    panelTitreBar.BackColor = color;
                    panel2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    pictureclose.Visible = true;

                }
            }
        }
           private void Disablebutton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()== typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }


        private void openchildform(Form childform , object btnsender)
        {
            if(activeform!= null)
            {
                activeform.Close();

            }
            activateButton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDes.Controls.Add(childform);

            this.panelDes.Tag = childform;
            childform.BringToFront();
            childform.Show();
            label1.Text = childform.Text;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new FORMS.Colaborateure(), sender); 

        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            openchildform(new FORMS.Materiel(), sender);
        }

        private void BtnAffec_Click(object sender, EventArgs e)
        {
            openchildform(new FORMS.Affectation(), sender);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            openchildform(new FORMS.Categorie(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            reset();
               
        }

        private void reset()
        {
            Disablebutton();
            label1.BackColor = Color.FromArgb(0, 150, 136);
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            pictureclose.Visible = false;
        }
    }
}
