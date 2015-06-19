using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Figury
{
    public class CCircle : CShape
    {
        private CCoordinate center;
        private int radius;
        public CCircle()
        {

        }
        public CCircle(CCoordinate center, int radius)
        {
            this.center = new CCoordinate(center.X()-radius/2, center.Y()-radius/2);
            this.radius = radius;
        }

        public CCircle(CCoordinate center, CCoordinate drop) : this(center, Convert.ToInt32(2*Math.Sqrt(Math.Pow(Math.Abs(center.X() - drop.X()), 2) + Math.Pow(Math.Abs(center.Y() - drop.Y()), 2))))
        {
               
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawEllipse(p, center.X(), center.Y(), radius, radius);
        }
        public override void Save(XmlNode node)
        {
            XmlDocument doc=node.OwnerDocument;
            XmlElement shapeNode=doc.CreateElement("Circle");
            shapeNode.SetAttribute("X", center.X().ToString());
            shapeNode.SetAttribute("Y", center.Y().ToString());
            shapeNode.SetAttribute("radius", radius.ToString());
            node.AppendChild(shapeNode);
        }
        public override void Load(XmlNode node)
        {
            int x = int.Parse(node.Attributes["X"].Value);
            int y = int.Parse(node.Attributes["Y"].Value);
            this.radius = int.Parse(node.Attributes["radius"].Value);
            this.center = new CCoordinate(x, y);
        }
        public override void CreateFormPoints(CCoordinate point1, CCoordinate point2)
        {
        }

        public CCoordinate Center() {
            return new CCoordinate();
        }
        public int Radius()
        {
            return radius;
        }
    }
}
