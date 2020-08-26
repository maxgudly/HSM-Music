using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSM_Music.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }
        public Genre GenreName { get; set; }
        public byte GenreId { get; set; }
    }
}