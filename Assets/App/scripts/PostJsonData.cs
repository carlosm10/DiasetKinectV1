using UnityEngine;
using System.Collections;

public class PostJsonData : MonoBehaviour {


	//public string Url = "localhost/webservice-kinect/webservice.php";
	public string Url = "http://201.134.41.123/kinect/webservice.php";
	//public string Url = "http://172.16.252.30/kinect/webservice.php";

	void Start () {
		//Url = "localhost/webservice-kinect/webservice.php";
		//PostData(100,"Unity");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PostData(int evento, string name, string time, string machine){
		WWWForm dataParameters = new WWWForm ();
		dataParameters.AddField ("name", name);
		dataParameters.AddField ("event", evento);
		dataParameters.AddField ("time", time);
		dataParameters.AddField ("machine", machine);
		Debug.Log ("User: "+name);
		Debug.Log ("Event: "+evento);
		Debug.Log ("Time: "+time);
		Debug.Log ("Machine: "+machine);

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
