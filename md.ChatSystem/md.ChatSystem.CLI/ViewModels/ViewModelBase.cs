using Md.ChatSystem.CLI.CliCore;
using System;

namespace Md.ChatSystem.CLI.ViewModels
{
    public abstract class ViewModelBase : IViewModel
    {
        public void OnNavigated<T>(T navigationParameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigated()
        {
            throw new NotImplementedException();
        }
    }
}
