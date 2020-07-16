using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Die die1 = new Die();
			
			/// Cannot set Value outside of the Die class
			/// because it's not private
			/// die1.Value = 6;
		}
	}
}
