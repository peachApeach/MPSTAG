using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPSTAG.GmtStyles
{
    public class GmtStyle
    {
        public int gmt_style_id { get; set; }
        public string gmt_style_no { get; set; }
        public string style_desc { get; set; }
        public int cust_iid { get; set; }
        public int cust_div_id { get; set; }
        public int season_id { get; set; }
        public int size_id { get; set; }
    }
}
