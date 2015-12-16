using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public float valor = 30f;
	public GameObject morteEfect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider o)
	{
		if (o.tag == "Player") 
		{
			o.GetComponent<Player>().combustivelSlider.value += valor;
			if(morteEfect != null)
				Instantiate(morteEfect,this.transform.position,Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
