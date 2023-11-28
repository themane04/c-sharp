﻿using System;
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
                // GoingOutsideWalls();

                // Aufgabe 2.6.5
                // LeafEater();
                
                // Aufgabe 2.6.6
                // InvertLeafPattern();
                
                // Aufgabe 2.6.7
                // PlantingLeafs();
                
                // Aufgabe Datentypen 2 auf Arten dargestellt
                /*
                int i;
                i = 0;
                while (i<5)
                {
                    kara.PutLeaf();
                    kara.Move();
                    i = i + 1;
                }
                for (int i = 1; i <= 5; i++)
                {
                    kara.PutLeaf();
                    kara.Move();
                }
                */
                
                // Aufgabe 2.12
                /*
                int trees = 5;
                for (int i = 0; i < trees; i++)
                {
                    if (!kara.TreeFront())
                    {
                        kara.Move();
                        if (!kara.TreeFront())
                        {
                            kara.Move();
                        }
                        AvoidTreeLeft();
                    }
                    else
                    {
                        AvoidTreeRight();
                    }
                    
                }
                */
                
                // Aufgabe 2.13
                /*
                for (int i = 0; i <= 4; i++)
                {
                    kara.Move();
                    while (kara.TreeRight())
                    {
                        kara.PutLeaf();
                        kara.Move();
                        kara.PutLeaf();
                        kara.Move();
                        kara.PutLeaf();
                        kara.Move();
                        kara.PutLeaf();
                        kara.Move();
                    }
                    
                    if (kara.TreeLeft())
                    {
                        break;
                    }
                }
                */
                
                // Aufgabe 2.14
                /*
                while (true) {
                    kara.Move();
                    int passed_trees = 0;

                    while (kara.TreeRight()) {
                        kara.Move();
                        passed_trees++;
                    }

                    if (passed_trees > 0) {
                        kara.TurnLeft();
                        for (int i = 0; i < passed_trees; i++) {
                            kara.PutLeaf();
                            if (i < passed_trees - 1) {  
                                kara.Move();
                            }
                        }
                        TurnAround();
                        for (int i = 0; i < passed_trees - 1; i++) { 
                            kara.Move();
                        }
                        kara.TurnLeft(); 
                    }

                    if (kara.TreeLeft()) 
                    { 
                        break;
                    }
                }
                */
                
                // Aufgabe 3.1.1
                PutLeafLine(5);
                kara.TurnRight();
                PutLeafLine(7);
            
                
                // Aufgabe 3.1.2
                // DrawSquare(5, 5);
                
                // Aufgabe 3.1.3
                // DrawRectangle(5,3);
                
                // Aufgabe 3.1.4
                // DrawTriangle(7);
                
                // Aufgabe 3.1.5
                // DrawRectangleSides(6,4);
                
                // Aufgabe 3.1.6
                PutConeRow(4);
                
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
            kara.TurnLeft();
            kara.TurnLeft();
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
            while (kara.TreeRight())
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
                    if (kara.TreeFront())
                    {
                        kara.TurnLeft();
                    }
                }
            }
        }

        // Aufgabe 2.6.5
        private void LeafEater()
        {
            while (kara.OnLeaf())
            {
                if (kara.TreeFront())
                {
                    MessageBox.Show("Ich bin so satt, ich mag kein Blatt!");
                    break;
                }
                kara.RemoveLeaf();
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
                        kara.TurnRight();
                        kara.TurnRight();
                        kara.Move();
                        kara.Move();
                        if (!kara.OnLeaf())
                        {
                            kara.TurnLeft();
                            kara.Move();
                        }
                    }
                }
            }
        }

        // Aufgabe 2.6.6
        private void LeafInverter()
        {
            if (kara.OnLeaf())
            {
                kara.RemoveLeaf();
            }
            else
            {
                kara.PutLeaf();
            }
            kara.Move();
        }
        private void InvertLeafPattern()
        {
            while (true)
            {
                while (!kara.TreeFront())
                {
                    LeafInverter();
                }

                kara.TurnRight();
                if (!kara.TreeFront())
                {
                    LeafInverter();
                    kara.TurnRight();
                }
                else
                {
                    kara.PutLeaf();
                    break;
                }

                while (!kara.TreeFront())
                {
                    LeafInverter();
                }
               
                kara.TurnLeft();
                if (!kara.TreeFront())
                {
                    LeafInverter();
                    kara.TurnLeft();
                }
                else
                {
                    break;
                }
            }
        }
        
        // Aufgabe 2.6.7
        bool goRight = true;
        bool done = false;
        bool onGround = false;
        private void PutLeafWhenNeeded()
        {
            if (!onGround)
            {
                kara.PutLeaf();
            }
            onGround = !onGround;
            kara.Move();
        }
        private void WorkingOnRow()
        {
            while (!kara.TreeFront())
            {
                PutLeafWhenNeeded();
            }
        }
        private void PlantingLeafs()
        {
            while (!done)
            {
                WorkingOnRow();
                if ((goRight && kara.TreeRight()) || (!goRight && kara.TreeLeft()))
                {
                    done = true;
                }

                if (!done)
                {
                    if (goRight)
                    {
                        kara.TurnRight();
                        PutLeafWhenNeeded();
                        kara.TurnRight();
                    }
                    else
                    {
                        kara.TurnLeft();
                        PutLeafWhenNeeded();
                        kara.TurnLeft();
                    }
                }
                goRight = !goRight;
            }
        }

        // Aufgabe 3.1.1
        private void PutLeafLine(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                kara.PutLeaf();
                kara.Move();
            }
        }
        
        // Vorbereitung der Methoden für die weiteren Aufgaben
        private void Turn180()
        {
            TurnAround();
        }
        private void PutX(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                kara.PutLeaf();
                kara.Move();
            }
        }
        private void MoveX(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                kara.Move();
            }
        }
        
        // Aufgabe 3.1.2
        private void DrawSquare(int side_length, int count)
        {
            for (int i = 0; i < count; i++)
            {
                PutX(side_length);
                Turn180();
                MoveX(side_length);
                kara.TurnRight();
                kara.Move();
                kara.TurnRight();
                
            }
        }
        
        // Aufgabe 3.1.3
        private void DrawRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PutX(width);
                Turn180();
                MoveX(width);
                kara.TurnRight();
                kara.Move();
                kara.TurnRight();
            }
        }
        
        // Aufgabe 3.1.4
        private void DrawTriangle(int base_length)
        {
            do
            {
                PutX(base_length);
                Turn180();
                MoveX(base_length - 1);
                kara.TurnRight();
                kara.Move();
                kara.TurnRight();
                base_length -= 2;
            } while (base_length > 0);
        }
        
        // Aufgabe 3.1.5
        private void DrawRectangleSides(int width, int height)
        {
            for (int i = 0; i < width; i++) 
            { 
                kara.PutLeaf(); 
                kara.Move(); 
            } 
            kara.TurnLeft(); 
            kara.Move(); 
            kara.TurnLeft(); 
            kara.Move(); 

            for (int j = 0; j < height-2; j++) 
            { 
                kara.PutLeaf(); 
                kara.Move(); 
                for (int i = 0; i < width - 2; i++) 
                { 
                    kara.Move(); 
                } 
                kara.PutLeaf(); 
                if (j%2>0) 
                { 
                    kara.TurnLeft(); 
                    kara.Move(); 
                    kara.TurnLeft();  
                } 
                else 
                { 
                    kara.TurnRight(); 
                    kara.Move(); 
                    kara.TurnRight(); 

                } 
            } 
            for (int i = 0; i < width; i++) 
            { 
                kara.PutLeaf(); 
                kara.Move(); 

            } 
            kara.TurnLeft(); 
            kara.Move(); 
            kara.TurnLeft(); 
        }
        
        // Aufgabe 3.1.6
        private void PutCone(int side_length)
        {
            for (int i = 0; i < 2*side_length; i++)
            {
                if (i%2==0)
                {
                    PutConeRow(side_length);
                }
                else
                {
                    PutConeRow(side_length);
                }
                GoToNextRow(side_length);
            }
        }
        private void GoToNextRow(int cone_side)
        {
            Turn180();
            for (int i = 0; i < cone_side; i++)
            {
                kara.Move();
            }
            kara.TurnRight();
            for (int i = 0; i < cone_side; i++)
            {
                kara.Move();
            }
            kara.TurnRight();
        }
        private void PutConeRow(int count)
        {
            for (int i = 0; i < count; i++)
            {
                kara.PutLeaf();
                kara.Move();
                kara.TurnRight();
                kara.Move();
                kara.TurnLeft();
            }
        }
    }
}
