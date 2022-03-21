using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject noteText;
    public AudioSource onClickAudio;
    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void ClearText()
    {
        noteText.GetComponent<InputField>().text = "";
        onClickAudio.Play();
    }

    public void CancelExit()
    {
        panel.SetActive(false);
    }

    public void ExitPanel()
    {
        panel.SetActive(true);
    }

    public void SaveAndQuit()
    {
        var script = FindObjectOfType(typeof(SaveButton)) as SaveButton;
        if (script != null) script.Save();
        Quit();
    }

    public static void Quit()
    {
        Application.Quit();
    }
}
