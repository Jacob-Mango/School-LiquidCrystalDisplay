using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core;

namespace FORMS
{
	public partial class Form1 : Form
	{
		private CoreLCD coreLCD;

		public Form1()
		{
			InitializeComponent();

			coreLCD = new CoreLCD();
		}

		private void SetLCD(bool[][] lcd)
		{
			lblLCD_00.BackColor = (lcd[0][0]) ? Color.White : Color.Black;
			lblLCD_01.BackColor = (lcd[0][1]) ? Color.White : Color.Black;
			lblLCD_02.BackColor = (lcd[0][2]) ? Color.White : Color.Black;

			lblLCD_10.BackColor = (lcd[1][0]) ? Color.White : Color.Black;
			lblLCD_11.BackColor = (lcd[1][1]) ? Color.White : Color.Black;
			lblLCD_12.BackColor = (lcd[1][2]) ? Color.White : Color.Black;

			lblLCD_20.BackColor = (lcd[2][0]) ? Color.White : Color.Black;
			lblLCD_21.BackColor = (lcd[2][1]) ? Color.White : Color.Black;
			lblLCD_22.BackColor = (lcd[2][2]) ? Color.White : Color.Black;

			lblLCD_30.BackColor = (lcd[3][0]) ? Color.White : Color.Black;
			lblLCD_31.BackColor = (lcd[3][1]) ? Color.White : Color.Black;
			lblLCD_32.BackColor = (lcd[3][2]) ? Color.White : Color.Black;
		
			lblLCD_40.BackColor = (lcd[4][0]) ? Color.White : Color.Black;
			lblLCD_41.BackColor = (lcd[4][1]) ? Color.White : Color.Black;
			lblLCD_42.BackColor = (lcd[4][2]) ? Color.White : Color.Black;
		}

		private void BTNZeroClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(0).vals);
		}

		private void BTNOneClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(1).vals);
		}

		private void BTNTwoClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(2).vals);
		}

		private void BTNThreeClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(3).vals);
		}

		private void BTNFourClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(4).vals);
		}

		private void BTNFiveClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(5).vals);
		}

		private void BTNSixClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(6).vals);
		}

		private void BTNSevenClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(7).vals);
		}

		private void BTNEightClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(8).vals);
		}

		private void BTNNineClick(object sender, EventArgs e)
		{
			SetLCD(coreLCD.Get(9).vals);
		}
	}
}
