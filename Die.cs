using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
	/// <summary>
	/// Represents an individual dice
	/// </summary>
	class Die
	{
		/// <summary>
		/// Face value of die
		/// </summary>
		public byte Value { get; private set; }

		public bool IsHeld { get; set; }

		// Roll method
	}
}
