using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fil_Rouge
{
    class Map
    {
        private Case[,] _grid;

        public Case[,] Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        private string _nomFichier;

        public string NomFichier
        {
            get { return _nomFichier; }
            set { _nomFichier = value; }
        }

        public Map(string nomfichier)
        {
            int  x = 0, y = 0;
            NomFichier = nomfichier;
            char lettre = ' ';
            StreamReader read = new StreamReader(this.NomFichier);
            while (read.Peek() >= 0) 
            {
                
                lettre = (char)read.Read();
                switch (lettre)
                {
                    case '#':
                        Grid[x,y] = new Case('#',true);
                        break;
                    default:
                        break;

                }
                x++;

            }
            read.Close();
        }
    }
    
}
