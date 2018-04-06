using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueChip.Models
{
    public class UserInfoProductsModel
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public int ProductsId { get; set; }
    }
}