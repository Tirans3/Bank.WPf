using Prism.Mvvm;
using Prism.Regions;
using Shall.Views;

namespace Shall.ViewModels
{
	class MainWindowViewModel : BindableBase
	{
		private string _userName;
		private string _password;
		private IRegionManager _regionManager;
		public string UserName
		{
			get { return _userName; }
			set { SetProperty(ref _userName, value); }
		}

		public string Password
		{
			get { return _password; }
			set { SetProperty(ref _password, value); }
		}

		public MainWindowViewModel(IRegionManager regionManager)
		{
			_regionManager = regionManager;
			_regionManager.RegisterViewWithRegion("MainRegion", typeof(Startup));
		}
	}
}
