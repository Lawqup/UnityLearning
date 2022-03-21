using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToMainScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SleepThenSwitch());
    }

    IEnumerator SleepThenSwitch()
    {
        yield return new WaitForSeconds(2);
        
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainScreen");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    
}
