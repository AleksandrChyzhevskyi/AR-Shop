using UnityEngine;
using UnityEngine.UI;

public class TrackImage : DefaultObserverEventHandler
{
    public Sprite notDetected, detected;
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void ChangeImageTrack(bool isTracking)
    {
        _image.sprite = isTracking ? detected : notDetected;
    }

    protected override void OnTrackingFound()
    {
        ChangeImageTrack(true);
    }
    protected override void OnTrackingLost()
    {
        ChangeImageTrack(false);
    }
}
