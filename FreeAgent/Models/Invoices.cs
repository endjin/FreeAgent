using System;
using System.Collections.Generic;

namespace FreeAgent
{
	
	//GET https://api.freeagent.com/v2/contacts
	
	//https://api.freeagent.com/v2/contacts
	
	public class Invoice
	{
		public Invoice()
		{
			invoice_items = new List<InvoiceItem>();
		}
		public string path { get; set;}
		public string updated_at { get; set; }
		public string created_at { get; set; }
		
		public string reference { get; set; }
		public string contact { get; set; }
		public string project { get; set; }
		public string status { get; set; }
		
		public double discount_percent { get; set; }
		public string dated_on { get; set; }
		public string due_on { get; set; }
		public double exchange_rate { get; set; }
		public int payment_terms_in_days { get; set; }
		public string currency { get; set; }
		public string ec_status { get; set; }
		public string written_off_date { get; set; }
		public List<InvoiceItem> invoice_items { get; set; }
	}
	
	public class InvoiceItem
	{
		public int position { get; set; }
		public string item_type  { get; set; }
		public double quantity { get; set; }
		public double price { get; set; }
		public string description { get; set; }
		public double sales_tax_rate { get; set; }
		public double second_sales_tax_rate { get; set; }
		public string category { get; set; }
	}
	
	public class InvoiceStatus
	{
		public static string Draft = "Draft";
		public static string Scheduled = "Scheduled";
		public static string Sent = "Sent";
		public static string Cancelled = "Cancelled";
	}
	
	public class InvoiceECStatus
	{
		public static string NonEc = "Non-Ec";
		public static string ECGoods = "EC Goods";
		public static string ECServices = "EC Services";
	}
	
	public class InvoiceItemType
	{
		public static string Hours = "Hours";
		public static string Days = "Days";
		public static string Weeks = "Weeks";
		public static string Months = "Months";
		public static string Years = "Years";
		public static string Products = "Products";
		public static string Services = "Services";
		public static string Training = "Training";
		public static string Expenses = "Expenses";
		public static string Comment = "Comment";
		public static string Bills = "Bills";
		public static string Discount = "Discount";
		public static string Credit = "Credit";
		public static string VAT = "VAT";
	}
	
	public class InvoiceWrapper
	{
		public InvoiceWrapper()
		{
			invoices = new List<Invoice>();
			invoice = null;
		}
		public Invoice invoice { get; set; }
		public List<Invoice> invoices { get; set; }
	}
	
	
	
}




