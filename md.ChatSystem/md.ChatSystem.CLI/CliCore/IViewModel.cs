namespace Md.ChatSystem.CLI.CliCore
{
    interface IViewModel
    {
        void OnNavigated<T>(T navigationParameters);

        void OnNavigated();
    }
}

