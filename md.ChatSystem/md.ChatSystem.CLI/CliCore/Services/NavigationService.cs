namespace Md.ChatSystem.CLI.CliCore.Services
{
    public class NavigationService : INavigationService
    {
        public void Navigate<IViewModel, T>(T navigationParameters)
        {
            throw new System.NotImplementedException();
        }

        public void Navigate<IViewModel>()
        {
            throw new System.NotImplementedException();
        }
    }


    /*
     * Somthing like soem sort of static register that adds views when VM registyered as a context
     */
    public class DefaultNavigationParams { }
}
