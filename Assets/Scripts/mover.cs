using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {
	public int tipo;
	public Player player;
	// Use this for initialization
	void Start () {
//		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		if (tipo == 1) 
			player.Mover (player.transform.right,player.velocidade);
		else
			player.Mover (-player.transform.right,player.velocidade);
	}
}
