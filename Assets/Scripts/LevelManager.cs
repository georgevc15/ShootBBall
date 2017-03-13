using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            FinishGame();
        }
    }

    void StartGame()
    {
            //Load Scene
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            //Load currentIndex + 1
            SceneManager.LoadScene(currentIndex + 1);
    }


    void FinishGame()
    {
        //Load Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //Load currentIndex + 1
        SceneManager.LoadScene(currentIndex + 1);
    }

}
