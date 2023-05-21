using Anufrieva.Marria.Core.Services.RequestFilter;
using Anufrieva.Marria.Core.ViewModels.SupportRequests;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Anufrieva.Marria.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<SupportRequestsViewModel>();

            var container = Mvx.IoCProvider;
            
            container.LazyConstructAndRegisterSingleton<ISupportRequestProvider, SupportRequestProvider>();
        }
    }
}
