namespace Yu.Client.WF.Models
{
    /*
     Id = new DataGridViewCheckBoxColumn();
                CountRang = new DataGridViewTextBoxColumn();
                Surplus = new DataGridViewTextBoxColumn();
                OrderType = new DataGridViewTextBoxColumn();
                OrderUsder = new DataGridViewTextBoxColumn();
                Addtime = new DataGridViewTextBoxColumn();
                OrderState = new DataGridViewTextBoxColumn();
                FinishTime = new DataGridViewTextBoxColumn();
     */
    public class EntrustModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 订单类型 （0：求购    1：出售  ）
        /// </summary>
        public int OrderType { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        public int ProductID { get; set; }
        /// <summary>
        /// 出单用户
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 最大数量
        /// </summary>
        public decimal MaxCount { get; set; }
        /// <summary>
        /// 最小数量
        /// </summary>
        public decimal MinCount { get; set; }
        /// <summary>
        /// 剩余数量 默认=MaxSL
        /// </summary>
        public decimal Surplus { get; set; }

        /// <summary>
        /// 支付平台退款订单编号
        /// </summary>
        public string AppOrderID { get; set; }

        /// <summary>
        /// （0：无状态   1：待审核   2：审核成功；发放款项）出售成功后需要后台财务进行审核；购买单是无需审核的；当取消订单的时候此字段值变成1
        /// </summary>
        public int IsApproved { get; set; } = 0;
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? ApprovedTime { get; set; }
        /// <summary>
        /// 次订单是否交易完成 （0：未完成  1：完成    2：取消订单
        /// </summary>
        public int IsFinish { get; set; }
        /// <summary>
        /// 最后交易时间
        /// </summary>
        public DateTime? FinishTime { get; set; }


        /// <summary>
        /// 我方退款id
        /// </summary>
        public string RefundNo { get; set; }
        public decimal RefundAmount { get; set; }
    }
}
