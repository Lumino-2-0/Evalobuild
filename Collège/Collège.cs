using Evalobuild.Collège.Menu_Chaps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evalobuild.Collège
{

    public partial class Collège : Form
    {

        
        public Collège()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Maths
            panel1.Controls.Clear();
            panel1.Controls.Add(Maths_Box);
            Doc_Name = "Maths_Train-Evalo_";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Français
            panel1.Controls.Clear();
            panel1.Controls.Add(Français_Box);
            Doc_Name = "Français_Train-Evalo_";
        }

        private void Collège_Load(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Anglais
            panel1.Controls.Clear();
            panel1.Controls.Add(Anglais_Box);
            Doc_Name = "Anglais_Train-Evalo_";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Espagnol
            panel1.Controls.Clear();
            panel1.Controls.Add(Espagnol_Box);
            Doc_Name = "Espagnol_Train-Evalo_";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //Histoire
            panel1.Controls.Clear();
            panel1.Controls.Add(Hisoire_Box);
            Doc_Name = "Histoire_Train-Evalo_";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Géographie
            panel1.Controls.Clear();
            panel1.Controls.Add(Géographie_Box);
            Doc_Name = "Géographie_Train-Evalo_";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //SVT
            panel1.Controls.Clear();
            panel1.Controls.Add(SVT_Box);
            Doc_Name = "SVT_Train-Evalo_";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Physique-Chimie
            panel1.Controls.Clear();
            panel1.Controls.Add(Ph_Ch_Box);
            Doc_Name = "Physique-Chimie_Train-Evalo_";
        }
    }
}


