using System;
using Zakhara.Domain.Items.Base;

namespace Zakhara.Domain.Items.Armor
{
	public class Armor : Item
	{
		// PROPERTIES
		public new Guid Id { get; set; }
		public Guid ItemId { get; set; }
		public string ArmorClass { get; set; }
		public ArmorType ArmorType { get; set; }
		public bool Stealth { get; set; }
		public int Strength { get; set; }
	}
}
