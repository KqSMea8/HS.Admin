
using System;
using System.ComponentModel;
namespace Hyt.Model
{
    /// <summary>
	/// 
	/// </summary>
    /// <remarks>
    /// 2013-08-27 杨浩 T4生成
    /// </remarks>
	[Serializable]
	public partial class BsDeliveryPayment
	{
	  		/// <summary>
		/// 系统编号
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("系统编号")]
		public int SysNo { get; set; }
 		/// <summary>
		/// 系统编号
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("系统编号")]
		public int PaymentSysNo { get; set; }
 		/// <summary>
		/// 系统编号
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("系统编号")]
		public int DeliverySysNo { get; set; }
 		/// <summary>
		/// 创建人
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("创建人")]
		public int CreatedBy { get; set; }
 		/// <summary>
		/// 创建时间
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("创建时间")]
		public DateTime CreatedDate { get; set; }
 		/// <summary>
		/// 最后更新人
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("最后更新人")]
		public int LastUpdateBy { get; set; }
 		/// <summary>
		/// 最后更新时间
		/// </summary>
        /// <remarks>2013-08-27 杨浩 T4生成</remarks>
		[Description("最后更新时间")]
		public DateTime LastUpdateDate { get; set; }
 	}
}

	