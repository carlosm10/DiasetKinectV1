using UnityEngine;
using System.Collections;

public class PostJsonData : MonoBehaviour {

	// Use this for initialization
	string Url;
	void Start () {
		Url = "localhost/webservice-kinect/webservice.php";
		//PostData(100,"Unity");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PostData(int evento, string name, string time){
		WWWForm dataParameters = new WWWForm ();
		dataParameters.AddField ("name", name);
		dataParameters.AddField ("event", evento);
		dataParameters.AddField ("time", time);
		Debug.Log ("User: "+name);
		Debug.Log ("Event: "+evento);
		Debug.Log ("Time: "+time);

		WWW www = new WWW (Url,dataParameters);
		StartCoroutine (PostdataEnumerator(www));

	}

	IEnumerator PostdataEnumerator(WWW www){
		yield return www;
		if(www.error == null){
			Debug.Log("respuesta: " +www.text);
		}else{
			Debug.Log(www.error);
		}
	}
}
