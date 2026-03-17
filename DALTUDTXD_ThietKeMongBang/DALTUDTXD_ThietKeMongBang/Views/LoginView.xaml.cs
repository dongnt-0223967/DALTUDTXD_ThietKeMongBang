using System;
using System.Windows;
using System.Windows.Input;

namespace DALTUDTXD_ThietKeMongBang.Views
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        // Cho phép kéo cửa sổ khi nhấn chuột trái (vì WindowStyle=None)
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        // Thu nhỏ cửa sổ
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // Đóng ứng dụng
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Reset password
        private void Reset_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(
                "Tính năng đang được phát triển",
                "Thông báo",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        // Đăng nhập
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Password.Trim();

            if (username == "sftdt" && password == "tdt123")
            {
                MainView mainView = new MainView();
                mainView.Show();
                Close();
            }
            else
            {
                txtError.Text = "Tài khoản hoặc mật khẩu không đúng!";
            }
        }
    }
}