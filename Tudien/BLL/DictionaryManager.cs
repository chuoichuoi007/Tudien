using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tudien.DTO;

namespace Tudien.BLL
{
    public class DictionaryManager
    {
        private DictionaryItem items;
        private string filePath;

        public DictionaryItem Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public DictionaryManager()
        {
            filePath = "data.xml";
            Items = (DictionaryItem)DeserializeFromXML(filePath);
            
        }

        public void LoadDataToCombobox(ComboBox combo)
        {
            combo.DataSource = Items.Item;
        }
        public void SerializeToXML(object data, string filePath)
        {

        }
        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            object result =  sr.Deserialize(fs);
            fs.Flush();
            fs.Close();
            return result;
        }


    } 
}
