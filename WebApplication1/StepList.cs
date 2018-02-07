using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebApplication1
{
   // [XmlRoot("StepList")]
    public class StepList
    {
        [XmlElement("Step")]
        public List<Step> Steps { get; set; }
    }
}