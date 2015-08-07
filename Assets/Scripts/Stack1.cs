using UnityEngine;
using System.Collections;

public class Stack1 : MonoBehaviour {
	
	GameObject[] pila_game = new GameObject[5];
	public GameObject player;
	string[] val = new string[]{"2", "3", "4", "2", "3"};

	void copia(){
		for (int i = 0; i < 5; i++){
			GameObject player_t = Instantiate (player, transform.position, transform.rotation) as GameObject;
			player_t.tag = val[i]; 
			pila_game[i] = player_t as GameObject;
		}
	}
	void Start(){
		copia();
	}
}
