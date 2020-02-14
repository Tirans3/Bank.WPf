using Prism.Ioc;
using Prism.Ninject;
using System.ComponentModel;
using System.Windows;

namespace Shall.Views
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App:PrismApplication
	{
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{

		}

		protected override Window CreateShell()
		{
			return Container.Resolve<MainWindow>();
		}
	}

}