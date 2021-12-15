using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DesignPatternsDois.Capitulo8
{
  public class GeradorDeXml
  {
    public string GeraXml(object o) {

      XmlSerializer serializer = new XmlSerializer(o.GetType());
      StringWriter writer = new StringWriter();

      serializer.Serialize(writer, o);

      return writer.ToString();
    }
  }
}
