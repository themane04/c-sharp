using System;
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
            
                // - Aufgabe 1.4.1
                /*  
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

                // Aufgabe 2.6.1
                /*
                AvoidingTrees();
                AvoidingTrees();
                AvoidingTrees();
                kara.RemoveLeaf();
                */
                
                // Aufgabe 2.6.2
                // AvoidTrees();
                
                // Aufgabe 2.6.3
                // Labyrinths();
                
                // Aufgabe 2.6.4
                GoingOutsideWalls();

                // Aufgabe 2.6.5
                /*
                while (!kara.TreeFront())
                {
                    kara.RemoveLeaf();
                    LeafEater();
                }

                MessageBox.Show("Ich bin so satt, ich mag kein Blatt!");
                */
                
                // Aufgabe 2.6.6
                // InvertPattern();

                //Programmende: nächste Zeile bitte nicht löschen
                MessageBox.Show("Programmcode ausgeführt!");
        }

        //Hier können Sie eigene Methoden einfügen
        
            // Aufgabe 1.3
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

            // Aufgabe 1.4.1 
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
        
            // Aufgabe 2.6.1
        private void AvoidingTrees()
        {
            while (!kara.TreeFront())
            {
                kara.Move();
            } 
                
            if (kara.TreeFront())
            {
                AvoidTree();
            }
        }

            // Aufgabe 2.6.2
        private void AvoidTrees()
        {
            if (kara.TreeFront()) {
                kara.TurnLeft();
                kara.Move();
                kara.TurnRight();
                kara.Move();
                kara.Move();
                kara.TurnRight();
                kara.Move();
                kara.Move();
                kara.TurnLeft();
                kara.Move();
            }
            
            while (kara.TreeLeft())
            {
                kara.Move();
            }

            if (!kara.TreeLeft())
            {
                kara.TurnLeft();
                kara.Move();
                kara.TurnRight();
                AvoidTree();
            }

            if (kara.OnLeaf())
            {
                kara.RemoveLeaf();
            }
        }

            // Aufgabe 2.6.3
        private void Labyrinths()
        {
            
            while (kara.TreeLeft() | kara.TreeRight())
            {
                kara.Move();
                
                if (kara.TreeFront())
                {
                    if (kara.TreeFront() && kara.TreeRight() && kara.TreeLeft())
                    {
                        MessageBox.Show("Sackgasse!");
                    }
                    
                    do
                    {
                        if (kara.TreeRight())
                        {
                            kara.TurnLeft();    
                        }
                        else
                        {
                            kara.TurnRight();
                        }
                    } while (kara.TreeFront());
                }
            }
        }

            // Aufgabe 2.6.4
        private void GoingOutsideWalls()
        {
            while (kara.TreeRight() && !kara.TreeFront())
            {
                kara.Move();
                if (!kara.TreeRight())
                {
                    kara.TurnRight();
                    kara.Move();
                }

                if (kara.TreeFront())
                {
                    kara.TurnLeft();
                }
            }
        }

            // Aufgabe 2.6.5
        private void LeafEater()
        {
            kara.Move();
            if (!kara.OnLeaf())
            {
                kara.TurnLeft();
                kara.TurnLeft();
                kara.Move();
                kara.TurnRight();
                kara.Move();
                if (!kara.OnLeaf())
                {
                    kara.TurnLeft();
                    kara.TurnLeft();
                    kara.Move();
                    kara.Move();
                }
            }
        }
        
            // Aufgabe 2.6.6
        private void InvertPattern()
        {
            int sizeOfSquare = 9;
            
            for (int row = 0; row < sizeOfSquare; row++)
            {
                for (int col = 0; col < sizeOfSquare; col++)
                {
                    // Check if Kara is on a leaf, and invert the pattern
                    if (kara.OnLeaf())
                    {
                        kara.RemoveLeaf();
                    }
                    else
                    {
                        kara.PutLeaf();
                    }
                    // Move to the next cell, if not at the end of the row
                    if (col < sizeOfSquare - 1)
                    {
                        kara.Move();
                    }
                }
                // Move Kara to the beginning of the next row
                if (row < sizeOfSquare - 1)
                {
                    kara.TurnLeft();
                    kara.TurnLeft();
                    for (int moveBack = 0; moveBack < sizeOfSquare; moveBack++)
                    {
                        kara.Move();
                    }
                    kara.TurnLeft();
                    kara.Move();
                    kara.TurnLeft();
                }
            }
        }
    }
}
