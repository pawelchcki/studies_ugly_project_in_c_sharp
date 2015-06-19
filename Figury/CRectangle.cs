using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Figury
{
    public class CRectangle : CShape
    {
         private int x,y, width, height; 
        public CRectangle()
        {

        }
        public CRectangle(CCoordinate corner, int width, int height): this(corner, new CCoordinate(corner.X()+width, corner.Y()+height))
        {
            
        }

        public CRectangle(CCoordinate cornera, CCoordinate cornerb)
        {
            x = Math.Min(cornera.X(), cornerb.X());
            y = Math.Min(cornera.Y(), cornerb.Y());
            width = Math.Abs(cornera.X() - cornerb.X());
            height = Math.Abs(cornera.Y() - cornerb.Y());
        }
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawRectangle(p, x, y, width, height);
        }
        public override void Save(XmlNode node)
        {
            XmlDocument doc = node.OwnerDocument;
            XmlElement shapeNode = doc.CreateElement("Rectangle");
            shapeNode.SetAttribute("X", x.ToString());
            shapeNode.SetAttribute("Y", y.ToString());
            shapeNode.SetAttribute("Width", width.ToString());
            shapeNode.SetAttribute("Height", height.ToString());
            node.AppendChild(shapeNode);
        }
        public override void Load(XmlNode node)
        {
            x = int.Parse(node.Attributes["X"].Value);
            y = int.Parse(node.Attributes["Y"].Value);
            width = int.Parse(node.Attributes["Width"].Value);
            height = int.Parse(node.Attributes["Height"].Value);
        }
        public override void CreateFormPoints(CCoordinate point1, CCoordinate point2)
        {

        }

        public CCoordinate ULCoordinate() {
            return new CCoordinate();
        }

        public int Width() {
            return width;
        }
        public int Height()
        {
            return height;
        }
    }
}
