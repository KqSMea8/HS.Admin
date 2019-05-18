﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hyt.DataAccess.Base;
using Hyt.Model;
using Hyt.Model.Parameter;
using Hyt.Model.Transfer;

namespace Hyt.DataAccess.QJT
{
    /// <summary>
    /// 千机团串码设置
    /// </summary>
    /// <remarks>2016-02-17 谭显锋 创建</remarks>    
    public abstract class IQJTProductImeiDao : DaoBase<IQJTProductImeiDao>
    {
        /// <summary>
        /// 添加千机团串码设置
        /// </summary>
        /// <param name="model">实体信息</param>
        /// <returns>返回新建记录的sysno</returns>       
        /// <remarks>2016-02-17 谭显锋 创建</remarks>
        public abstract int Create(QJTProductImei model);

        /// <summary>
        /// 根据商品编号判断商品是否属于千机团需要添加串码的商品
        /// </summary>
        /// <param name="productSysno">商品编号</param>
        /// <returns>是串码商品返回true,否则返回false</returns>
        /// <remarks>2016-02-18 谭显锋 创建</remarks>
        public abstract bool IsImeiProduct(int productSysno);


        /// <summary>
        /// 获取设置列表
        /// </summary>
        /// <param name="filter">筛选条件</param>
        /// <returns></returns>
        /// <remarks>2016-02-18 朱成果 创建</remarks>
        public abstract Pager<CBQJTProductImei> GetList(ParProductImeiFilter filter);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sysno">编号</param>
        /// <returns></returns>
        /// <remarks>2016-02-18 朱成果 创建</remarks>
        public abstract int Delete(int sysno);
       
    }
}