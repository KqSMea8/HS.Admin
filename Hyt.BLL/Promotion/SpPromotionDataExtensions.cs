﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hyt.DataAccess.Promotion;
using Hyt.Model;

namespace Hyt.BLL.Promotion
{
    /// <summary>
    /// 促销扩展数据
    /// </summary>
    /// <remarks>2014-03-05 吴文强 创建</remarks>
    public class SpPromotionDataExtensions
    {
        /// <summary>
        /// 促销在一定时间范围内使用的次数
        /// </summary>
        /// <param name="customerSysno">客户系统编号</param>
        /// <param name="startTime">查询开始时间</param>
        /// <param name="promotionSysNo">促销系统编号</param>
        /// <returns>促销使用次数</returns>
        /// <remarks>2014-03-05 吴文强 创建</remarks>
        public static int UsedPromotionNum(int customerSysno, DateTime startTime, int promotionSysNo)
        {
            return ISpPromotionExtensionsDao.Instance.UsedPromotionNum(customerSysno, startTime, promotionSysNo);
        }
    }
}