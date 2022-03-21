using UnityEngine;
using UnityEngine.UI;

public class SpinAnimation : MonoBehaviour
{


    public RectTransform icon;
    public float timeStep;
    public float angleStep;    
    public float duration;

    private Image _iconImage;
    private float _startTime;
    private float _prevUpdateTime;
    private bool _startAnim;
    
    public void ShowIcon()
    {
        var opaque = _iconImage.color;
        opaque.a = 255;
        
        _iconImage.color = opaque;
        _startAnim = true;
        _startTime = Time.time;
        _prevUpdateTime = Time.time;
    }
    
    private void HideIcon()
    {
        var transparent = _iconImage.color;
        transparent.a = 0;
        
        icon.rotation = new Quaternion(0, 0, 0, 0);
        _iconImage.color = transparent;
        _startAnim = false;
    }

    private void Start()
    {
        _iconImage = icon.GetComponent<Image>();
    }
    
    private void Update()
    {
        if (!_startAnim)
        {
            return;
        }
        
        if (Time.time - _startTime >= duration)
        {
            HideIcon();
        } 
        else if (Time.time - _prevUpdateTime >= timeStep)
        {
            icon.Rotate(new Vector3(0, 0, angleStep));
            _prevUpdateTime = Time.time;
        }
    }
}
