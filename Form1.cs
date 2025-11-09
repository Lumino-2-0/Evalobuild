using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Créateur d'avaluation éducative ( de niveau 3ème pour l'instant )

namespace Evalobuild
{
    public partial class Form1 : Form
    {

        Collège.Collège collège_Form = new Collège.Collège();
        Lycée lycée_Form = new Lycée();
        Primaire primaire_Form = new Primaire();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            collège_Form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
