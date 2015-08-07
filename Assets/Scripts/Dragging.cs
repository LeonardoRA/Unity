using UnityEngine;
using System.Collections;

public class Dragging : MonoBehaviour{


	Vector2 dist;
	float posX, new_possX;
	float posY, new_possY;
	string pila, pila2;

	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
	}
	void OnMouseUp(){
		if (transform.position.x < 0.02f && transform.position.x > -4.98f) {
			Vector2 poss = new Vector2 (-2.51f, 4.79f);
			transform.position = poss;
		}
		if (transform.position.x > 0.02f && transform.position.x < 5.05f) {
			Vector2 poss = new Vector2 (2.56f, 4.79f);
			transform.position = poss;
		}
		if (transform.position.x > 5.05f) {
			Vector2 poss = new Vector2 (7.54f, 4.79f);
			transform.position = poss;
		}
		stacks();
	}
	void OnMouseDrag(){
		Vector2 curPos = 
			new Vector2 (Input.mousePosition.x - posX, 
			            Input.mousePosition.y - posY);  
		Vector2 worldPos = Camera.main.ScreenToWorldPoint (curPos);
		transform.position = worldPos;
	}
	void OnTriggerStay2D(Collider2D collider){
		pila = gameObject.tag;
		string pi = "objeto "+pila;
		Debug.Log (pi);
		pila2 = collider.gameObject.tag;
		pi = "objeto "+pila2;
		Debug.Log (pi);
	}
	void stacks(){
		if (pila != pila2) 
			Destroy (gameObject, 1f);
	}
}