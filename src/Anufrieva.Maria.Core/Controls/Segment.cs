using System.Windows.Input;
using PropertyChanged;

namespace Anufrieva.Marria.Core.Controls
{
    [AddINotifyPropertyChangedInterface]
    public class Segment
    {
        public string Title { get; set; }
        public ICommand Command { get; set; }
    }
}