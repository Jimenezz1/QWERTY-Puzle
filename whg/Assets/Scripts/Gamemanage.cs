
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanage : MonoBehaviour
{

   // private int nextSceneToLoad;

    bool gameHasEnded = false;

  public void EndGame()
	{
        if(gameHasEnded == false)
		{
            gameHasEnded = true;
            Restart();
		}
	}
    /*
    public void Start()
	{
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
	}

   /* private void OnTriggerEnter(Collider other)
	{
        if(other.gameObject.tag == "Win")
		{
            SceneManager.LoadScene(nextSceneToLoad);
		}
	}


    */




    void Restart()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
   
}
