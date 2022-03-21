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

    private static IEnumerator SleepThenSwitch()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(0);
    }
    
}
