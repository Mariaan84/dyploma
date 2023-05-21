using Microsoft.Extensions.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Anufrieva.Marria.Core.ViewModels.Base
{
    public abstract class BaseViewModel : MvxNavigationViewModel
    {
        protected BaseViewModel(ILoggerFactory logFactory, IMvxNavigationService navigationService) 
            : base(logFactory, navigationService)
        { }
    }
}
