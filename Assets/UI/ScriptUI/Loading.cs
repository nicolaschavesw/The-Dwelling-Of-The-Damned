using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
     void Start() {
        
        string levelToLoad=LevelLoader.nextLelevel;
        StartCoroutine(this.MakeTheLoad(levelToLoad));

    }


    IEnumerator MakeTheLoad(string level)
    {
        yield return new WaitForSeconds(1f);
        AsyncOperation operation= SceneManager.LoadSceneAsync(level);


        while(operation.isDone == false)
        {
            yield return null;
        }
    }
}
