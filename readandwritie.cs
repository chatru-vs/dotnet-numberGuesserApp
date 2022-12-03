using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Xml;


namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
//Load the the document with the last book node.
            XmlTextWriter textWriter = new XmlTextWriter("c:\\Users\\sarita\\RiderProjects\\xmlreadwrite\\xmlreadwrite\\new.xml", null);
            // Opens the document
            textWriter.WriteStartDocument();
            // Write comments
            textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");
            // Write first element
            textWriter.WriteStartElement("Student");
            textWriter.WriteStartElement("r", "RECORD", "urn:record");
            // Write next element
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Student");
            textWriter.WriteString("City");
            textWriter.WriteEndElement();
            // Write one more element
            textWriter.WriteStartElement("Address", "");
            textWriter.WriteString("Colony");
            textWriter.WriteEndElement();
            // WriteChars
            char[] ch = new char[3];
            ch[0] = 'a';
            ch[1] = 'r';
            ch[2] = 'c';
            textWriter.WriteStartElement("Char");
            textWriter.WriteChars(ch, 0, ch.Length);
            textWriter.WriteEndElement();
            // Ends the document.
            textWriter.WriteEndDocument();
            // close writer
            textWriter.Close();
        }
    }
}
