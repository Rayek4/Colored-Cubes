using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{

    public Image finger;
    public Text text;
    public GameObject player;
    public GameObject passedObject;
    



    public int nextSceneLoad;
    void Start()
    {
        
        passedObject.SetActive(false);

        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            finger.enabled = false;
            text.enabled = false;
            

        }

        if (player.transform.childCount == 0)
        {

            passedObject.SetActive(true);
        }

    }

    public void Next()
    {


        if (SceneManager.GetActiveScene().buildIndex == 6) /* < Change this int value to whatever your
                                                                   last level build index is on your
                                                                   build settings */
        {
            Debug.Log("You Completed ALL Levels");

            //Show Win Screen or Somethin.
        }
        else
        {
            //Move to next level
            SceneManager.LoadScene(nextSceneLoad);

            //Setting Int for Index
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
