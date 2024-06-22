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
                /*
                PutLeafLine(5);
                kara.TurnRight();
                PutLeafLine(7);
                */
                
                // Aufgabe 3.1.2
                // DrawSquare(5, 5);
                
                // Aufgabe 3.1.3
                // DrawRectangle(5,3);
                
                // Aufgabe 3.1.4
                // DrawTriangle(7);
                
                // Aufgabe 3.1.5
                // DrawRectangleSides(6,4);
                
                // Aufgabe 3.1.6
                // PutCone(4);
                
                // Aufgabe 3.2.1
                //
                
                // Aufgabe 3.2.2 / 3.2.3
                // Sensonrs();

                // Aufgabe 3.2.4
                // CountingLeafs();
                
                // Aufgabe 3.3.1
                // GoToTree();

                // Aufgabe 3.3.2
                // GetLeaf();
                // kara.PutLeaf();
                
                // Aufgabe 3.3.3
                // CollectAndLeaveLeaf();
                
                // Aufgabe 3.3.4
                // CollectAndLeaveLeafMirrored();
                
                // Aufgabe 3.3.5
                // PacManRecrusive();
                
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
            if (kara.TreeFront()) 
            {
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
                    if (kara.OnLeaf())
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
                        kara.PutLeaf();
                    }

                    if (col < sizeOfSquare - 1)
                    {
                        kara.Move();
                    }
                }

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
            for (int i = 0; i < 2*side_length-1; i++) 
            { 
                if (i%2==0) 
                {
                    PutConeRow(side_length);
                } 
                else 
                { 
                    PutConeRow(side_length - 1); 
                } 
                GoToNextRow(side_length);  
            } 
        }
        private void GoToNextRow(int cone_side) 
        { 
            Turn180();
            for (int i = 0; i < cone_side - 1; i++) 
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
        private void PutConeRow(int anzahl) 
        { 
            for (int i = 0; i < anzahl; i++) 
            { 
                kara.PutLeaf(); 
                kara.Move(); 
                kara.TurnRight(); 
                kara.Move(); 
                kara.TurnLeft();  
            } 
        }
        
        // Aufgabe 3.2.1
        private bool LeafFront() 
        { 
            bool result = false; 
            if (kara.TreeFront()) 
            { 
                result = false; 
            } 
            else 
            { 
                kara.Move(); 
                if (kara.OnLeaf()) result = true; 
                Turn180(); 
                kara.Move(); 
                Turn180 (); 
            } 
            return result; 
        }//Ende LeafFront 

        private bool LeafLeft() 
        { 
            bool result = false; 
            kara.TurnLeft(); 
            if(kara.TreeFront())
            {
                result = false; 
                kara.TurnRight(); 
            } 
            else 
            {
                kara.Move(); 
                if (kara.OnLeaf()) result = true; 
                Turn180 (); 
                kara.Move();
                kara.TurnLeft(); 
            } 
            return result; 
        }
        private bool LeafRight() 
        { 
            bool result = false; 
            kara.TurnRight(); 
            if (kara.TreeFront()) 
            { 
                result = false; 
                kara.TurnLeft(); 
            } 
            else 
            { 
                kara.Move(); 
                if (kara.OnLeaf()) result = true; 
                Turn180 (); 
                kara.Move(); 
                kara.TurnRight(); 
            } 
            return result; 
        }
        
        // Aufgabe 3.2.2 / Aufgabe 3.2.3
        private void Sensonrs() 
        {
            int leaf_count=0;
            for (int i = 0; i < 20; i++) 
            { 
                if(leaf_count==13) 
                { 
                    MessageBox.Show("Hi, wie geht's?"); 
                } 
                if (kara.OnLeaf()) 
                { 
                    kara.RemoveLeaf(); 
                    leaf_count += 1; 
                    if (LeafRight()) 
                    { 
                        kara.TurnRight(); 
                    } 
                    else if(LeafLeft()) 
                    { 
                        kara.TurnLeft(); 
                    } 
                } 
                kara.Move(); 
            } 
        }
        
        // Aufgabe 3.2.4
        private void CountingLeafs() 
        { 
            while(LeafLeft()) 
            { 
                int leaf_count; 
                kara.TurnLeft(); 
                leaf_count=CountTrailLength(); 
                PutX(leaf_count); 
                Turn180(); 
                MoveX(leaf_count); 
                kara.TurnRight(); 
                kara.Move(); 

            } 
        } 
        private int CountTrailLength() 
        { 
            int leaf_cout = 0; 
            kara.Move(); 
            while (kara.OnLeaf()) 
            { 
                leaf_cout += 1; 
                kara.Move(); 
            } 
            Turn180(); 
            for (int i = 0; i < leaf_cout+1; i++) 
            { 
                kara.Move();  
            } 
            return leaf_cout; 
        }
        
        // Aufabe 3.3.1
        private void GoToTree() 
        { 
            if (!kara.TreeFront()) 
            { 
                if(kara.OnLeaf()) 
                { 
                    kara.RemoveLeaf(); 
                } 
                kara.Move(); 
                GoToTree(); 
            } 
            else 
            { 
                Turn180(); 
            } 
        }
        
        // Aufgabe 3.3.2
        private void GetLeaf() 
        { 
            if(kara.OnLeaf()) 
            { 
                Turn180(); 
                kara.RemoveLeaf(); 
            } 
            else 
            { 
                kara.Move(); 
                GetLeaf(); 
                kara.Move(); 
            } 
        }
        
        // Aufgabe 3.3.3
        private void CollectAndLeaveLeaf() 
        { 
            if (!kara.TreeFront()) 
            { 
                bool is_leaf=false; 
                if (kara.OnLeaf()) is_leaf = true; 
                if(is_leaf) 
                { 
                    kara.RemoveLeaf(); 
                } 
                kara.Move(); 
                CollectAndLeaveLeaf(); 
                kara.Move(); 
                if(is_leaf) 
                { 
                    kara.PutLeaf(); 
                } 
            } 
            else 
            { 
                Turn180();
            } 
        }
        
        // Aufgabe 3.3.4
        private void CollectAndLeaveLeafMirrored() 
        { 
            if (!kara.TreeFront()) 
            { 
                bool is_leaf = false; 
                if (kara.OnLeaf()) is_leaf = true; 
                if (is_leaf) 
                { 
                    kara.RemoveLeaf(); 
                } 
                kara.Move(); 
                CollectAndLeaveLeafMirrored(); 
                kara.Move(); 
                if (is_leaf) 
                { 
                    kara.PutLeaf(); 
                } 
            } 
            else 
            { 
                bool istBlatt = false; 
                if (kara.OnLeaf()) istBlatt = true; 
                if (istBlatt) 
                { 
                    kara.RemoveLeaf(); 
                } 
                AroundTree(); 
                if (istBlatt) 
                { 
                    kara.PutLeaf(); 
                } 
            } 
        }
        private void PacManRecrusive() 
        { 
            char direction = 'f'; 
            if (kara.TreeFront()) 
            { 
                kara.RemoveLeaf(); 
                Turn180(); 
                MessageBox.Show("Ich bin so satt!"); 
                kara.PutLeaf(); 
                switch (direction) 
                { 
                    case 'f': 
                    { 
                        kara.Move(); 
                        break; 
                    } 
                    
                    case 'l': 
                    { 
                        kara.TurnRight(); 
                        kara.Move(); 
                        break; 
                    } 
                    default: 
                    { 
                        kara.TurnLeft(); 
                        kara.Move(); 
                        break; 
                    } 
                } 
            } 
            else 
            { 
                kara.RemoveLeaf(); 
                if (LeafFront()) 
                { 
                    kara.Move(); 
                } 
                else if (LeafLeft()) 
                { 
                    direction = 'l'; 
                    kara.TurnLeft(); 
                    kara.Move(); 
                } 
                else if (LeafRight()) 
                { 
                    direction = 'r'; 
                    kara.TurnRight(); 
                    kara.Move(); 
                } 
                PacManRecrusive(); 
                kara.PutLeaf(); 
                switch (direction) 
                { 
                    case 'f': 
                    { 
                        kara.Move(); 
                        break; 
                    } 
                    case 'l': 
                    { 
                        kara.TurnRight(); 
                        kara.Move(); 
                        break; 
                    } 
                    default: 
                    { 
                        kara.TurnLeft(); 
                        kara.Move(); 
                        break; 
                    } 
                } 
            } 
        }
    }
}
