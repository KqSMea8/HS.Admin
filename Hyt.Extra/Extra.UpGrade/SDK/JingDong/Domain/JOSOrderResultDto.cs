using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Extra.UpGrade.SDK.JingDong.Domain;
namespace Extra.UpGrade.SDK.JingDong.Domain
{





[Serializable]
public class JOSOrderResultDto : JdObject{


         [XmlElement("record_count")]
public  		int
  recordCount { get; set; }


         [XmlElement("purchase_order_list")]
public  		List<string>
  purchaseOrderList { get; set; }


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


         [XmlElement("result_message")]
public  		string
  resultMessage { get; set; }


}
}