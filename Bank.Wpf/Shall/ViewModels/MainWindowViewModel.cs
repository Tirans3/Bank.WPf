using Prism.Mvvm;
using Prism.Regions;
using Shall.Views;

namespace Shall.ViewModels
{
	class MainWindowViewModel : BindableBase
	{
		private IRegionManager _regionManager;

		public MainWindowViewModel(IRegionManager regionManager)
		{
			_regionManager = regionManager;
			_regionManager.RegisterViewWithRegion("MainRegion", typeof(Startup));
		}
	}
}
