using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using System;
using System.Diagnostics;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace ePassOpMaker
{
		public partial class MainWindow : Window
		{
				public MainWindow()
				{
						InitializeComponent();

						// 订阅主题更改事件
						var app = (App)Application.Current!;
						app.ThemeChangedEvent += OnThemeChanged;

						// 刚启动时重设主题颜色
						var theme = Application.Current!.ActualThemeVariant;
						OnThemeChanged(theme);
				}

				private void Button_PageSelectorEdit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
				{
						return;
				}



				/// <summary>
				/// 主题更改处理器
				/// </summary>
				/// <param name="theme"></param>
				private void OnThemeChanged(ThemeVariant theme)
				{
						string currentTheme = "";
						if (theme == ThemeVariant.Dark)
						{
								Debug.WriteLine("MainWindow: Dark♂");
								currentTheme = "dark";
						}
						else
						{
								Debug.WriteLine("MainWindow: Light");
								currentTheme = "light";
						}

						// 设置
						Image_PageSelectorEdit.Source =
							new Bitmap(AssetLoader.Open(
								new Uri($"avares://ePassOpMaker/Assets/{currentTheme}/edit.png")));
				}
		}
}