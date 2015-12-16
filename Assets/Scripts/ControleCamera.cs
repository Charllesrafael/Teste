using UnityEngine;
using System.Collections;

public class ControleCamera : MonoBehaviour {

	public GameObject alvo;
	
	public float contRot = 0;
	public float velocidade = 0;
	public bool rotacionado;


		

	// Use this for initialization
	void Start () 
	{
		alvo = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
//
//		if (this.transform.position != alvo.transform.position) 
//		{
//			contRot += Time.deltaTime * velocidade;
//			this.transform.position = Vector3.Lerp (this.transform.position, new Vector3 (alvo.transform.position.x,alvo.transform.position.y-10,this.transform.position.z), contRot);
//		} 
//		{
//			contRot = 0;
//		}
//		contRot += Time.deltaTime * velocidade;
		this.transform.position =  new Vector3 (this.transform.position.x,alvo.transform.position.y-16,this.transform.position.z);
	}


}
