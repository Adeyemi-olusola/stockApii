using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class Comment
    {
        public int? StockId {get;set;}
        public int Id {get;set;}
        public string Content {get;set;}  = string.Empty;

        public DateTime CreatedOn {get;set;} = DateTime.Now;

        public string? Title {get;set;} = string.Empty;
        public Stock? Stock {get;set;}
        
    }
}