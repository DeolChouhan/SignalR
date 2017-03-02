using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SigalRApp.Models
{
    public class DevTest
    {
        [Key]
        public int ID { get; set; }
        //[Column(TypeName = "varchar(255)")]
        public string CampaignName  { get; set; }
        //[Column(TypeName = "varchar(255)")]
        public DateTime? Date { get; set; }
       //[Column(TypeName = "varchar(255)")]
        public string Conversions { get; set; }
       //[Column(TypeName = "varchar(255)")]
        public string Impressions { get; set; }

        //[Column(TypeName = "varchar(255)")]
        public string AffiliateName { get; set; }

        //[Column(TypeName = "varchar(255)")]
        public string Clicks { get; set; }

    }
}