using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Tudien.DTO;

namespace Tudien.BLL
{
    public class DictionaryBLL
    {
        XmlDocument doc = new XmlDocument();
        XmlNode root;
        string fileName = "data.xml";
        public DictionaryBLL() {
            doc.Load(fileName);
            root = doc.DocumentElement.SelectSingleNode("Item");
           
        }
        public void Them(DictionaryData wordThem)
        {
            XmlElement Dic = doc.CreateElement("DictionaryData");
            XmlElement Key = doc.CreateElement("Key");
            Key.InnerText= wordThem.Key; 
            
            XmlElement Meaning = doc.CreateElement("Meaning");
            Meaning.InnerText = wordThem.Meaning;

            XmlElement Explanation = doc.CreateElement("Explanation");
            Explanation.InnerText = wordThem.Explanation;

            Dic.AppendChild(Key);
            Dic.AppendChild(Meaning);
            Dic.AppendChild(Explanation);
            root.AppendChild(Dic);

            doc.Save(fileName);

        }
        public void Xoa(DictionaryData wordCu)
        {
            XmlNode dicCu = root.SelectSingleNode("DictionaryData[Key ='" + wordCu.Key + "']");
            if(wordCu.Key != "")
            {
                root.RemoveChild(dicCu);
                doc.Save(fileName);
            }
        }
    }
}
