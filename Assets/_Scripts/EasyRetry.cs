using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EasyRetry : MonoBehaviour {


	public void LoadRetry(int sceneIndex){
		if (EasyMode.Easy == "Yes") {
			SceneManager.LoadScene (sceneIndex);
		} else {
			SceneManager.LoadScene (28);
		}
	}
}
