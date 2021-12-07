 using System;
using System.ComponentModel.DataAnnotations;
//using System.Collection.Generic;
using System.Linq;
// using System.Threadind.Tasks;

 namespace Store.models
 {
       class Sale
       {
              [Key] public int KodOperation { get; set; }
              public int ArtikulTovara {get;set;}
              public DateTime DateSales {get;set;}
              public int QuaSalesTov {get;set;}
              //[Required] public Otdel Sales {get;set;}
            public int ProductArt { get; set; }
            public Product Product { get; set; }
       }
}