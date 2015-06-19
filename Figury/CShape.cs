using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Drawing;

namespace Figury
{
    public abstract class CShape
    {
        private CCoordinate m_Coordinate;
        public CShape() { }
        public virtual void Draw(Graphics g, Pen p){}

        public virtual void Save(XmlNode filename) { }
        public virtual void Load(XmlNode filename) { }
        public virtual void CreateFormPoints(CCoordinate point1, CCoordinate point2) { }
    }
}
