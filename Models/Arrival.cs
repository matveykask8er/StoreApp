 using System;
using System.ComponentModel.DataAnnotations;
//using System.Collection.Generic;
using System.Linq;
 //using System.Threadind.Tasks;

 namespace Store.models
 {
 	class Arrival
 	{
 		[Key] public int �odeArr {get;set;}
 		public int �odeModel {get;set;}
 		public DateTime BateArrModTov {get;set;}
 		public int Quantity {get;set;}
        public string Getter {get;set;}

        [Required] public Product Arrivals { get; set; }
 	}
}