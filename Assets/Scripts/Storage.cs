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

	public void SetMoney(int money){
		PlayerPrefs.SetInt (KEY_MONEY, money);
	}

	public int GetMoney(){
		return PlayerPrefs.GetInt (KEY_MONEY);
	}

	public void IncNumSession(){
		var num = GetNumSession ();
		num++;
		PlayerPrefs.SetInt (NUM_SESSION, num);
	}

	public int GetNumSession(){
		return PlayerPrefs.GetInt (NUM_SESSION);
	}
}
