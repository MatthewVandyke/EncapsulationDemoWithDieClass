using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
	/// <summary>
	/// Represents an individual standard dice
	/// </summary>
	class Die
	{
		// static fields are shared across all instances of a class
		static Random rand;
		byte minValue;
		byte maxValue;

		static Die() // Static constructors are called once for all instances
		{
			rand = new Random();
		}

		public Die():this(1, 6){ }

		/// <summary>
		/// Creates a die with the numbers between the minimum
		/// and maximum values
		/// </summary>
		/// <param name="minValue">The inclusive lower bound</param>
		/// <param name="maxValue">The inclusive maximum bound</param>
		public Die(byte minValue, byte maxValue)
		{
			this.minValue = minValue;
			this.maxValue = maxValue;
			Roll();
		}

		/// <summary>
		/// Face value of die
		/// </summary>
		public byte Value { get; private set; }

		public bool IsHeld { get; set; }

		/// <summary>
		/// Roll a new random value between 1 - 6
		/// and return the newly rolled value.
		/// If the die is held, the current will be returned
		/// and no new value generated
		/// </summary>
		public byte Roll()
		{
			if (!IsHeld) // If die is not held reroll die
			{
				Value = (byte)rand.Next(minValue, maxValue + 1); // +1 for exclusive random bound
			}
			return Value;
		}
	}
}
