using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser.Datas {
	public class User { //Данні юзера
		[Key]
		public int ID { get; set; }
		[Index(IsUnique = true)]
		[StringLength(450)]
		public string Username { get; set; }
		public string Password { get; set; }
		public int BestScore { get; set; } = 0;

		public User(string Username, string Password) {
			this.Username = Username;
			this.Password = Password;
		}
		public User() {}
	}
}
