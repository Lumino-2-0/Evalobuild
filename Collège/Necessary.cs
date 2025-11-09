using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalobuild.Collège
{
    public partial class Collège
    {
       
        Menu_Chaps.Menu_Maths Maths_Box = new Menu_Chaps.Menu_Maths();
        Menu_Chaps.Menu_Histoire Hisoire_Box = new Menu_Chaps.Menu_Histoire();
        Menu_Chaps.Menu_Français Français_Box = new Menu_Chaps.Menu_Français();
        Menu_Chaps.Menu_Géographie Géographie_Box = new Menu_Chaps.Menu_Géographie();
        Menu_Chaps.Menu_Anglais Anglais_Box = new Menu_Chaps.Menu_Anglais();
        Menu_Chaps.Menu_Espagnol Espagnol_Box = new Menu_Chaps.Menu_Espagnol();
        Menu_Chaps.Menu_SVT SVT_Box = new Menu_Chaps.Menu_SVT();
        Menu_Chaps.Menu_Physique_Chimie Ph_Ch_Box = new Menu_Chaps.Menu_Physique_Chimie();
        

        public string Doc_Name;
        public List<string> Chapitres_Select = new List<string>();

        
    }
}
