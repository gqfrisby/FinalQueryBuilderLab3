using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder2.Models
{
    internal class BannedGame : IClassModel
    {
        public int Id { get ; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; }
        public string Details { get; set; }

        public BannedGame ()
        {

        }
        public BannedGame(int id, string title, string series, string country, string details)
        {
            Id = id;
            Title = title;
            Series = series;
            Country = country;
            Details = details;
        }

        public string toString()
        {
            string info = "";
            info = ("ID: " + this.Id + "\n" + "Title: " + this.Title + "\n" + "Series: " + this.Series + "\n" + "Country: " + this.Country + "\n" + "Details: " + this.Details);
            return info;
        }
    }
}
