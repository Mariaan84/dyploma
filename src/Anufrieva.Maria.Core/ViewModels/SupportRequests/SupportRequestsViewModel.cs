using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Anufrieva.Marria.Core.Controls;
using Anufrieva.Marria.Core.Models;
using Anufrieva.Marria.Core.Services.RequestFilter;
using Anufrieva.Marria.Core.ViewModels.AddSupportRequest;
using Anufrieva.Marria.Core.ViewModels.Base;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Anufrieva.Marria.Core.ViewModels.SupportRequests
{
    public class SupportRequestsViewModel : BaseViewModel
    {
        private readonly ISupportRequestProvider _requestProvider;
        private List<SupportRequest> _allSupportRequests;
        public int SelectedSegmentIndex { get; set; }
        
        public Segment[] Segments { get; }
        
        public MvxObservableCollection<SupportRequest> SupportRequests { get; set; }

        private IMvxCommand _addRequestCommand;
        public IMvxCommand AddRequestCommandCommand => _addRequestCommand 
            ??= new MvxAsyncCommand(AddRequestCommandCommandExecute);

        public SupportRequestsViewModel(ILoggerFactory logFactory, IMvxNavigationService navigationService, 
            ISupportRequestProvider requestProvider)
            : base(logFactory, navigationService)
        {
            _requestProvider = requestProvider;
            
            Segments = new[]
            {
                new Segment { Title = "All", Command = new MvxCommand(AllCommandExecute) },
                new Segment { Title = "Created by me", Command = new MvxCommand(CreatedByMeCommandExecute) },
                new Segment { Title = "Saved", Command = new MvxCommand(SavedCommandExecute) }
            };

            _allSupportRequests = requestProvider.Get().ToList();
            SupportRequests = new MvxObservableCollection<SupportRequest>(_allSupportRequests);
            
            void AllCommandExecute() =>
                SupportRequests.ReplaceWith(_allSupportRequests);

            void CreatedByMeCommandExecute() =>
                SupportRequests.ReplaceWith(_allSupportRequests.Where(sr => sr.User.Name == "Current User"));

            void SavedCommandExecute() =>
                SupportRequests.ReplaceWith(_allSupportRequests.Where(sr => sr.Saved));
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
            
            var news = _requestProvider.Get().Where(sr => !SupportRequests.Contains(sr)).ToArray();
            _allSupportRequests.AddRange(news);
            SelectedSegmentIndex = 0;
            SupportRequests.ReplaceWith(_allSupportRequests);
        }

        private Task AddRequestCommandCommandExecute() =>
            NavigationService.Navigate<AddSupportRequestViewModel>();
    }
}
