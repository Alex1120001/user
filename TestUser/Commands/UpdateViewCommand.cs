using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestUser.ViewModels;

namespace TestUser.Commands {
	public class UpdateViewCommand : ICommand {
		private MainViewModel viewModel; //Вюшка яка відображається
		public UpdateViewCommand(MainViewModel viewModel) {
			this.viewModel = viewModel; //конструктор
		}
		public event EventHandler CanExecuteChanged; //Обовязковий івент для створення наслідника Icommand

		public bool CanExecute(object parameter) { //Обовязковий метод
			return true;
		}

		public void Execute(object parameter) { 
			//Перехід між вкладками за допомогою IComan інтерфейсу
			 if(parameter.ToString() == "Top"){
				viewModel.SelectedViewModel = new TopViewModel();
			} else if (parameter.ToString() == "Home") {
				viewModel.SelectedViewModel = new HomeViewModel();
			} else if (parameter.ToString() == "Settings") {
				viewModel.SelectedViewModel = new SettingsViewModel();
			}
		}
	}
}
