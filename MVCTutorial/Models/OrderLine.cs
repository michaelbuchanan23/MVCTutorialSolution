using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models {
	public class OrderLine {

		public int Id { get; set; }
		public int OrderId { get; set; }
		public virtual Order Order { get; set; }
		public string Product { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		//public virtual Order Order { get; set; }  //we didn't use this because if we keep a List in Order.cs for OrderLine then we don't use this
												    //because it would be recurring over and over again


		public OrderLine() { }
	}
}