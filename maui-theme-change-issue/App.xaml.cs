using System.Diagnostics;

namespace maui_theme_change_issue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Application.Current.RequestedThemeChanged += async (sender, appThemeChangedEventArgs) =>
            {
                Debug.WriteLine($"Theme change: {appThemeChangedEventArgs.RequestedTheme}");
            };
        }

        protected override void OnStart()
        {
            Debug.WriteLine("App.OnStart");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("App.OnResume");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("App.OnSleep");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}