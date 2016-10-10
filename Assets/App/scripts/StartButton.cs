using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartButton : MonoBehaviour {

	public GameObject maquina;
	public GameObject usuario;

	private string maquina_string;
	private string usuario_string;

	public Button startButton;

	void Start() {
		Button btn = startButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick() {
		usuario_string = usuario.GetComponent<InputField>().text;
		maquina_string = maquina.GetComponent<InputField>().text;
		Debug.Log ("Usuario: " +usuario_string);
		Debug.Log ("Maquina: " +maquina_string);
		Session_app.current_user = usuario_string;
		Session_app.current_machine = maquina_string;

		SceneManager.LoadScene ("usersDetection");

	}
}