using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;
using System.Windows.Forms;

namespace Evalobuild.Collège
{

    public class Random_Select_Ex_Maths
    {
        // Liste des questions pour le chapitre Multiples
        List<string> questionsMultiples = new List<string>
        {
            "Quel est le plus petit multiple commun de 3 et 4 ?",
            "Combien y a-t-il de multiples de 7 entre 10 et 50 ?",
            "Trouvez les multiples de 5 entre 30 et 60.",
         // Ajouter d'autres questions ici...
        };

        // Liste des questions pour le chapitre Diviseurs
        List<string> questionsDiviseurs = new List<string>
        {
            "Trouvez tous les diviseurs de 24.",
            "Est-ce que 18 est divisible par 3 et 6 ?",
            "Quel est le plus grand diviseur commun de 12 et 18 ?",
         // Ajouter d'autres questions ici...
        };

        // Liste des questions pour le chapitre Grandeurs
        List<string> questionsGrandeurs = new List<string>
        {
            "Convertir 2 mètres en centimètres.",
            "Quelle est la différence entre 500 g et 1 kg ?",
            "Convertir 5 km/h en m/s.",
         // Ajouter d'autres questions ici...
        };

        // Fonction qui génère un nombre donné de questions aléatoires à partir d'une liste de questions
        public List<string> GenererQuestionsAleatoires(List<string> listeQuestions, int nombreQuestions)
        {
            List<string> questionsAleatoires = new List<string>();
            Random random = new Random();

            for (int i = 0; i < nombreQuestions; i++)
            {
                int index = random.Next(listeQuestions.Count);
                questionsAleatoires.Add(listeQuestions[index]);
            }

            return questionsAleatoires;
        }

        // Fonction qui génère une évaluation en fonction des chapitres sélectionnés
        public void GenererEvaluation(List<string> chapitresSelectionnes)
        {
            List<string> questionsEvaluation = new List<string>();

            foreach (string chapitre in chapitresSelectionnes)
            {
                switch (chapitre)
                {
                    case "Multiples":
                        questionsEvaluation.AddRange(GenererQuestionsAleatoires(questionsMultiples, 5));
                        break;
                    case "Diviseurs":
                        questionsEvaluation.AddRange(GenererQuestionsAleatoires(questionsDiviseurs, 5));
                        break;
                    case "Grandeurs":
                        questionsEvaluation.AddRange(GenererQuestionsAleatoires(questionsGrandeurs, 5));
                        break;
                    // Ajouter d'autres chapitres ici...
                    default:
                        MessageBox.Show("Erreur: chapitre inconnu");
                        return;
                }
            }

            // Afficher les questions dans une MessageBox ou autre
            MessageBox.Show("Questions: \n\n" + string.Join("\n\n", questionsEvaluation));
        }

    }
    public partial class PDF_Build : System.Windows.Forms.Form
    {
        readonly Collège collège = new Collège();


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0017:Simplifier l'initialisation des objets", Justification = "préférence visuelle")]
        private void PDF_Builder_Load(object sender, EventArgs e)
        {
            


            // Applying product license to create PDF in C#
            License lic = new License();
            lic.SetLicense("Lumino.Company.ByLumine");

            // Initialize document object generate PDF from C#
            Document document = new Document();

            // Insert page in PDF
            Page pdfPage = document.Pages.Add();

            // Create instance of Text fragment
            TextFragment textFragment = new TextFragment("Knowledgebase Text");

            // Set textual properties
            textFragment.Position = new Position(100, 600);
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray);
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Red);

            // Initialize TextBuilder object
            TextBuilder textBuilder = new TextBuilder(pdfPage);

            // Append added fragment to the PDF page
            textBuilder.AppendText(textFragment);

            // Create PDF using C#
            document.Save(collège.Doc_Name + DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss") + ".pdf");
        }
    }
}
