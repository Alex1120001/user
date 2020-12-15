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
using System.Windows.Shapes;
using TestUser.Datas;

namespace TestUser {

	public partial class Login : Window {
		public User CurUser { get; set; }
		public Login() {
			InitializeComponent();
			Creater();
		}

		private void LoginClick(object sender, RoutedEventArgs e) {
			if (CheckExist(UsernameBox.Text, PassBox.Password)) {
				using (var context = new MyContexts()) {
					if (!(CurUser is null)) {
						MainWindow main = new MainWindow(CurUser);
						main.Show();
						this.Close();
					}
				}
			}
		}

		//Запис в базу якщо її немає
		private async static void Creater() {
			await Task.Run(async () => {
				using (var context = new MyContexts()) {
					if (!context.Database.Exists()) {
						context.Users.Add(new User(Username: "Admin", Password: "Admin"));
						context.Users.Add(new User(Username: "Test", Password: "Test"));
						context.Users.Add(new User(Username: "123", Password: "123"));
						context.Users.Add(new User(Username: "1", Password: "1"));
						context.Users.Add(new User(Username: "User1", Password: "User1"));
						await context.SaveChangesAsync();
						var user = context.Users.FirstOrDefault();
						context.Scores.Add(new Score(User: user.ID, Value: 10, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 20, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 30, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 40, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 50, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 60, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 70, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 80, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 90, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 100, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 110, Username: user.Username));
						context.Scores.Add(new Score(User: user.ID, Value: 120, Username: user.Username));
						await context.SaveChangesAsync();
					}
				}
			});

		}


		//Пошук користувача
		private bool CheckExist(string Username, string Password) {
			using (MyContexts contexts = new MyContexts()) {
				try {
					var user = contexts.Users.Where(x => x.Username == Username && x.Password == Password).First();
					CurUser = user;
					return true;
				} catch (Exception) {
					MessageBox.Show("No user with this name or password");
				}
				return false;
			}
		}
	}
}
