using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rahbaran_Andishe.Models
{
    public class Form
    {
        public int Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام خود راوارد کنید")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام خانوادگی خود را وارد کنید")]
        public string Family { get; set; }

        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "لطفا جنسیت خود را مشخص کنید")]
        public string Generic { get; set; }

        [Display(Name = "نام شرکت | فروشگاه")]
        [Required(ErrorMessage = "لطفا نام شرکت | فروشگاه خود را مشخص کنید")]
        public string CompanyName { get; set; }

        [Display(Name = "صنف")]
        [Required(ErrorMessage = "لطفا صنعت خود را مشخص کنید")]
        public string Industry { get; set; }

        [Display(Name = "سمت")]
        [Required(ErrorMessage = "لطفا سمت خود را مشخص کنید")]
        public string Education { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا شماره موبایل خود را مشخص کنید")]
        public int PhoneNumber { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل خود را مشخص کنید")]
        public string Email { get; set; }

        
        [ForeignKey("CityID")]
        public virtual CityCategory CityCategory { get; set; }

        [Display(Name = "شهر")]
        [Required(ErrorMessage = "لطفا شهر خود را مشخص کنید")]
        public int CityID { get; set; }


        [ForeignKey("OtherfieldID")]
        public virtual OtherfieldsCategory OtherfieldsCategory { get; set; }

        [Display(Name = "درخواست مشاوره در زمینه های دیگر نیز دارم")]
        public int OtherfieldID { get; set; }
    }
}