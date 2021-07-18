using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class golevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playlevel(string levelname){
		Application.LoadLevel (levelname);    
    }

    public void LoadScene(string levelname){
        SceneManager.LoadScene(levelname );       
        // SceneManager.UnloadSceneAsync(levelname);

    }

    public void QuitGame() {
        Application.Quit();
    }


}
