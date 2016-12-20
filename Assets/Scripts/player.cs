using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {


	public float velocidad = 5f;
	public float fsalto = 1f;
	public bool tocandoSuelo = false;
	private Rigidbody2D rb;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		}
	

	void Update () {
		if (Input.GetKey ("d")) 
		{
			rb.velocity = new Vector2 (velocidad,rb.velocity.y);
			transform.localScale= new Vector3(1,1,1);

		}

		else if (Input.GetKey ("a")) 
		{
			rb.velocity = new Vector2 (-velocidad,rb.velocity.y);
			transform.localScale= new Vector3(-1,-1,-1);	
		}
			
			
			
	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocandoSuelo = true;
		}
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocandoSuelo = false;
		}
	}

}
	

