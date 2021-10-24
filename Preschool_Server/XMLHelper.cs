using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Preschool_Server.DBManager;

namespace Preschool_Server
{
    static class XMLHelper
    {
        static public void GetQueryTokensFromXML(XElement message, ref string table_name, ref List<string> selects, ref List<List<object>> wheres)
        {
            try
            {
                foreach (XElement child in message.Descendants("SELECT").Elements())
                {
                    selects.Add(child.Value);
                }
                table_name = message.Descendants("FROM").Elements().ElementAt(0).Value;
                foreach (XElement child in message.Descendants("WHERE").Elements())
                {
                    List<object> temp = new List<object>();
                    temp.Add(child.Name.ToString());
                    temp.Add(ConvertTypeByColumnType(table_name, child.Name.ToString(), child.Value.ToString()));
                    wheres.Add(temp);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PARSING ERROR.");
            }
        }
        static public XElement ConvertToXML(IDataReader reader, string table_name)
        {
            XElement resultNode = new XElement("RESULT");
            while (reader.Read())
            {
                XElement row = new XElement(table_name);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(new XElement(reader.GetName(i), reader.GetValue(i)));
                }
                resultNode.Add(row);
            }
            return resultNode;
        }
    }
}
