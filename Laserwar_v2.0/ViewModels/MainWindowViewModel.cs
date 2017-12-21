namespace Laserwar_v2._0.ViewModels
{
    using Catel.Data;
    using Catel.MVVM;
    using System.Threading.Tasks;
    using System.Windows;

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Close_ClickCommand = new Command(OnClose_ClickCommandExecute);
        }

        public override string Title { get { return "Laserwar_v2._0"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets
       
        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
        }

        protected override async Task CloseAsync()
        {
            await base.CloseAsync();
        }


        public Command Close_ClickCommand { get; private set; }

        private void OnClose_ClickCommandExecute()
        {
            Application.Current.Shutdown();
        }
    }
}
