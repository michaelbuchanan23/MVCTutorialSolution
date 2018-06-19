using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.ViewModels {
	public class OrdersForCustomer {

		public Customer Customer { get; set; } //instance of customer that we want
		public IEnumerable<Order> Orders { get; set; } //list of orders for the orders


		public OrdersForCustomer() { }
	}
}