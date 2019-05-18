﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyt.Model.Parameter
{
    public class ParaReceiveProductFilter
    {
        /// <summary>
        /// 会员名称
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 分销商
        /// </summary>
        public int DealerSysNo { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 分销商名称
        /// </summary>
        public string DealerName { get; set; }
    }
}