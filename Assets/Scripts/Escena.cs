using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Escena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Jugar(){
		SceneManager.LoadScene("ModuloPreguntas");
	}

	public void Cerrar(){
		Application.Quit ();
	}

	public void Inicio(){
		SceneManager.LoadScene("Inicio");
	}
}
