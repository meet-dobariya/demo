using System;
using System.ComponentModel.DataAnnotations;

namespace core_passport5.Models
{
    public class passport
    {
        [Key]
        public string fnum { get; set; }

        public string Applyingfor { get; set; }

        public string ifreissue { get; set; }

        public string ifchange { get; set; }

        public string txt1 { get; set; }

        public string toa14 { get; set; }

        public string topb15 { get; set; }
        public string vr16 { get; set; }

        ////[NotMapped]
        ////public HttpPostedFileBase myfile1 { get; set; }
        //public string photo { get; set; }
        ////[NotMapped]
        ////public HttpPostedFileBase myfile2 { get; set; }
        //public string sign { get; set; }

        //2nd
        public string anm { get; set; }
        public string ali22 { get; set; }
        public string cnm23 { get; set; }
        public DateTime dob24 { get; set; }

        public string pob25 { get; set; }
        public string dt25 { get; set; }
        public string st25 { get; set; }
        public string reg25 { get; set; }
        public string gen26 { get; set; }
        public string mst27 { get; set; }
        public string czn28 { get; set; }
        public string pan29 { get; set; }
        public string vt210 { get; set; }
        public string emp211 { get; set; }
        public string onm212 { get; set; }
        public string pnt213 { get; set; }
        public string edu214 { get; set; }
        public string cat215 { get; set; }
        public string vdm216 { get; set; }
        public string an217 { get; set; }

        //3th
        public string fnm31 { get; set; }
        public string mnm32 { get; set; }
        public string lnm33 { get; set; }
        public string snm34 { get; set; }
        public string fpn35 { get; set; }
        public string fnt35 { get; set; }
        public string mpn35 { get; set; }
        public string mnt35 { get; set; }

        //4th
        public string st41 { get; set; }
        public string ct42 { get; set; }
        public string dt43 { get; set; }

        public string plcstn { get; set; }
        public string st44 { get; set; }
        public string pin45 { get; set; }
        public string eml46 { get; set; }
        public string mob47 { get; set; }
        public string tel48 { get; set; }
        public string isadd42 { get; set; }




        //5th
        public string address { get; set; }
        public string mno { get; set; }
        public string tno { get; set; }
        public string mail12 { get; set; }


        //6th
        public string passno61 { get; set; }
        public DateTime doi62 { get; set; }
        public DateTime doe63 { get; set; }
        public string poi64 { get; set; }
        public string isapp62 { get; set; }

        public string filenumber { get; set; }
        public string monthandyear { get; set; }
        public string poffice { get; set; }

        //7th
        public string f711 { get; set; }
        public string f712 { get; set; }
        public string f713 { get; set; }
        public string f714 { get; set; }
        public string f715 { get; set; }
        public string f716 { get; set; }
        public string f717 { get; set; }
        public string f718 { get; set; }
        public string f719 { get; set; }
        public string f720 { get; set; }
        public string f721 { get; set; }
        public string f722 { get; set; }
        public string f723 { get; set; }
        public string f724 { get; set; }
        public string f725 { get; set; }

        //8th
        public string fee { get; set; }
        public string ddnum { get; set; }
        public string issuedate { get; set; }
        public string expirydate { get; set; }
        public string bankname { get; set; }
        public string branchname { get; set; }

        //9th
        public string ec1 { get; set; }

        //10th
        public string spot { get; set; }
        public string todaydate { get; set; }
        ////[NotMapped]
        ////public HttpPostedFileBase myfile3 { get; set; }
        //public string sign2 { get; set; }

    }
}
