using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Shall.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shall.ViewModels
{
	class StartupViewModel:BindableBase
	{
		public DelegateCommand LoginCommand { get; set; }
	    private IRegionManager _regionManeger;
		private void Execute()
		{
			_regionManeger.Regions["MainRegion"].RemoveAll();
			
			_regionManeger.RegisterViewWithRegion("Login", typeof(Login));
		}

		public StartupViewModel(IRegionManager regionManager)
		{
			_regionManeger = regionManager;

			LoginCommand = new DelegateCommand(Execute);
		}
	}
}
