using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml.Serialization;

namespace WebApplication1
{
    public class Class1
    {
        const string xmlfilename = "XMLfilename";
        public StepCollection ReadXMLdata()
        {
            
            string filepath = HttpContext.Current.Server.MapPath("~") + System.Configuration.ConfigurationManager.AppSettings[xmlfilename]; 
            StepCollection result;
            XmlSerializer serializer = new XmlSerializer(typeof(StepCollection));
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open))            
            {
                result = (StepCollection)serializer.Deserialize((new FileStream(filepath, FileMode.Open)) );
            }

            return result;

        }
    }


}