using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Figury
{
    public class CDrawing
    {
        private List<CShape>m_Shapes = new List<CShape>(); 

        public CDrawing(){
        
        }
        public void Draw(Graphics g, Pen p)
        {
            g.Clear(Color.White);
            foreach (CShape shape in m_Shapes)
            {
                shape.Draw(g, p);
            }
        }
        public void AddShape(CShape shape) {
            m_Shapes.Add(shape);
        }
        public void Save(String filename) {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "", "yes");
            doc.PrependChild(dec);
            XmlElement rootNode=doc.CreateElement("Drawing");
            doc.AppendChild(rootNode);
            foreach (CShape shape in m_Shapes)
            {
                shape.Save(rootNode);
            }
            doc.Save(filename);
        }
        public bool Load(String filename)
        {
            Dictionary<String, Type> typeMap = new Dictionary<string, Type>();
            typeMap["Circle"] = typeof(CCircle);
            typeMap["Line"] = typeof(CLine);
            typeMap["Rectangle"] = typeof(CRectangle);
            

            XmlDocument doc=new XmlDocument();
            XmlNode rootNode;
            doc.Load(filename);
            rootNode=doc.ChildNodes[1];
            if (rootNode.Name != "Drawing")
                return false;
            m_Shapes.Clear();
            foreach (XmlNode shape in rootNode.ChildNodes)
            {   
                CShape t_shape;
                if (typeMap.ContainsKey(shape.Name))
                {
                    t_shape = (CShape)Activator.CreateInstance(typeMap[shape.Name]);
                    t_shape.Load(shape);
                    m_Shapes.Add(t_shape);
                }
//                foreach (CShape shape in m_Shapes)
            
                //shape.Save(rootNode);
            }
            return true;
        }
    }
}
