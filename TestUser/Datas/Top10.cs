using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser.Datas {
	public class Top10 { //Вибір топ 10 серед всіх, якщо не хочеш 10 то забераєш з 18 строки .Take(10) і в тебе будуть всі з бази 
		public ObservableCollection<Score> top = new ObservableCollection<Score>();
		private void GetTop() {
			//Task.Run(async () => {
			using (MyContexts context = new MyContexts()) {
				//var list = await context.Scores.ToListAsync().ConfigureAwait(true);
				var list = context.Scores.ToList();
				list = list.OrderByDescending(x => x.Value).Take(10).ToList();
				foreach (var item in list) {
					top.Add(item);
				}
			}
			//});
		}
		public Top10() {
			GetTop();
		}
	}
}
