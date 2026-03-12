using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using System;
using System.Diagnostics;

namespace ePassOpMaker
{
		public partial class App : Application
		{
				/// <summary>
				/// 主题更改事件
				/// </summary>
				public event Action<ThemeVariant>? ThemeChangedEvent;

				public override void Initialize()
				{
						AvaloniaXamlLoader.Load(this);
				}

				public override void OnFrameworkInitializationCompleted()
				{
						ActualThemeVariantChanged += ThemeChanged;
						//RequestedThemeVariantChanged += ThemeChanged;
						if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
						{
								desktop.MainWindow = new MainWindow();
						}

						base.OnFrameworkInitializationCompleted();
				}

				public void ThemeChanged(object? sender, EventArgs e)
				{
						var theme = Application.Current!.ActualThemeVariant;

						if (theme == ThemeVariant.Dark)
						{
								Debug.WriteLine("Dark♂ Mode");
						}
						else if (theme == ThemeVariant.Light)
						{
								Debug.WriteLine("light Mode");
						}
						ThemeChangedEvent?.Invoke(theme);
				}
		}
}