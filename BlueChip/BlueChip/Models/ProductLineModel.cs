using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueChip.Models
{
    public class ProductLineModel
    {
        public int Id { get; set; }
        public string Named { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string pictureURL { get; set; }
    }
}