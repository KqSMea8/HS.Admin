﻿namespace Hyt.Model.WorkflowStatus
{
    /// <summary>
    /// 供应链状态
    /// </summary>
    /// <remarks> 2016-05-20 刘伟豪 创建</remarks>
    public class SupplyStatus
    {
        public enum 海豚接口返回状态
        {
            响应成功 = 20000,
            参数不全 = 10001,
            请求超时 = 10002,
            令牌无效 = 10003,
            验证失败 = 10004,
            帐号冻结 = 30001,
            接口无效 = 30002,
            响应无效 = 40001,
            推送端校验失败 = 40002,
            网站生成销售订单部分失败 = 40003,
            网站生成销售订单全部失败 = 40004,
            网站推送过来的参数不全 = 40005,
            数据库更新失败 = 40006,
            网站没有找到对应的方法 = 40007,
            网站取消订单全部失败 = 40008,
            网站取消订单部分失败 = 40009,
            网站没有接收到销售订单数据 = 40010,
            数据更新失败 = 40011,
            分销商推送过来的订单数据为空 = 40012,
            没有订单明细 = 40013,
            订单明细没有SKU信息 = 40014,
            网站创建单个订单失败 = 40015,
            分销商名称为空 = 40016,
            订单号为空 = 40017,
            订单不存在 = 40018,
            暂无物流信息 = 40019,
            库存信息为空 = 40020,
            订单没有明细 = 40024,
            订单格式不对不是二维数组 = 40025,
            商品信息不存在 = 40029,
            一次查询的sku数量不能超过10 = 40030,
        }
    }
}