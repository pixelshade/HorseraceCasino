using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour {

	[SerializeField]
	private HorsePrefabScript _horsePrefabScript;
	private int _money;
	private Horse _horseChoice;
	public List<Horse> RacingHorses = new List<Horse>();


	public void SetHorseChoice(Horse choice){
		_horseChoice = choice;
	}

	public Horse GetHorseChoice(){
		return _horseChoice;
	}

	public void SetMoney(int money){
		_money = money;
		Storage.SetMoney (_money);
	}

	public void ChangeMoneyBy(int money){
		_money += money;
		SetMoney (_money);
	}

	public int GetMoney(){
		return _money;
	}


	// Use this for initialization
	void Start () {
		_money = Storage.GetMoney ();
	
	}


	void SetUpRace(){
		RacingHorses = HorseDB.Instance.GetRandom3Horses ();
		var offset = 0.3f;
		foreach (var h in RacingHorses) {
			var hPrefab = Instantiate (_horsePrefabScript, new Vector3 (offset, 0, 0), Quaternion.identity);

			offset += 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
