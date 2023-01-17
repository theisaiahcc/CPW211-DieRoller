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
		private static Random _random;

		static Die()
		{
			_random = new Random();
		}

		public Die() 
		{
			Roll();
		}
		/// <summary>
		/// current value of die
		/// </summary>
		public byte FaceValue { get; private set; }
		
		/// <summary>
		/// True if held
		/// </summary>
		public bool IsHeld { get; set; }

		// Roll - set random value
		public byte Roll() 
		{
			if (!IsHeld) 
			{
				byte num = (byte)_random.Next(1, 7);
				FaceValue = num;
			}
			return FaceValue;
		}
	}
}
