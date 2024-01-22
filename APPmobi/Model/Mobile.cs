using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APPmobi.Model
{
    public class Mobile
    {
        [Key]
        public String AId {  get; set; }
        public String ABrand { get; set; }

        public String AModel { get; set; }
        public String AStock { get; set; }
        public String APrice {  get; set; }
        
        public Mobile(String AId, String ABrand)
        {
            this.AId = AId;
            this.ABrand = ABrand;
            this.AModel = AModel;
            this.AStock = AStock;
            this.APrice = APrice;


        }
    }
}
