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
            
                // Aufgabe 1.3
            // AvoidTree();
            
                /* - Aufgabe 1.4.1 
            AvoidTreeRight();
            AvoidTreeLeft();
            AvoidTreeRight();
            */
            
                // Aufgabe 1.4.2
            // AroundTree();
            
                // Aufgabe 1.4.3
            // PlantLeaf(); 
            
                // Aufgabe 2.1 und 2.4.1
                /*
                if (kara.TreeFront())
                {
                    AvoidTree();
                }
                else
                {
                    kara.Move();
                }
                */
                
                // Aufgabe 2.4.2
                /*
                kara.Move();
                LeafChecker();
                kara.Move();
                LeafChecker();
                kara.Move();
                LeafChecker();
                kara.Move();
                LeafChecker();
                kara.Move();
                LeafChecker();
                */

                //Programmende: nächste Zeile bitte nicht löschen
                MessageBox.Show("Programmcode ausgeführt!");
        }

        //Hier können Sie eigene Methoden einfügen
        
            // - Aufgabe 1.3
        private void AvoidTree()
        {
            kara.TurnLeft();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.TurnLeft();
        }
        
        private void TurnAround()
        {
            kara.TurnRight();
            kara.TurnRight();
        }

            /* Aufgabe 1.4.1 */
        private void AvoidTreeRight()
        {
            kara.TurnRight();
            kara.Move();
            kara.TurnLeft();
            kara.Move();
            kara.Move();
            kara.TurnLeft();
            kara.Move();
            kara.TurnRight();
        }

        private void AvoidTreeLeft()
        {
            kara.TurnLeft();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.TurnLeft();
        }

            // Aufgabe 1.4.2
        private void AroundTree()
        {
            AvoidTreeRight();
            kara.TurnLeft();
            kara.Move();
            kara.TurnLeft();
            kara.Move();
            kara.Move();
            kara.TurnLeft();
            kara.Move();
            kara.TurnRight();
        }

            // Aufgabe 1.4.3
        private void PlantLeaf()
        {
            AvoidTreeRight();
            kara.PutLeaf();
            kara.Move();
            TurnAround();
        }
        
            // Aufgabe 2.4.2
        private void LeafChecker()
        {
            if (kara.OnLeaf()) 
            {
                kara.RemoveLeaf(); 
            }
            else
            {
                kara.PutLeaf();
            }

        }
        
    }
}
