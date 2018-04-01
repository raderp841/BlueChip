using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueChip.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Named { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Price { get; set; }
        public int ProductLineId { get; set; }
        public string PictureURL { get; set; }
    }
}