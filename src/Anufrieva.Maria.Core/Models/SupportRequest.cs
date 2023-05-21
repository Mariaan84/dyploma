using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Commands;
using PropertyChanged;

namespace Anufrieva.Marria.Core.Models
{
    [AddINotifyPropertyChangedInterface]
    public sealed class SupportRequest
    {
        public string Title { get; set; }
        public string Description { get; set; } = "Write short description for the ad...";
        public DateTime Date { get; set; } = DateTime.Now;
        public bool Saved { get; set; }
        public User User { get; set; } = new User();

        private IMvxCommand _sendMessageCommand;
        public IMvxCommand SendMessageCommand => _sendMessageCommand 
            ??= new MvxAsyncCommand(SendMessageCommandExecute);
        
        private IMvxCommand _changeSavedCommand;
        public IMvxCommand ChangeSavedCommand => _changeSavedCommand 
            ??= new MvxCommand(ChangeSavedCommandExecute);

        private Task SendMessageCommandExecute() =>
            NotImplemented();

        private void ChangeSavedCommandExecute() =>
            Saved = !Saved;
        
        private Task NotImplemented() =>
            UserDialogs.Instance.AlertAsync("This feature is not implemented :(");
    }
}