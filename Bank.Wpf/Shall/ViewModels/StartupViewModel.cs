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
	    private IRegionManager _iragionManeger;
		private void Execute()
		{
			_iragionManeger.RequestNavigate("MainRegion", "Login");
		}

		public StartupViewModel(IRegionManager regionManager)
		{
			_iragionManeger = regionManager;

			LoginCommand = new DelegateCommand(Execute);
		}
	}
}
