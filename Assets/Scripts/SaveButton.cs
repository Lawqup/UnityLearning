using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public string savedText;
    public GameObject currText;
    public AudioSource onClickAudio;
    public void Start()
    {
        savedText = PlayerPrefs.GetString("SavedNote");
        currText.GetComponent<InputField>().text = savedText;
    }

    public void Save()
    {
        savedText = currText.GetComponent<InputField>().text;
        PlayerPrefs.SetString("SavedNote", savedText);
        onClickAudio.Play();

        var script = FindObjectOfType(typeof(SpinAnimation)) as SpinAnimation;
        if (script != null) script.ShowIcon();
    }
}
