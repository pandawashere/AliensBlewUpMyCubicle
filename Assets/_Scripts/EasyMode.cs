using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyMode : MonoBehaviour {

	public static string Easy = "No" ;


	public void LoadByIndex(int sceneIndex){
		Easy = "Yes";
		SceneManager.LoadScene (sceneIndex);
	}
}
