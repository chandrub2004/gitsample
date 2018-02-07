using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebApplication1
{
    [XmlRoot("StepCollection")]
    public class StepCollection
    {
         [XmlElement("StepList")]
        public List<StepList> Steps { get; set; }
       
    }
}