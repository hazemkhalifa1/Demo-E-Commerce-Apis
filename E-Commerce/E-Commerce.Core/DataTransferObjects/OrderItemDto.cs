﻿namespace E_Commerce.Core.DataTransferObjects
{
	public class OrderItemDto
	{
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public string ProductId { get; set; }
		public string ProductName { get; set; }
		public string PictureUrl { get; set; }
	}
}