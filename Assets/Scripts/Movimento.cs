using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movimento : MonoBehaviour {

	public float velocidade;
	public float contador;
	public bool invertido;
	public GameObject corpo;

	public void Mover(Vector3 direcao, float velocidade)
	{
		this.GetComponent<Rigidbody> ().AddForce(direcao * velocidade);
	}

	public void Mover(Vector3 direcao, float velocidade, float tempo)
	{
		contador += Time.deltaTime;
		if (contador >= tempo) 
		{
			invertido = !invertido;
			contador = 0;
		}

		if (invertido) 
		{
			this.GetComponent<Rigidbody> ().MovePosition (-direcao * velocidade);
		}else 
		{
			this.GetComponent<Rigidbody> ().MovePosition (direcao * velocidade);
		}
	}


	public float contRot = 0;
//	public bool rotacionado;

	public void Rotacionar(GameObject corpo, Vector3 rotacao, float velocidade)
	{
		if (corpo.transform.rotation != Quaternion.LookRotation(rotacao) && contRot < 1) 
		{
			contRot += Time.deltaTime * velocidade;
			corpo.transform.rotation = Quaternion.Lerp (corpo.transform.rotation, Quaternion.LookRotation(rotacao), contRot);
		} //else if(!rotacionado)
		{
			contRot = 0;
		}

	}
}
