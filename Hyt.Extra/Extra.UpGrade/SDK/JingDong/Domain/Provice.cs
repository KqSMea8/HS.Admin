using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Extra.UpGrade.SDK.JingDong.Domain;
namespace Extra.UpGrade.SDK.JingDong.Domain
{





[Serializable]
public class Provice : JdObject{


         [XmlElement("label")]
public  		string
  label { get; set; }


         [XmlElement("value")]
public  		string
  value { get; set; }


}
}