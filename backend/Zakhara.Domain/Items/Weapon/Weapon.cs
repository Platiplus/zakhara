using System;
using Zakhara.Domain.Items.Base;

namespace Zakhara.Domain.Items.Weapon
{
	public class Weapon : Item
	{
		// PROPERTIES
		public Guid Id { get; set; }
		public Guid ItemId { get; set; }
		public int DamageDice { get; set; }
		public DamageType DamageType { get; set; }
		public int DiceModifier { get; set; }
		public WeaponProperties Properties { get; set; }
		public WeaponType WeaponType { get; set; }
	}
}
