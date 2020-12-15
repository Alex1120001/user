using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestUser.Datas;

namespace TestUser {
	public partial class MainWindow : Window {
		public User CurUser { get; set; }
		public static Settings MySetings { get; set; }
		public MainWindow(User user) {
			InitializeComponent();
			//Встановка юзера, настройок + створення екземпляру бази
			DataContext = new ViewModels.MainViewModel();
			CurUser = user;
			UserLable.Content = CurUser.Username;
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			this.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e) {
		//Запуск вікна гри з параметром настройок
			Window1 window;
			if(MySetings != null){
				Window1._Settings = MySetings;
			}
			window = new Window1(CurUser);
			window.Show();
			this.Close();
		}
	}
}
