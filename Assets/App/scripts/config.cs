using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text.RegularExpressions;
using System;

public class config : MonoBehaviour {

	public GameObject maquina;
	public GameObject usuario;
	public Button iniciar;

	private string Maquina;
	private string Usuario;

	// Use this for initialization
	void Start () {
		
	}

	public void StartButton(){
		Debug.Log ("Info OK!");
	}
	
	// Update is called once per frame
	void Update () {
		Maquina = maquina.GetComponent<InputField> ().text;
		Usuario = usuario.GetComponent<InputField> ().text;
		if(iniciar.(KeyCode.Return)){
			if(Maquina != "" && Usuario != ""){
				StartButton ();
			}
		}	
	}
}
