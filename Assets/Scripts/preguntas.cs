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
		//D = GetComponent<Text>();
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
			pregunta.text = "¿Cuál es la ley que reforma y adiciona nuevos aspectos \nde la sucesión al código civil?";
			A.text = "LEY 1901 DE 2018";
			B.text = "LEY 1882 DE 2018";
			C.text = "LEY 1934 DE 2018 "; //OK
			D.text = "LEY 1905 DE 2018";

		}else if(contador == 2){
			pregunta.text = "Las asignaciones forzosas son  las que el testador esta obligado a hacer, y que\n  se suplen cuando no las ha hecho, aún con perjuicio de sus voluntad, asi las\n cosas ¿cuál es la asignación forzosa que elimina la ley 1934 de 2018?";
			A.text = "LAS LEGÍTIMAS";
			B.text = "LA CUARTA DE MEJORAS"; //OK
			C.text = "LA PORCIÓN CONYUGAL ";
			D.text = "LOS ALIMENTOS QUE SE DEBEN \nPOR LEY A CIERTAS PERSONAS";		

			pregunta.fontSize = 30;
			D.fontSize = 30;	

		} else if(contador == 3){
			pregunta.text = "El legitimario no puede ser privado de la parte de la herencia que le corresponde\n según la ley. ¿quiénes son legitimarios con la ley 1934 de 2018?";
			A.text = "LOS PADRES ADOPTIVOS";
			B.text = "LOS HIJOS LEGÍTIMOS";
			C.text = "LOS HIJOS EXTRAMATRIMONIALES";
			D.text = "LOS DESCENDIENTES PERSONALMENTE O REPRESENTADOS Y LOS ASCENDIENTES"; //OK

			pregunta.fontSize = 30;

		} else if(contador == 4){
			pregunta.text = "El beneficio de inventario consiste en no hacer a los herederos que aceptan, responsables \nde las obligaciones hereditarias o testamentarias, sino hasta el valor total de los bienes\n que han heredado.  ¿quién no puede aceptar la herencia con beneficio de inventario?";
			A.text = "EL QUE HIZO ACTO DE HEREDERO SIN PREVIO INVENTARIO SOLEMNE"; //OK
			B.text = "LAS PERSONAS JURÍDICAS DE DERECHO PÚBLICO";
			C.text = "LOS HEREDEROS FIDUCIARIOS";
			D.text = "LOS INCAPACES";

			pregunta.fontSize = 25;

		} else if(contador == 5){
			pregunta.text = "Con la muerte del causante se transmiten todos sus bienes, derechos y\nobligaciones a los herederos, pero existen algunos derechos que no son transmisibles,\n conocidos como derechos extrapatrimoniales, entre ellos están:";
			A.text = "BIENES INMUEBLES Y MUEBLES ";
			B.text = "DERECHO REAL DE USUFRUCTO Y DE USO Y HABITACIÓN "; //OK
			C.text = "DERECHO PATRIMONIAL ";
			D.text = "BIENES SUCEPTIBLES A COMERCIALIZACIÓN ";

			pregunta.fontSize = 30;

		} else if(contador == 6){
			pregunta.text = "¿Cuál es la facultad que tiene un sujeto para poder reclamar y recibir herencia?";
			A.text = "VOCACIÓN HEREDITARIA O SUCESORAL "; //OK
			B.text = "VOCACIÓN LEGAL ";
			C.text = "VOCACIÓN POR CABEZAS O ESTIRPES";
			D.text = "VOCACIÓN TESTAMENTARIA ";

		} else if(contador == 7){
			pregunta.text = "El proceso sucesorio tiene como objeto transmitir el patrimonio de una persona\n  muerta a sus sucesores o asignatarios, de conformidad a lo establecido en la\n ley o el testamento; este proceso se puede tramitar ante:";
			A.text = "ANTE UN NOTARIO";
			B.text = "ANTE EL JUEZ";
			C.text = "ANTE LA DEFENSORIA DEL PUEBLO";
			D.text = "A Y B SON LAS CORRECTAS"; //OK

			pregunta.fontSize = 30;

		} else if(contador == 8){
			pregunta.text = "El carácter de heredero, se adquiere con la muerte del causante, sin embargo \naquel necesita requisitos para acreditar su calidad; por lo anterior este debe:";
			A.text = "SER LLAMADO EXPRESAMENTE POR EL CAUSANTE PARA PARTICIPAR EN EL PROCESO";
			B.text = "SER DECLARADO HIJO LEGÍTIMO DEL CAUSANTE";
			C.text = "TENER CAPACIDAD SUCESORAL, VOCACIÓN HEREDITARIA Y DIGNIDAD SUCESORAL"; //OK
			D.text = "SER MAYOR DE EDAD";

			pregunta.fontSize = 30;

		} else if(contador == 9){
			pregunta.text = "La sucesión es el conjunto de normas que regulan el destino del patrimonio\n de una persona que ha fallecido, y en consecuencia se transmite el dominio;\n según lo anterior las clases de sucesiones son:";
			A.text = "DERIVATIVA Y GRATUITA";
			B.text = "TESTADA, INTESTADA Y MIXTA"; //OK
			C.text = "ÚNICAMENTE TESTADA";
			D.text = "TODAS LAS ANTERIORES";

			pregunta.fontSize = 30;

		} else if(contador == 10){
			pregunta.text = "Para que la sucesión nazca y tenga efectos se requiere obligatoriamente\n de ciertos elementos; estos son:";
			A.text = "EL PROPIETARIO, FAMILIARES Y ACREEDORES";
			B.text = "CAUSANTE BIENES Y DEUDAS";
			C.text = "CAUSANTE, HERENCIA Y ASIGNATARIOS"; //OK
			D.text = "HEREDERO, LEGATARIO Y TESTAMENTO";

			pregunta.fontSize = 30;

		} else if(contador == 11){
			pregunta.text = "Teniendo en cuenta los órdenes sucesorales regulados por el código civil,\n y siendo usted representante del ICBF, a que orden pertenecería:";
			A.text = "PRIMER ORDEN";
			B.text = "SEGUNDO ORDEN";
			C.text = "CUARTO ORDEN";
			D.text = "QUINTO ORDEN"; //OK

			pregunta.fontSize = 30;

		} else if(contador == 12){
			pregunta.text = "La herencia es un derecho que tiene un asignatario sobre los bienes, derechos y\n obligaciones del causante y para garantizar la ley establece modos de \nadquirirla, ¿Cuáles de estos no es uno de ellos?";
			A.text = "POR ACRECIMIENTO";
			B.text = "POR CESIÓN DE DERECHOS SUCESORALES";
			C.text = "POR PRESCRIPCIÓN";
			D.text = "POR PROMESA DE CESIÓN"; //OK

			pregunta.fontSize = 30;

		} else if(contador == 13){
			pregunta.text = "La indignidad sucesoral es una sanción de tipo civil que se impone al heredero\n culpable por haber proferido un agravia al causante, una de las causales\n de indignidad seria?";
			A.text = "EL HEREDERO O LEGATARIO QUE COMETIO CRIMEN DE HOMICIDIO AL CAUSANTE"; //OK
			B.text = "EL HEREDERO QUE DENUNCIO A LA JUSTICIA LA MUERTE DEL CAUSANTE";
			C.text = "EL HEREDERO QUE  NO ES JUDICIALMENTE RECONOCIDO COMO INDIGNO";
			D.text = "NINGUNA DE LAS ANTERIORES ";

			pregunta.fontSize = 30;

		} else if(contador == 14){
			pregunta.text = "Con respecto a la naturaleza de la acción de petición de herencia y la acción\n reivindicatoria, recaen sobre derechos reales y en cuanto a su finalidad, ambas:";
			A.text = "DAN ORIGEN A UN JUICIO EN DONDE SE DISCUTE LA CALIDAD DE PROPIETARIO";
			B.text = "PERSIGUEN LA RESTITUCIÓN DE LOS BIENES AL VERDADERO TITULAR DEL DERECHO DE DOMINIO"; //OK
			C.text = "RECAEN SOBRE DERECHOS PERSONALES";
			D.text = "TIENEN POR OBJETO RECLAMAR UNA COSA CIERTA, SINGULAR Y DETERMINADA";

			pregunta.fontSize = 30;

		} else if(contador == 15){
			pregunta.text = "El derecho sucesoral se destaca por su repercusión enconomica y\n social según la estructura de cada país, esta rama del derecho se encarga de:";
			A.text = "ESTUDIAR Y REGULAR A TRAVES DE NORMAS SUSTANCIALES Y PROCESALES TODO LO CONCERNIENTE A DERECHOS Y OBLIGACIONES EN UNA SUCESION POR CAUSA DE MUERTE"; //OK
			B.text = "EL ESTUDIO DE LAS OBLIGACIONES EN GENERAL Y LOS CONTRATOS";
			C.text = "ANALIZAR, ORGANIZAR Y CLASIFICAR LA NORMATIVIDAD RELACIONADA CON LA ADMINISTRACION PUBLICA Y SU FUNCIONAMIENTO";
			D.text = "REGULAR LAS RELACIONES DE LA INSTITUCIÓN FAMILIAR FRENTE A TERCEROS";

			pregunta.fontSize = 30;
		}
	}

	public void fontSizeChange(){
		D.fontSize = 10;
	}

}
