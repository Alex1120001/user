using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser.Datas { //Налаштування по замовчуваню
	public  class Settings {
		public int Size { get; set; } = 4;
		public int Speed { get; set; } = 10000;
		public int Width { get; set; } = 800;
		public int Height { get; set; } = 450;
		public Settings(int size, int speed, int width, int height) {
			this.Size = size;
			this.Speed = speed;
			this.Width = width;
			this.Height = height;
		}
		public Settings() {}
	}
}
	