using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class preguntas : MonoBehaviour {

	public Text pregunta;
	public Text A;
	public Text B;
	public Text C;
	public Text D;

	public int contador = 0;

	public GameObject btn_jugar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		iniciarJuego();
	}

	public void numPregunta(){
		contador++;
	}

	public void iniciarJuego(){
		if(contador == 1){
			pregunta.text = "Pregunta";
			A.text = "A";
			B.text = "B";
			C.text = "C";
			D.text = "D";
		}else if(contador == 2){
			pregunta.text = "Pregunta 2";
			A.text = "A 2";
			B.text = "B 2";
			C.text = "C 2";
			D.text = "D 2";
		} else if(contador == 3){
			pregunta.text = "Pregunta 2";
			A.text = "A 2";
			B.text = "B 2";
			C.text = "C 2";
			D.text = "D 2";
		}
	}
}
