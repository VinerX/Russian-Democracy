using UnityEngine.SceneManagement;
using UnityEngine;
//using UnityEngine.VideoModule;
public class NewGame : MonoBehaviour
{       
    Scene SceneNow;
    Scene SceneTo;
    public GameObject AAA;
    void StartNewGame(){
        
        AAA.SetActive(true);
        Scene SceneNow=SceneManager.GetActiveScene();
        
        SceneManager.LoadSceneAsync("MainGameMenu",LoadSceneMode.Single);
        Debug.Log("Есть Контакт");
        SceneTo=SceneManager.GetSceneByName("MainGameMenu");
        
        SceneManager.MergeScenes(SceneNow,SceneTo);


    }
    // void SceneManager.sceneLoaded(){

    // }

}
