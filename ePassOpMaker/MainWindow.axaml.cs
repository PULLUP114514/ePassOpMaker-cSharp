using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using System;

namespace ePassOpMaker
{
		public partial class MainWindow : Window
		{
				public MainWindow()
				{
						InitializeComponent();

						((App)Application.Current).ThemeChanged(null, null);
				}

				private void Button_PageSelectorEdit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
				{
						return;
				}
		}
}