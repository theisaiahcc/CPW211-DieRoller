using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
	/// <summary>
	/// Represents one 6-sided die
	/// </summary>
	public class Die
	{
		/// <summary>
		/// current value of die
		/// </summary>
		public byte faceValue { get; set; }
		
		/// <summary>
		/// True if held
		/// </summary>
		public bool isHeld { get; set; }

		// Roll - set random value
		public byte Roll() {
			Random rand = new Random();
			byte num = (byte)rand.Next(1, 7);
			return num;
		}
	}
}
