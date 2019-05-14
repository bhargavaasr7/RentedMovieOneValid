using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace RentedMovieOneValid.Models
{
    public class Movie
    {
        public int id { get; set; }


        [Required(ErrorMessage="Name Required")]
        [StringLength(50)]
        [Display(Name ="Movie_Name")]
        public string MovieName { get; set; }


        [Required(ErrorMessage = "Release_Date Required")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        [Required(ErrorMessage = "Add_Date Required")]
        [DataType(DataType.Date)]
        public DateTime Adddate { get; set; }


        [Required]
        [Display(Name ="Stock_Available")]
        public int Stock_Available { get; set; }


        //create refernce
        public Genre Genre { get; set; }


        //add reference
        [Display(Name = "GenreId")]
        public int GenreId { get; set; }
    }
}
