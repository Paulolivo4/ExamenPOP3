using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace ExamenPOP3.Models
{
    public class SavedCocktail
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Instructions { get; set; }
        public string ImageUrl { get; set; }
    }
}
