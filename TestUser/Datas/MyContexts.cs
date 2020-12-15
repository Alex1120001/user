using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser.Datas {
	public class MyContexts : DbContext {
		public DbSet<User> Users { get; set; } //Таблиці
		public DbSet<Score> Scores { get; set; }
		public MyContexts() : base(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString) { } //Створення бази через контекст і ConnectionStrings
	}
}
