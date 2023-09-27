using System.ComponentModel;

namespace SquareProject.Client.ViewModels.BaseClass
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
    }
}
