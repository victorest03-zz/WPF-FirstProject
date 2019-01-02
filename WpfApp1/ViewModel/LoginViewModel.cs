namespace WpfApp1.ViewModel
{
    using Helper;
    using System.Windows;
    using System.Windows.Input;
    using View;

    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            Title = "Login";
            LoginCommand = new Command(Login);
        }

        public void Login()
        {
            if (Application.Current.MainWindow != null)
            {
                Application.Current.MainWindow.Hide();
                Application.Current.MainWindow = new MainView();
                Application.Current.MainWindow.Show();
            }
        }
    }
}
