using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFStore.Core;

namespace WPFStore.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand AboutMeViewCommand { get; set; }
        public RelayCommand SkillsViewCommand { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }
        public AboutMeViewModel AboutMeVM { get; set; }
        public SkillsViewModel SkillsVM { get; set; }

        public HomeViewModel HomeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertuChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            AboutMeVM = new AboutMeViewModel();
            SkillsVM = new SkillsViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            AboutMeViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutMeVM;
            });

            SkillsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SkillsVM;
            });
        }
    }
}
