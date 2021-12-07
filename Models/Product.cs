 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
 //using System.Threadind.Tasks;

 namespace Store.models
 {
 	class Product
 	{
 		[Key] public int ArtProduct {get;set;}
 		public string NameProduct {get;set;}
 		public string Unit {get;set;}
 		public int Price {get;set;}

        public List <Sale> Sales { get; set; }
 	}
}