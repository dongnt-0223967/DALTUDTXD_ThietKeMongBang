using DALTUDTXD_ThietKeMongBang.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace DALTUDTXD_ThietKeMongBang.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object _currentChildView;
        public object CurrentChildView
        {
            get => _currentChildView;
            set
            {
                if (_currentChildView != value)
                {
                    _currentChildView = value;
                    OnPropertyChanged(nameof(CurrentChildView));
                }
            }
        }

        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowCal1ViewCommand { get; }
        public ICommand ShowCal2ViewCommand { get; }
        public ICommand ShowCal3ViewCommand { get; }
        public ICommand ShowCal4ViewCommand { get; }
        public ICommand ShowCal5ViewCommand { get; }

        public MainViewModel()
        {
            // Initialize commands
            ShowHomeViewCommand = new RelayCommand(o => ShowHomeView());
            ShowCal1ViewCommand = new RelayCommand(o => ShowCal1View());
            ShowCal2ViewCommand = new RelayCommand(o => ShowCal2View());
            ShowCal3ViewCommand = new RelayCommand(o => ShowCal3View());
            ShowCal4ViewCommand = new RelayCommand(o => ShowCal4View());
            ShowCal5ViewCommand = new RelayCommand(o => ShowCal5View());

            // Start with Home view
            CurrentChildView = new HomeViewModel();
        }

        private void ShowHomeView() => CurrentChildView = new HomeViewModel();
        private void ShowCal1View() => CurrentChildView = new Page1View(); // TODO: replace with Cal1 view/viewmodel 
        private void ShowCal2View() => CurrentChildView = null; // TODO: replace with Cal2 view/viewmodel
        private void ShowCal3View() => CurrentChildView = new Page4View(); // TODO: replace with Cal3 view/viewmodel
        private void ShowCal4View() => CurrentChildView = new Page5View(); // TODO: replace with Cal4 view/viewmodel
        private void ShowCal5View() => CurrentChildView = null; // TODO: replace with Cal5 view/viewmodel

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
