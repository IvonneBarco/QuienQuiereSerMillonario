using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using EaseTools;

public class InterfazUsuario : MonoBehaviour {

	public GameObject menu;
	public GameObject menuGanador;
	public Text textoMenuGanador;

	public GameObject menuPerdedor;
	public Text textoMenuPerdedor;

	//***public Slider sliderDificultad;
	public Slider sliderDificultadAn;
	public Slider sliderDificultadAl;
	public Text textoDificultad;


	//Evitar que se haga clic por debajo del panel
	public bool menuMostrado;
	//****public int dificultad;
	public int dificultadAncho;
	public int dificultadAlto;
	//

	public int segundosCronometro;
	public Text textoCronometro;

	public GameObject btnMenu;
	public EaseUI EaseBotonJugarOtraVez;
	public EaseUI EaseBotonJugarOtraVez2;
	public EaseUI EaseBotonSiguiente;
	public EaseUI EaseTexto1;
	public EaseUI EaseTexto2;
	public EaseUI EaseTexto11;
	public EaseUI EaseTexto22;
	public EaseUI EasePuntosFinal;
	public EaseUI ImgSad;
	public EaseUI ImgHappy;

	public TimeSpan tiempo;

	//Ocultar Elementos
	public GameObject oCronometro, oBarra, oVidas, oPuntos;

	void Start(){
		CambiarDificultad ();
		EsconderBtnMenu ();
	}

	public void MostrarMenu(){
		menu.SetActive (true);
		menuMostrado = true;
	}

	public void EsconderMenu(){
		menu.SetActive (false);
		menuMostrado = false;
	}

	public void MostrarBtnMenu(){
		btnMenu.SetActive (true);
	}

	public void EsconderBtnMenu(){
		btnMenu.SetActive (false);
	}


	public void MostrarMenuGanador(){
		menuGanador.SetActive (true);
		menuMostrado = true;
		EaseBotonJugarOtraVez.MoveIn ();
		EaseTexto1.MoveIn ();
		EaseTexto2.MoveIn ();
		ImgHappy.MoveIn ();
		EasePuntosFinal.MoveIn();
		textoMenuGanador.text = "  TIEMPO: "+ tiempo;
		ReiniciarCronometro ();
		OcultarElementos ();
	}

	public void MostrarMenuPerdedor(){
		menuPerdedor.SetActive (true);
		menuMostrado = true;
		EaseBotonJugarOtraVez2.MoveIn ();
		EaseTexto11.MoveIn ();
		EaseTexto22.MoveIn ();
		ImgSad.MoveIn ();
		textoMenuPerdedor.text = "  TIEMPO: "+ tiempo;
		ReiniciarCronometro ();
		OcultarElementos ();
	}

	public void EsconderMenuGanador(){
		menuGanador.SetActive (false);
		menuMostrado = false;
		ReiniciarCronometro ();
		MostrarElementos ();
	}

	public void EsconderMenuPerdedor(){
		menuPerdedor.SetActive (false);
		menuMostrado = false;
		ReiniciarCronometro ();
		MostrarElementos ();
	}



	public void CambiarDificultad(){
		//***dificultad = (int)sliderDificultad.value*2;
		dificultadAncho = (int)sliderDificultadAn.value;
		dificultadAlto = (int)sliderDificultadAl.value;
		textoDificultad.text = "DIFICULTAD: " + dificultadAncho + "x" + dificultadAlto;
	}



	//Cronometro
	public void ActivarCronometro(){
		ActualizarCronometro ();
	}
	public void ReiniciarCronometro(){
		segundosCronometro = 0;
		CancelInvoke ("ActualizarCronometro");
	}

	public void PausarCronometro(){

//		if (segundosCronometro == 5) {
//			MostrarMenuPerdedor();
//		}
		
	}

	public void ActualizarCronometro(){
		segundosCronometro++;

		tiempo = new TimeSpan(0,0, segundosCronometro);
		textoCronometro.text = tiempo.ToString ();
		Invoke ("ActualizarCronometro", 1.0f);

	}


	public void OcultarElementos(){
		oCronometro.SetActive (false);
		oBarra.SetActive (false);
		oVidas.SetActive (false);
		oPuntos.SetActive (false);
	}

	public void MostrarElementos(){
		oCronometro.SetActive (true);
		oBarra.SetActive (true);
		oVidas.SetActive (true);
		oPuntos.SetActive (false);
	}
}
