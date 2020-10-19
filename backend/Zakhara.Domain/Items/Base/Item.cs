using System;

namespace Zakhara.Domain.Items.Base
{
	class Item
	{
		public Guid Id { get; set; }
		public bool Consumable { get; set; }
		public String Description { get; set; }
		public String Name { get; set; }
		public float Price { get; set; }
		public float Weight { get; set; }
	}
}
