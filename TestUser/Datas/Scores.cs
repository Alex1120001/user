using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser.Datas {
	public class Score { //Класс підрахунку Score
		[Key]
		public int ID { get; set; }
		[Index(IsUnique = true)]
		public User CurUser { get; set; } = null;
		public int UserID { get; set; }
		public int Value { get; set; }
		public string Username { get; set; }

		public Score(int User, int Value, string Username) {
			this.UserID = User;
			this.Value = Value;
			this.Username = Username;
		}
		public Score() {}
	}
}
