using System;

namespace Zakhara.Domain.Items.Base
{
	public abstract class Item
	{
		// PROPERTIES
		public Guid Id { get; set; }
		public bool Consumable { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }
		public float Price { get; set; }
		public float Weight { get; set; }
	}
}