using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Extra.UpGrade.SDK.JingDong.Domain;
			namespace Extra.UpGrade.SDK.JingDong.Response
{





public class PopAfterSaleReplyWorkOrderResponse : JdResponse{


         [XmlElement("work_order_response")]
public  		string
  workOrderResponse { get; set; }


}
}