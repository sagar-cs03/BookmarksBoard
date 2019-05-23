using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pinboard.Models
{
    public class Bookmark
    {
        [Display(Name = "BookmarkID")]
        [Key]
        public string BookmarkID { get; set; }

        [ForeignKey("User")]
        public int UserFk { get; set; }

        public string URL { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Tags { get; set; }

        public Boolean IsReadLater { get; set; }

        public Boolean IsStarred { get; set; }

        public Boolean IsTagged { get; set; }

        [Display(Name ="Date Added")]
        public DateTime DateAndTimeCreated { get; set; }

    }
}
