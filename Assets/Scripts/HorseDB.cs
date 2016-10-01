using System;
using System.Collections.Generic;
using System.Linq;

public class HorseDB
{
	private static readonly HorseDB instance = new HorseDB ();
	private static List<Horse> horses = new List<Horse> () {
		new Horse{ Name = "johny", Speed = 1.1, Condition = 1, Luck = 0, Sprite = "h1" },
		new Horse{ Name = "Kvaken", Speed = 0.9, Condition = 1, Luck = 0.1, Sprite = "h2" },
		new Horse{ Name = "Jenny", Speed = 0.8, Condition = 1, Luck = 0, Sprite = "h3" },
		new Horse{ Name = "Kali", Speed = 0.5, Condition = 1, Luck = 0.4, Sprite = "h_uni" }
	};

	public static HorseDB Instance {
		get {
			return instance;
		}
	}

	private HorseDB ()
	{
	}


	public List<Horse> GetAllHorses ()
	{
		return horses;
	}

	public List<Horse> GetRandom3Horses ()
	{
		Random rnd = new Random ();
		return horses.OrderBy (x => rnd.Next ()).Take(3);
	}
}


