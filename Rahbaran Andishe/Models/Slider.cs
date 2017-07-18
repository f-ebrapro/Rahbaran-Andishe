using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rahbaran_Andishe.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا توضیحات راوارد کنید")]
        public string Description { get; set; }

        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا عکس راوارد کنید")]
        public string Img { get; set; }
    }
}