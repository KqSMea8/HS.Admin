using System;
using System.Xml.Serialization;
using Extra.UpGrade.SDK.Yihaodian.Object;
using Extra.UpGrade.SDK.Yihaodian.Object.Delivery;


namespace Extra.UpGrade.SDK.Yihaodian.Response
{
	/// <summary>
	/// 批量查询物流订单,返回详细信息(兼容淘宝)
	/// </summary>
	public class LogisticsOrdersDetailGetResponse 
		: YhdResponse 
	{
		/**获取的物流订单详情列表.返回的Shipping包含的具体信息为入参fields请求的字段信息. */
		[XmlElement("shippings")]
		public ShippingList  Shippings{ get; set; }

		/**搜索到的物流订单列表总数 */
		[XmlElement("total_results")]
			public long?  Total_results{ get; set; }

		/**错误码 */
		[XmlElement("error_code")]
			public string  Error_code{ get; set; }

		/**子错误描述 */
		[XmlElement("sub_msg")]
			public string  Sub_msg{ get; set; }

		/**错误描述 */
		[XmlElement("msg")]
			public string  Msg{ get; set; }

		/**子错误码 */
		[XmlElement("sub_code")]
			public string  Sub_code{ get; set; }

	}
}