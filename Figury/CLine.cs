using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Figury
{
    public class CLine : CShape
    {
        private CCoordinate m_End, m_Start;
        public CLine()
        {

        }
        public CLine(CCoordinate start, CCoordinate end)
        {
            m_End = end;
            m_Start = start;
        }
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, m_Start.X(), m_Start.Y(), m_End.X(), m_End.Y());
        }
        public override void Save(XmlNode node)
        {
            XmlDocument doc = node.OwnerDocument;
            XmlElement shapeNode = doc.CreateElement("Line");
            shapeNode.SetAttribute("StartX", m_Start.X().ToString());
            shapeNode.SetAttribute("StartY", m_Start.Y().ToString());
            shapeNode.SetAttribute("EndX", m_End.X().ToString());
            shapeNode.SetAttribute("EndY", m_End.Y().ToString());
            node.AppendChild(shapeNode);
        }
        public override void Load(XmlNode node)
        {
            int x = int.Parse(node.Attributes["StartX"].Value);
            int y = int.Parse(node.Attributes["StartY"].Value);
            m_Start = new CCoordinate(x, y);
            x = int.Parse(node.Attributes["EndX"].Value);
            y = int.Parse(node.Attributes["EndY"].Value);
            m_End = new CCoordinate(x, y);
        }
        public override void CreateFormPoints(CCoordinate point1, CCoordinate point2)
        {
            m_Start = point1;
            m_End = point2;
        }

        public CCoordinate End() {
            return m_End;
        }
        public CCoordinate Start()
        {
            return m_Start;
        }
        
    }
}
