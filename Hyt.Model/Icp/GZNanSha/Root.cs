﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hyt.Model.Icp.GZNanSha
{
    public class Root
    {
        [XmlElement(ElementName = "Head")]
        public Head head { get; set; }
        [XmlElement(ElementName = "Body")]
        public Body body { get; set; }

    }
}