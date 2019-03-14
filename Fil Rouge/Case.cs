using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge
{
    class Case
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }


        private bool _block;

        public bool Block
        {
            get { return _block; }
            set { _block = value; }
        }

        private char _content;

        public char Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public Case(char content, int x, int y, bool bloquant)
        {
            X = x;
            Y = y;
            Block = bloquant;
            Content = content;
        }
    }
}
