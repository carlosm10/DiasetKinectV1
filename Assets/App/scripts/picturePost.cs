using UnityEngine;
using System.Collections;

public class PicturePost : MonoBehaviour {

	//public string screenShotURL = "localhost/webservice-kinect/upload_file.php";
	public string screenShotURL = "http://201.134.41.123/kinect/upload_file.php";
	//public string screenShotURL = "http://172.16.252.30/kinect/upload_file.php";


	// Use this for initialization
	void Start () {
		//StartCoroutine (uploadPNG());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator uploadPNG(string picture_name){
		// We should only read the screen after all rendering is complete
		yield return new WaitForEndOfFrame();

		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		var tex = new Texture2D( width, height, TextureFormat.RGB24, false );

		// Read screen contents into the texture
		tex.ReadPixels( new Rect(0, 0, width, height), 0, 0 );
		tex.Apply();

		// Encode texture into PNG
		byte[] bytes = tex.EncodeToPNG();
		Destroy( tex );

		// Create a Web Form
		WWWForm form = new WWWForm();
		form.AddField("frameCount", Time.frameCount.ToString());

		// form.AddBinaryData("file", bytes, "screenShot.png", "image/png");

		// Custom name of the file depending on the date and time.
		form.AddBinaryData("file", bytes, picture_name+".png", "image/png");

		// Upload to a cgi script
		WWW w = new WWW(screenShotURL, form);
		yield return w;
		if (!string.IsNullOrEmpty(w.error)) {
			//print(w.error);
			Debug.Log(w.error);
		}
		else {
			//print("Finished Uploading Screenshot");
			Debug.Log ("Finished Uploading Screenshot" +w.text);
		}
	}
}
