using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;
using System;
using System.Diagnostics;
namespace ePassOpMaker
{
		public partial class MainWindow : Window
		{

				ePassOpMaker.Edit editPage = new ePassOpMaker.Edit();
				ePassOpMaker.Flash flashPage = new ePassOpMaker.Flash();

				public MainWindow()
				{
						InitializeComponent();

						// 订阅主题更改事件
						var app = (App)Application.Current!;
						app.ThemeChangedEvent += OnThemeChanged;

						// 刚启动时重设主题颜色
						var theme = Application.Current!.ActualThemeVariant;
						OnThemeChanged(theme);

						// 重置主页
						Content_Main.Content = editPage;
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
						Image_PageSelectorFlash.Source =
							new Bitmap(AssetLoader.Open(
								new Uri($"avares://ePassOpMaker/Assets/{currentTheme}/flash.png")));
						Image_PageSelectorSettings.Source =
							new Bitmap(AssetLoader.Open(
								new Uri($"avares://ePassOpMaker/Assets/{currentTheme}/settings.png")));
				}

				private void Button_PageSelectorEdit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
				{
						Content_Main.Content = editPage;
						return;
				}
				private void Button_PageSelectorFlash_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
				{
						Content_Main.Content = flashPage;
						return;
				}

				private void Button_PageSelectorSettings_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
				{
				}
		}
}