using Climate_Science_Quiz_Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climate_Science_Quiz_Game.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand MainMenuViewCommand { get; set; }
        public RelayCommand QuizGameViewCommand { get; set; }

        public MainMenuViewModel MainMenuVM { get; set; }
        public QuizGameViewModel QuizGameVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            MainMenuVM = new MainMenuViewModel();
            QuizGameVM = new QuizGameViewModel();
            CurrentView = MainMenuVM;

            MainMenuViewCommand = new RelayCommand(o =>
            {
                CurrentView = MainMenuVM;
            });

            QuizGameViewCommand = new RelayCommand(o =>
            {
                CurrentView = QuizGameVM;
            });
        }
    }
}
