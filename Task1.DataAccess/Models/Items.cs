using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task1.DataAccess.Models
{
    public class Items
    {
        [Key]
        public int? ItemId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]        
        public string Description { get; set; }

        [Required(ErrorMessage = "Unit type is required")]
        [StringLength(50)]
        [Display(Name = "Unit Type")]
        [Column("Unit Type")]
        public string UnitType { get; set; }

        [Required(ErrorMessage = "Rate is required")]
        public int Rate { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

    }
}
