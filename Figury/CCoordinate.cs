using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Figury
{
    public class CCoordinate
    {
        private int m_X, m_Y;
        public CCoordinate(){
        
        }
        public CCoordinate(int x, int y)
        {
            m_X = x;
            m_Y = y;
        }
        public int X() {
            return m_X;
        }

        public int Y()
        {
            return m_Y;
        }
    }
}
