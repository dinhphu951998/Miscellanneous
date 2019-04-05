using System;
using System.Collections.Generic;

namespace MySqlNormalization.Models
{
    public partial class Serviceitem
    {
        public Serviceitem()
        {
            Imageitem = new HashSet<Imageitem>();
            Pricedetail = new HashSet<Pricedetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceType { get; set; }
        public string Type { get; set; }
        public float? Price { get; set; }
        public string Slug { get; set; }
        public string MainImage { get; set; }
        public string Location { get; set; }
        public string PriceDescription { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public short? IsActive { get; set; }

        public virtual ICollection<Imageitem> Imageitem { get; set; }
        public virtual ICollection<Pricedetail> Pricedetail { get; set; }
    }
}
