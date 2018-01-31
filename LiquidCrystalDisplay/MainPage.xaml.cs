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

using Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LiquidCrystalDisplay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		public LCDView lcdView;
		private CoreLCD coreLCD;

		public MainPage()
        {
            this.InitializeComponent();

			frmMain.Navigate(typeof(LCDView), this);

			coreLCD = new CoreLCD();
		}

		private void btnZero_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(0).vals);
		}

		private void btnOne_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(1).vals);
		}

		private void btnTwo_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(2).vals);
		}

		private void btnThree_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(3).vals);
		}

		private void btnFour_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(4).vals);
		}

		private void btnFive_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(5).vals);
		}

		private void btnSix_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(6).vals);
		}

		private void btnSeven_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(7).vals);
		}

		private void btnEight_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(8).vals);
		}

		private void btnNine_Click(object sender, RoutedEventArgs e)
		{
			lcdView.SetDisplay(coreLCD.getLCDForIndex(9).vals);
		}
	}
}
