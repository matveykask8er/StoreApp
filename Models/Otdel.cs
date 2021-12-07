 using System;
using System.ComponentModel.DataAnnotations;
//using System.Collection.Generic;
using System.Linq;
 //using System.Threadind.Tasks;

 namespace Store.models
 {
 	class Otdel
 	{
 		[Key] public int CodeOtdela {get;set;}
 		public string NameOtdela {get;set;}
 		public string FioZavOtdela {get;set;}
 		public int PhoneOtdela {get;set;}
 		public int VolumeProdazVden {get;set;}
 		[Required] public Sale Sales2 {get;set;}
 	}
}