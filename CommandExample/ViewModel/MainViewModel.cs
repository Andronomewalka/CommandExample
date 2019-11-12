using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CommandExample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string textExample;
        public string TextExample
        {
            get => textExample;
            set => Set(ref textExample, value);
        }

        public MainViewModel()
        {
            CommandExample = new RelayCommand<object>(CommandExampleExecute, CommandExampleCanExecute);
        }

        public RelayCommand<object> CommandExample { get; private set; }
        private bool CommandExampleCanExecute(object arg)
        {
            return true;
        }
        private void CommandExampleExecute(object arg)
        {
            TextExample = "You clicked the button";
        }
    }
}