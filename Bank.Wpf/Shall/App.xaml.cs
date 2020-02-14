using CommonServiceLocator;
using Prism.Ioc;
using Prism.Ninject;
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
			containerRegistry.Register<Login>();
		}

		protected override Window CreateShell()
		{
			return ServiceLocator.Current.GetInstance<MainWindow>();
		}
	}

}