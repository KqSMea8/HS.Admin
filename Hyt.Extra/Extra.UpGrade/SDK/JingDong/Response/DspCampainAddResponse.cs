using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Extra.UpGrade.SDK.JingDong.Domain;
			namespace Extra.UpGrade.SDK.JingDong.Response
{





public class DspCampainAddResponse : JdResponse{


         [XmlElement("addcampain_result")]
public  		string
  addcampainResult { get; set; }


}
}