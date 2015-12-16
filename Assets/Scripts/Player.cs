using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : Movimento {
	public Text acelerometroX;
	public Text acelerometroY;

	public Slider combustivelSlider;
	public float combustivel;
	private Animator ani;
	public float inicialCombustivel = 100;


	// Use this for initialization
	void Start () 
	{
		ani = this.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		combustivel -= Time.deltaTime;
		combustivelSlider.value -= Time.deltaTime;//= combustivel;

//		ani.SetFloat ("direcao",-Input.acceleration.x );//-Input.GetAxis("Horizontal"));
		ani.SetFloat ("direcao",-Input.GetAxis("Horizontal"));

		acelerometroX.text = ""+Input.acceleration.x;
		acelerometroY.text = ""+Input.acceleration.y;

		this.transform.position += new Vector3 (Input.acceleration.x*velocidade*Time.deltaTime, 0,0);

		this.transform.position += new Vector3 (Input.GetAxis("Horizontal")*velocidade*Time.deltaTime, 0,0);

//		Mover (this.transform.up,velocidade);
//
//		if (Input.GetAxis("Horizontal")>0)
//		{
//			Rotacionar(this.gameObject,-corpo.transform.right,velocidade);
//		}else if (Input.GetAxis("Horizontal")<0)
//		{
//			Rotacionar(this.gameObject,corpo.transform.right,velocidade);
//		}
	}
}
