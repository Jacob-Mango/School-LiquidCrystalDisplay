using System;
using System.Collections.Generic;
using System.Text;

namespace Core {
	public class LCD {
		public bool[][] vals = new bool[5][];

		public LCD(bool[] rOne, bool[] rTwo, bool[] rThree, bool[] rFour, bool[] rFive) {
			vals[0] = rOne;
			vals[1] = rTwo;
			vals[2] = rThree;
			vals[3] = rFour;
			vals[4] = rFive;
		}
	}

	public class CoreLCD {
		private LCD[] lcds = new LCD[10];

		public CoreLCD() {

			lcds[0] = new LCD(new bool[3] { false, true, false },
									new bool[3] { true, false, true },
									new bool[3] { false, false, false },
									new bool[3] { true, false, true },
									new bool[3] { false, true, false });

			lcds[1] = new LCD(new bool[3] { false, false, false },
									new bool[3] { false, false, true },
									new bool[3] { false, false, false },
									new bool[3] { false, false, true },
									new bool[3] { false, false, false });

			lcds[2] = new LCD(new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, true, false },
									new bool[3] { true, false, false },
									new bool[3] { false, true, false });

			lcds[3] = new LCD(new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, true, false });

			lcds[4] = new LCD(new bool[3] { false, false, false },
									new bool[3] { true, false, true },
									new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, false, false });

			lcds[5] = new LCD(new bool[3] { false, true, false },
									new bool[3] { true, false, false },
									new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, true, false });

			lcds[6] = new LCD(new bool[3] { false, true, false },
									new bool[3] { true, false, false },
									new bool[3] { false, true, false },
									new bool[3] { true, false, true },
									new bool[3] { false, true, false });

			lcds[7] = new LCD(new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, false, false },
									new bool[3] { false, false, true },
									new bool[3] { false, false, false });

			lcds[8] = new LCD(new bool[3] { false, true, false },
									new bool[3] { true, false, true },
									new bool[3] { false, true, false },
									new bool[3] { true, false, true },
									new bool[3] { false, true, false });

			lcds[9] = new LCD(new bool[3] { false, true, false },
									new bool[3] { true, false, true },
									new bool[3] { false, true, false },
									new bool[3] { false, false, true },
									new bool[3] { false, false, false });
		}

		public LCD Get(int number) {
			if (number < 0 || number > lcds.Length) throw new IndexOutOfRangeException();
			return lcds[number];
		}

	}
}
