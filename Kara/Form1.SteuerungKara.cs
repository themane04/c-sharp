using System.Windows.Forms;
// tetetetetet
namespace KaraProjekt
{
    //cKara Version 1.1 by Barbara Bielawski
    public partial class Form1 : Form
    {
        private void Main(string args)
        {
            //Hier die Anweisungen notieren
            AvoidTree();
            TurnAround();
            AvoidTree();
            TurnAround();
            //Programmende: nächste Zeile bitte nicht löschen
            MessageBox.Show("Programmcode ausgeführt!");
        }

        //Hier können Sie eigene Methoden einfügen
        private void AvoidTree()
        {
            kara.TurnLeft();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.Move();
        }

        private void TurnAround()
        {
            kara.TurnLeft();
            kara.TurnLeft();
        }
    }
}
