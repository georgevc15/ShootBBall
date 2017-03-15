using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float timeTillNextLevel = 0.0f;
    
    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //quit the game
        if(Input.GetKeyDown(KeyCode.Q))
        {
            LoadNextScene();
        }
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;

            if (timeTillNextLevel < 0)
            {
                LoadNextScene();
            }
        }
    }

    public void LoadNextScene()
    {
            //Load Scene
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            //Load currentIndex + 1
            SceneManager.LoadScene(currentIndex + 1);
    }


    public void FinishGame()
    {
        //Load Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //Load currentIndex + 1
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadPreviousScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //Go back to play the game again
        SceneManager.LoadScene(currentIndex - 1);
    }

}
