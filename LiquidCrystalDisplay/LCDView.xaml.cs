using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LiquidCrystalDisplay
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class LCDView : Page
	{
		public LCDView()
		{
			this.InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			((MainPage) e.Parameter).lcdView = this;
		}

		public void SetDisplay(bool[][] lcd)
		{
			var On = new SolidColorBrush(Colors.Black);
			var Off = new SolidColorBrush(Colors.Transparent);

			lblLCD_00.Fill = (lcd[0][0]) ? On : Off;
			lblLCD_01.Fill = (lcd[0][1]) ? On : Off;
			lblLCD_02.Fill = (lcd[0][2]) ? On : Off;

			lblLCD_10.Fill = (lcd[1][0]) ? On : Off;
			lblLCD_11.Fill = (lcd[1][1]) ? On : Off;
			lblLCD_12.Fill = (lcd[1][2]) ? On : Off;

			lblLCD_20.Fill = (lcd[2][0]) ? On : Off;
			lblLCD_21.Fill = (lcd[2][1]) ? On : Off;
			lblLCD_22.Fill = (lcd[2][2]) ? On : Off;

			lblLCD_30.Fill = (lcd[3][0]) ? On : Off;
			lblLCD_31.Fill = (lcd[3][1]) ? On : Off;
			lblLCD_32.Fill = (lcd[3][2]) ? On : Off;

			lblLCD_40.Fill = (lcd[4][0]) ? On : Off;
			lblLCD_41.Fill = (lcd[4][1]) ? On : Off;
			lblLCD_42.Fill = (lcd[4][2]) ? On : Off;
		}
	}
}
