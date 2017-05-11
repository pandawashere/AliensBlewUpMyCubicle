using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour {


	public void LoadEnding(int sceneIndex){
		if (JeffEnding.Ending == "Buff") {
			SceneManager.LoadScene (57);
		} else if (JeffEnding.Ending == "Marry") {
			SceneManager.LoadScene (67);
		}
	}
}
