using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Shall.Views;

namespace Shall.ViewModels
{
    class StartupViewModel : BindableBase
    {
        public DelegateCommand<string> LoginRegisterCommand { get; set; }
        private IRegionManager _regionManeger;
        private void Execute(string loginorregister)
        {
            _regionManeger.Regions["MainRegion"].RemoveAll();

            switch (loginorregister)
            {
                case "Login":
                    _regionManeger.RegisterViewWithRegion("MainRegion", typeof(Login));
                    break;
                case "Register":
                    _regionManeger.RegisterViewWithRegion("MainRegion", typeof(Register));
                    break;
            }
        }

        public StartupViewModel(IRegionManager regionManager)
        {
            _regionManeger = regionManager;

            LoginRegisterCommand = new DelegateCommand<string>(Execute);
        }
    }
}
