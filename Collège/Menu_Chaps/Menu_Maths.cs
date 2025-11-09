using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Evalobuild.Collège.Menu_Chaps
{
    public partial class Menu_Maths : UserControl
    {
        public Menu_Maths()
        {
            InitializeComponent();
        }
        
        private void Chaps_Maths_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collège collège = new Collège();
            Random_Select_Ex_Maths RSeM = new Random_Select_Ex_Maths();  //RSeM = Random Select Exercices Maths

            collège.Chapitres_Select.Clear();
            foreach (var item in Chaps_Maths.CheckedItems)
            {
                collège.Chapitres_Select.Add(item.ToString());
            }

            MessageBox.Show("Chapitres sélectionnés: \n\n" + string.Join(" || ", collège.Chapitres_Select));
            RSeM.GenererEvaluation();
        }
    }
}
