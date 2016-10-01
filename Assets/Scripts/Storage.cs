using UnityEngine;
using System.Collections;

public class Storage : MonoBehaviour {
	private const string KEY_MONEY = "PLAYER_MONEY";
	private const string NUM_SESSION = "NUM_SESSION"; 



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void SetMoney(int money){
		PlayerPrefs.SetInt (KEY_MONEY, money);
	}

	public static int GetMoney(){
		return PlayerPrefs.GetInt (KEY_MONEY);
	}

	public static void IncNumSession(){
		var num = GetNumSession ();
		num++;
		PlayerPrefs.SetInt (NUM_SESSION, num);
	}

	public static int GetNumSession(){
		return PlayerPrefs.GetInt (NUM_SESSION);
	}
}
