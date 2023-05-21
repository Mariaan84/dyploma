using Anufrieva.Marria.Core.Models;
using Anufrieva.Marria.Core.Services.RequestFilter;
using Anufrieva.Marria.Core.ViewModels.Base;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Anufrieva.Marria.Core.ViewModels.AddSupportRequest
{
    public sealed class AddSupportRequestViewModel : BaseViewModel
    {
        private readonly ISupportRequestProvider _requestProvider;

        public SupportRequest NewRequest { get; set; } = new SupportRequest();

        private IMvxCommand _postCommand;
        public IMvxCommand PostCommand => _postCommand 
            ??= new MvxCommand(PostCommandExecute);

        public AddSupportRequestViewModel(ILoggerFactory logFactory, IMvxNavigationService navigationService,
            ISupportRequestProvider requestProvider)
            : base(logFactory, navigationService)
        {
            _requestProvider = requestProvider;
        }
        
        private void PostCommandExecute()
        {
            _requestProvider.Add(NewRequest);
            NavigationService.Close(this);
        }
    }
}
