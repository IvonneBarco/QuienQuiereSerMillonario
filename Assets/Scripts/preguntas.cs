using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class preguntas : MonoBehaviour {

	//Textos de respuesta
	public Text pregunta;
	public Text A;
	public Text B;
	public Text C;
	public Text D;

	public Text respuesta;

	//Opciones de respuesta
	public GameObject rA;
	public GameObject rB;
	public GameObject rC;
	public GameObject rD;

	public int numPregunta = 0;
	public int rta;

	public GameObject btn_jugar; //inicia el juego
	public GameObject btnGracias; //terminar llamada
	public GameObject panelLlamada;

	// Use this for initialization
	void Start () {
		panelLlamada.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		iniciarJuego();
		validarRespuesta();
	}

	public void contadorPregunta(){
		numPregunta++;
	}

	public void iniciarJuego(){
		if(numPregunta == 1){
			pregunta.text = "¿CUÁL DE LAS SIGUIENTES OPCIONES NO SE CUMPLE COMO REQUISITO \nPARA SER PARTIDOR?";
			A.text = "Persona plenamente capaz";
			B.text = "Abogado inscrito";
			C.text = "Incapaz absoluto"; //OK
			D.text = "Persona natural";

			pregunta.fontSize = 30;

						

		}else if(numPregunta == 2){
			pregunta.text = "EN CASO DE QUE EL PARTIDOR INCURRA EN PREVARICACIÓN Y QUE ESTÁ SEA\n DECLARADA POR EL JUEZ COMPETENTE ¿CUÁL DE LAS SIGUIENTES OPCIONES\n EL JUEZ NO PODRÍA IMPONER COMO SANCIÓN?";
			A.text = "Desheredamiento cuando a ello \nhubiere lugar"; //OK
			B.text = "Indignidad para suceder al causante"; 
			C.text = "Indemnización de perjuicios";
			D.text = "Sanciones penales en caso de delito";		

			pregunta.fontSize = 25;
			A.fontSize = 30;
			B.fontSize = 30;
			C.fontSize = 30;
			D.fontSize = 30;	

		} else if(numPregunta == 3){
			pregunta.text = "SEGÚN EL CÓDIGO GENERAL DE PROCESO ¿DESDE QUÉ MOMENTO SE TIENE \nCOMO INCLUIDA LA SOLICITUD DE PARTICIÓN?";
			A.text = "Desde el avaluó";
			B.text = "Desde la adjudicación de bienes";
			C.text = "Desde la contestación de la demanda";
			D.text = "Desde la presentación de la demanda de\n apertura del proceso de sucesión"; //OK

			pregunta.fontSize = 28;
			D.fontSize = 30;	

		} else if(numPregunta == 4){
			pregunta.text = "CUANDO LOS BIENES QUE SE LE HAN ADJUDICADO A UN HEREDERO VALEN\nMUCHO MENOS DE LO SE CONTABILIZÓ SE ACUDE A LA ACCIÓN DE:";
			A.text = "Acción de petición de herencia";
			B.text = "Acción rescisoria de la partición"; //OK
			C.text = "Acción oblicua";
			D.text = "Acción reivindicatoria";

			pregunta.fontSize = 28;

		} else if(numPregunta == 5){
			pregunta.text = "LA PARTICIÓN ES EL PASO MÁS IMPORTANTE DENTRO DEL PROCESO SUCESORIO, YA\n QUE SE PROCEDERÁ A REPARTIR Y ADJUDICAR LA HERENCIA ENTRE LOS ASIGNATARIOS Y\n LEGATARIOS. SEGÚN LA LEY EL PARTIDOR DEBERÁ REALIZARLA EN UN TÉRMINO DE:";
			A.text = "Un año para partir y distribuir\n a partir de su aceptación.";//OK
			B.text = "Dos años para partir y distribuir\n a partir de su aceptación"; 
			C.text = "Cinco años para partir y distribuir\n a partir de su aceptación";
			D.text = "En cualquier momento a partir de \nsu aceptación";

			pregunta.fontSize = 25;

		} else if(numPregunta == 6){
			pregunta.text = "PARA EFECTUAR LA PARTICIÓN DE BIENES DEL DIFUNTO ES INDISPENSABLE\n ESTABLECER DE UN MODO PRECISO Y DETERMINADO, CUAL ES EL PATRIMONIO QUE\n  HA DEJADO, POR LO TANTO, ANTES DE ESTO SE DEBERÁ:";
			A.text = "Disolver la sociedad conyugal"; 
			B.text = "Realizar el inventario y avalúos\n de los bienes de la sucesión ";
			C.text = "Proceder a la separación de patrimonios\n	 pertenecientes a otras personas";//OK
			D.text = "Ninguna de las anteriores";

			pregunta.fontSize = 25;


		} else if(numPregunta == 7){
			pregunta.text = "UNA VEZ REALIZADA LA LIQUIDACIÓN DE LA HERENCIA, ES PROCEDENTE:";
			A.text = "La distribución entre asignatarios.";//OK
			B.text = "La repartición de la porción conyugal";
			C.text = "El llamamiento a los asignatarios";
			D.text = "Ninguna de las anteriores"; 

			pregunta.fontSize = 30;

		} else if(numPregunta == 8){
			pregunta.text = "DESPUÉS DE LA APERTURA DE LA SUCESIÓN, LOS FRUTOS NATURALES \nY CIVILES CORRESPONDEN A:";
			A.text = "Los asignatarios.";
			B.text = "Los legatarios";
			C.text = "Los Herederos"; 
			D.text = "Todas las anteriores";//OK

			pregunta.fontSize = 28;
			A.fontSize = 30;
			B.fontSize = 30;
			C.fontSize = 30;
			D.fontSize = 30;

		} else if(numPregunta == 9){
			pregunta.text = "SI DOS O MÁS PERSONAS FUEREN COASIGNATARIOS DE UN PREDIO, \nEL PARTIDOR PODRÁ SEPARAR";
			A.text = "Los frutos";
			B.text = "La habitación"; //OK
			C.text = "Los gananciales";
			D.text = "La tenencia";

			pregunta.fontSize = 28;

		} else if(numPregunta == 10){
			pregunta.text = "LA EVICCIÓN SE DEFINE COMO LA PRIVACIÓN DEL BIEN, AL SER ADQUIRIDO POR UN TERCERO\n A TRAVÉS DE UN PROCESO DE PERTENENCIA, MEDIANTE SENTENCIA JUDICIAL, PERDIENDO EL ANTERIOR\n DUEÑO CUALQUIER DERECHO SOBRE LA COSA.  EN CONSECUENCIA, EL SANEAMIENTO POR EVICCIÓN\n A CARGO DE LOS PARTÍCIPES, NO PODRECE CUANDO";
			A.text = "Si la evicción o la molestia procediere\n de causa sobreviniente a la partición.";
			B.text = "Si se renunció de manera expresa \na la acción de saneamiento.";
			C.text = "Si la molestia o la evicción ocurren\n por culpa de quien la sufre"; 
			D.text = "todas las anteriores ";//OK

			pregunta.fontSize = 22;

		} else if(numPregunta == 11){
			pregunta.text = "CUANDO DESPUÉS DE TERMINADO EL PROCESO DE SUCESIÓN APAREZCAN NUEVOS\n BIENES DEL CAUSANTE O DE LA SOCIEDAD CONYUGAL, O CUANDO EL PARTIDOR DEJÓ\n DE ADJUDICAR BIENES INVENTARIADOS. PARA ESTOS FINES SE APLICARÁ:";
			A.text = "La partición adicional ";//OK
			B.text = "La partición rehecha ";
			C.text = "Refacción de la partición ";
			D.text = "La suspensión del proceso sucesorio "; 

			pregunta.fontSize = 25;

		} else if(numPregunta == 12){
			pregunta.text = "¿CÓMO DEBE SER EL PAGO DE LAS DEUDAS SUCESORALES O HEREDITARIAS? ";
			A.text = "Estas deben ser asumidas por los herederos a prorrata\n de sus cuotas, es decir, dependiendo la cantidad de la\n herencia que reciba cada heredero, así deberá pagar"; //OK
			B.text = "Deben ser pagadas al momento de la muerte del\n causante, con un plazo de 10 días y por lo tanto se\n configure la entrega del pago sucesoral de manera legal";
			C.text = "El heredero puede aceptar o no de manera\n voluntaria el pago de la deuda, siempre y cuando\n presente un escrito antes de la partición de la sucesión";
			D.text = "B Y C son correctas" ; 

			pregunta.fontSize = 28;
			A.fontSize = 20;
			B.fontSize = 20;
			C.fontSize = 20;
			D.fontSize = 30;

		} else if(numPregunta == 13){
			pregunta.text = "¿EN QUE CASO LA INSOLVENCIA DE UNO DE LOS HEREDEROS GRAVA A LOS OTROS?";
			A.text = "Cuando uno de los herederos no cuenta\n con una póliza de seguros"; 
			B.text = "El heredero no puede declarase nunca \ninsolvente";
			C.text = "Cuando los herederos no están obligados\n a pagar deudas sucesorales";
			D.text = "Cuando los herederos tengan la libre administración de\n sus bienes, o sobre los respectivos tutores o curadores, y\n el marido de la mujer heredera que no está separada de bienes"; //OK

			pregunta.fontSize = 25;
			A.fontSize = 30;
			B.fontSize = 30;
			C.fontSize = 30;
			D.fontSize = 18;

		} else if(numPregunta == 14){
			pregunta.text = "¿QUIÉN REALIZA LA DIVISIÓN DE LAS DEUDAS DADAS POR EL CAUSANTE\n ENTRE LOS HEREDEROS?";
			A.text = "Partidor"; //OK
			B.text = "Coheredero"; 
			C.text = "Legatario";
			D.text = "Causante";

			pregunta.fontSize = 28;
			D.fontSize = 30;

		} else if(numPregunta == 15){
			pregunta.text = "CUANDO SE ACEPTA LA HERENCIA CON BENEFICIO DE INVENTARIO, \nSE ENTIENDE QUE:";
			A.text = "Quedará el heredero responsable de todas las cargas de la\n herencia, no sólo con los bienes de ésta, sino también\n con los suyos propios"; 
			B.text = "Al pago Las costas comunes de la partición \nen su totalidad";
			C.text = "El heredero no estará obligado al pago de ninguna\n parte de las deudas hereditarias sino hasta concurrencia\n de lo que valga lo que hereda";//OK
			D.text = "La responsabilidad del heredero será ilimitada\n y solidaria";

			pregunta.fontSize = 28;
			A.fontSize = 20;
			B.fontSize = 25;
			C.fontSize = 20;
			D.fontSize = 25;

		} else if(numPregunta == 16){
			pregunta.text = "EN LA PARTICIÓN, PARA CUBRIR LAS DEUDAS HEREDITARIAS Y GASTOS\nDEL PROCESO SUCESORAL, SE DETERMINA COMO PRINCIPIO RECTOR DE ESTA ETAPA EL";
			A.text = "Principio de consonancia"; 
			B.text = "Principio de igualdad ";//OK
			C.text = "Principio de legalidad";
			D.text = "principio de inmediación ";

			pregunta.fontSize = 25;
			A.fontSize = 30;
			B.fontSize = 30;
			C.fontSize = 30;
			D.fontSize = 30;
		}
	}


	public void validarRespuesta(){
		if(numPregunta == 1 && rta == 3){
			Debug.Log("Bien!");
		}else if(numPregunta == 2 && rta == 1){
			Debug.Log("Bien!");
		}else if(numPregunta == 3 && rta == 4){
			Debug.Log("Bien!");
		}else if(numPregunta == 4 && rta == 2){
			Debug.Log("Bien!");
		}else if(numPregunta == 5 && rta == 1){
			Debug.Log("Bien!");
		}else if(numPregunta == 6 && rta == 3){
			Debug.Log("Bien!");
		}else if(numPregunta == 7 && rta == 1){
			Debug.Log("Bien!");
		}else if(numPregunta == 8 && rta == 4){
			Debug.Log("Bien!");
		}else if(numPregunta == 9 && rta == 2){
			Debug.Log("Bien!");
		}else if(numPregunta == 10 && rta == 4){
			Debug.Log("Bien!");
		}else if(numPregunta == 11 && rta == 1){
			Debug.Log("Bien!");
		}else if(numPregunta == 12 && rta == 1){
			Debug.Log("Bien!");
		}else if(numPregunta == 13 && rta == 4){
			Debug.Log("Bien!");
		}else if(numPregunta == 14 && rta == 1){
			Debug.Log("Bien!");
		}else if(numPregunta == 15 && rta == 3){
			Debug.Log("Bien!");
		}else if(numPregunta == 16 && rta == 2){
			Debug.Log("Bien!");
		}				
	}


	public void respuestaA(){
		rta = 1;
	}

	public void respuestaB(){
		rta = 2;
	}

	public void respuestaC(){
		rta = 3;
	}

	public void respuestaD(){
		rta = 4;
	}

	public void CincuentaXcincuenta(){
		if(numPregunta == 1){
			rA.SetActive(false);
			rB.SetActive(false);

		}else if(numPregunta == 2){
			rB.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 3){
			rA.SetActive(false);
			rB.SetActive(false);

		}else if(numPregunta == 4){
			rA.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 5){
			rB.SetActive(false);
			rD.SetActive(false);

		}else if(numPregunta == 6){
			rA.SetActive(false);
			rD.SetActive(false);

		}else if(numPregunta == 7){
			rC.SetActive(false);
			rD.SetActive(false);

		}else if(numPregunta == 8){
			rA.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 9){
			rA.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 10){
			rA.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 11){
			rC.SetActive(false);
			rD.SetActive(false);

		}else if(numPregunta == 12){
			rB.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 13){
			rA.SetActive(false);
			rB.SetActive(false);

		}else if(numPregunta == 14){
			rB.SetActive(false);
			rC.SetActive(false);

		}else if(numPregunta == 15){
			rA.SetActive(false);
			rD.SetActive(false);

		}else if(numPregunta == 16){
			rA.SetActive(false);
			rD.SetActive(false);
		}
	}

	public void llamaAmigo(){
		if(numPregunta == 1){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nC";

		}else if(numPregunta == 2){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nA";

		}else if(numPregunta == 3){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nD";

		}else if(numPregunta == 4){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nB";

		}else if(numPregunta == 5){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nA";

		}else if(numPregunta == 6){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nC";

		}else if(numPregunta == 7){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nA";

		}else if(numPregunta == 8){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nD";;

		}else if(numPregunta == 9){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nB";

		}else if(numPregunta == 10){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nD";

		}else if(numPregunta == 11){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nA";

		}else if(numPregunta == 12){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nA";

		}else if(numPregunta == 13){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nD";

		}else if(numPregunta == 14){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nA";

		}else if(numPregunta == 15){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nC";

		}else if(numPregunta == 16){
			panelLlamada.SetActive(true);
			respuesta.text = "La respuesta correcta es la\nB";
		}
	}

	public void terminarLlamada(){
		panelLlamada.SetActive(false);
	}



}
