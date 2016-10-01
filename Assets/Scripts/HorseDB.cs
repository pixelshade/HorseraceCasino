using System;
using System.Collections.Generic;
using System.Linq;

public class HorseDB
{
	private static readonly HorseDB instance = new HorseDB ();
	private static List<Horse> horses = new List<Horse> () {
		new Horse{ Name = "johny", Speed = 1.1f, Condition = 1, Luck = 0, Sprite = "h1" },
		new Horse{ Name = "Kvaken", Speed = 0.9f, Condition = 1, Luck = 0.1f, Sprite = "h2" },
		new Horse{ Name = "Jenny", Speed = 0.8f, Condition = 1, Luck = 0, Sprite = "h3" },
		new Horse{ Name = "Kali", Speed = 0.5f, Condition = 1, Luck = 0.4f, Sprite = "h_uni" }
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
		return horses.OrderBy (x => rnd.Next ()).Take(3).ToList();
	}
}


