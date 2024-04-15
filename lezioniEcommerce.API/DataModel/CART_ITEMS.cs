﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using lezioniEcommerce.API.Controllers.DataModel;

namespace lezioniEcommerce.API.DataModel
{
    public class CART_ITEMS
    {
        [Key]
        [Column(TypeName = "int")]
        public int CART_ITEM_ID { get; set; }

        [Column(TypeName = "int")]
        public int CART_QUANTITY { get; set; }
        //-----------------------------------------

        [Required]
        [Column(TypeName = "int")]
        public int CART_ID { get; set; }

        [ForeignKey("CART_ID")]
        public CARTS CART { get; set; }
        //----------------------------------------

        [Required]
        [Column(TypeName = "int")]
        public int PRODUCT_ID { get; set; }

        [ForeignKey("PRODUCT_ID")]
        public PRODUCTS PRODUCT { get; set; }
    }
}
