using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ePassOpMaker;

public partial class Edit : UserControl
{
		public Edit()
		{
				InitializeComponent();
		}

		private void ComboBox_ResolutionSelector_Holding(object? sender, Avalonia.Input.HoldingRoutedEventArgs e)
		{
		}
}