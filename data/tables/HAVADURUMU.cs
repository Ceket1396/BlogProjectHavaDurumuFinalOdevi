using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace data.tables
{
    public class HAVADURUMU
    {
           [Key]
        public string il {get;set;}
        public string tarih {get;set;}
        public int sicaklik {get;set;}
        public string havadurumu {get;set;}
        public string ruzgar {get;set;}
    
    }
}