using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Security_App
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Button_Click_Enter(object sender, RoutedEventArgs e)
		{
			String code = pbx.Password;
			string type = "";

			if (code == " ")
			{
				MessageBox.Show("Sorry try entering in a valid PIN ");
			}

			switch (code)
			{
				
				case "1645":
				case "1689":
					type = "Technicians ";
					break;

				case "8345":
					type = "Custadians ";
					break;

				case "9998":
				case "1006":
				case "1007":
				case "1008":
					type = "Scientists ";
					break;

				default:
					type = "Access Denied  ";
					break;
			}


			string time = Convert.ToString(DateTime.Now);

			lbx.Items.Add(type + time);

			pbx.Password = "";

		}

		private void Button_Click_Clear(object sender, RoutedEventArgs e)
		{
			if (pbx.Password.Length > 0)
			{
				pbx.Password = pbx.Password.Remove(pbx.Password.Length - 1);
			}
		}

		private void Button_Click0(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "0";

		}

		private void Button_Click1(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + '1';

		}

		private void Button_Click2(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "2";

		}

		private void Button_Click3(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "3";

		}

		private void Button_Click4(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "4";

		}

		private void Button_Click5(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "5";

		}

		private void Button_Click6(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "6";

		}

		private void Button_Click7(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "7";

		}

		private void Button_Click8(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "8";

		}

		private void Button_Click9(object sender, RoutedEventArgs e)
		{

			pbx.Password = pbx.Password + "9";

		}
	}
}
