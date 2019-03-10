using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Document
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "编者姓名")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "新闻日期")]
        public DateTime Time { get; set; }
        [Required]
        [Display(Name = "新闻标题")]
        public string News_BiaoTi { get; set; }
        [Required]
        [Display(Name = "新闻类别")]
        public string News_LeiBie { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "新闻内容")]
        public string News_NeiRong { get; set; }
    }
}