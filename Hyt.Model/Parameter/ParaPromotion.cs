﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyt.Model.Parameter
{
    /// <summary>
    /// 促销筛选字段
    /// </summary>
    /// <remarks>2013-08-21 黄志勇 创建</remarks>
    public struct ParaPromotion
    {
        private int _pageSize;
        private DateTime? _endTime;

        /// <summary>
        /// 当前页
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize
        {
            get
            {
                if (_pageSize == 0)
                {
                    _pageSize = 10;
                }
                return _pageSize;
            }
            set { _pageSize = value; }
        }

        /// <summary>
        /// 促销类型
        /// </summary>
        public int? PromotionType { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 促销名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否使用促销代码
        /// </summary>
        public int? IsUsePromotionCode { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime
        {
            get
            {
                //查询日期上限+1
                return _endTime == null ? (DateTime?)null : _endTime.Value.AddDays(1);
            }
            set { _endTime = value; }
        }
        /// <summary>
        /// 是否促销叠加列表
        /// </summary>
        public int IsOverlay { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? ExpiredTime { get; set; }

        /// <summary>
        /// 使用平台
        /// </summary>
        /// <remarks>2014-01-09 朱家宏 添加</remarks>
        public int? UsePlatform { get; set; }
        /// <summary>
        /// 网站使用
        /// </summary>
        /// <remarks>2014-01-09 朱家宏 添加</remarks>
        public int? WebPlatform { get; set; }
        /// <summary>
        /// 门店使用
        /// </summary>
        /// <remarks>2014-01-09 朱家宏 添加</remarks>
        public int? ShopPlatform { get; set; }
        /// <summary>
        /// 手机商城使用
        /// </summary>
        /// <remarks>2014-01-09 朱家宏 添加</remarks>
        public int? MallAppPlatform { get; set; }
        /// <summary>
        /// 物流App使用
        /// </summary>
        public int? LogisticsAppPlatform { get; set; }
    }
}