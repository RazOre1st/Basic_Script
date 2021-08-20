using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan4 : MonoBehaviour {

	Karakter player1;
	void Start () {
		player1 = new Karakter ();
		player1.Name = "Razor";
		player1.Health = 200;
		player1.Damage = 50;
		player1.Jump();
	}
	
		void Update () 
	{
		
	}
}
