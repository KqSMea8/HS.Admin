using System;
using System.Xml.Serialization;
using Extra.UpGrade.SDK.Yihaodian.Object;
using Extra.UpGrade.SDK.Yihaodian.Object.User;


namespace Extra.UpGrade.SDK.Yihaodian.Response
{
	/// <summary>
	/// 用户信息回传
	/// </summary>
	public class UserInfoUpdateResponse 
		: YhdResponse 
	{
		/**更新成功记录数 */
		[XmlElement("updateCount")]
			public int?  UpdateCount{ get; set; }

		/**更新失败记录数 */
		[XmlElement("errorCount")]
			public int?  ErrorCount{ get; set; }

		/**用户Ticket信息 */
		[XmlElement("ticket")]
		public Ticket  Ticket{ get; set; }

		/**错误信息列表 */
		[XmlElement("errInfoList")]
		public ErrDetailInfoList  ErrInfoList{ get; set; }

	}
}