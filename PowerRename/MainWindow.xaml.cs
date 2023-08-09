using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Windows.ApplicationModel.Resources;
using PowerRename;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PowerRename
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        public MainViewModel ViewModel = new MainViewModel();

        private void button_rename_Click(SplitButton sender, SplitButtonClickEventArgs args)
        {

        }

        private void OpenDocs(object sender, RoutedEventArgs e)
        {

        }

        private void DateTimeItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {

        }

        private void ShowRenamed(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectAll(object sender, RoutedEventArgs e)
        {

        }
    }

    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            ExplorerItems = new ObservableCollection<ExplorerItemViewModel>
            {
                new ExplorerItemViewModel { Original = "c:\\source\\synology-elk\\docker-compose.yml" }
            };

            SearchMRU = new ObservableCollection<string>();
            ReplaceMRU = new ObservableCollection<string>();
            SearchMRU = new ObservableCollection<string>();
            SearchRegExShortcuts = new ObservableCollection<PatternSnippet>();
            DateTimeShortcuts = new ObservableCollection<PatternSnippet>();

            var rm = new ResourceManager().MainResourceMap;

            SearchRegExShortcuts.Add(new PatternSnippet { Code = ".", Description = rm.GetValue("Resources/RegExCheatSheet_MatchAny").ValueAsString });
            SearchRegExShortcuts.Add(new PatternSnippet { Code = "\\d", Description = rm.GetValue("Resources/RegExCheatSheet_MatchDigit").ValueAsString });
            SearchRegExShortcuts.Add(new PatternSnippet { Code = "\\D", Description = rm.GetValue("Resources/RegExCheatSheet_MatchNonDigit").ValueAsString });
            SearchRegExShortcuts.Add(new PatternSnippet { Code = "\\w", Description = rm.GetValue("Resources/RegExCheatSheet_MatchNonWS").ValueAsString });
            SearchRegExShortcuts.Add(new PatternSnippet { Code = "\\S", Description = rm.GetValue("Resources/RegExCheatSheet_MatchWordChar").ValueAsString });
            SearchRegExShortcuts.Add(new PatternSnippet { Code = "\\S+", Description = rm.GetValue("Resources/RegExCheatSheet_MatchOneOrMoreWS").ValueAsString });
            SearchRegExShortcuts.Add(new PatternSnippet { Code = "\\b", Description = rm.GetValue("Resources/RegExCheatSheet_MatchWordBoundary").ValueAsString });
        }

        public ObservableCollection<string> SearchMRU { get; }
        public ObservableCollection<string> ReplaceMRU { get; }
        public ObservableCollection<ExplorerItemViewModel> ExplorerItems { get; }
        public ObservableCollection<PatternSnippet> SearchRegExShortcuts { get; }
        public ObservableCollection<PatternSnippet> DateTimeShortcuts { get; }

        [ObservableProperty]
        private string originalCount;

        [ObservableProperty]
        private string renamedCount;

        [RelayCommand]
        void OpenDocs()
        {

        }

        [RelayCommand]
        private void Rename()
        {

        }

        [RelayCommand]
        private void MenuFlyoutItem_Click()
        {

        }

        [RelayCommand]
        private void RegExItem()
        {

        }

        [RelayCommand]
        private void SelectAll()
        {

        }

        private void ShowRenamed()
        {

        }

        [RelayCommand]
        private void ShowAll()
        {

        }

        [RelayCommand]
        private void DateTimeItem()
        {

        }
    }

    public partial class PatternSnippet : ObservableObject
    {
        [ObservableProperty]
        private string code;

        [ObservableProperty]
        private string description;
    }
}
