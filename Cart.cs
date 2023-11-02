using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Cart
    {
        public int Id { get; set; } //购物车id
        [Display(Name = "商品id")]
        public int product_id { get; set; }//商品id

        [Display(Name = "商品数量")]
        public int product_num{ get; set; } //商品数量

        [Display(Name = "商品价格")]
        [DataType(DataType.Currency)]
        public decimal product_price { get; set; }//商品价格

        [Display(Name ="用户id")]
        public int user_id { get; set; } //用户id
        [Display(Name = "创建时间")]
        [DataType(DataType.Date)]
        public DateTime createtime { get; set; } //创建时间
       

    }
}
