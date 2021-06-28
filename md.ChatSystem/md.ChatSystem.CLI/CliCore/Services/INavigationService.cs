using System.ComponentModel;

namespace Md.ChatSystem.CLI.CliCore.Services
{
    interface INavigationService
    {
        void Navigate<IViewModel, T>(T navigationParameters);

        void Navigate<IViewModel>();
    }

    interface INavigatable
    {
        public 
    }

    class test : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
