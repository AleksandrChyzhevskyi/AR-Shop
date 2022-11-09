using System.Collections;
using UnityEngine;

public class TakeScrinShot : MonoBehaviour
{
    private GameObject _image;

    private void Start()
    {
        _image = transform.GetChild(0).gameObject;
    }
    public void MakeCapture()
    {
        _image.SetActive(false);
        StartCoroutine(ScreenShot());
    }

    IEnumerator ScreenShot()
    {
        yield return new WaitForEndOfFrame();

        Texture2D texture2D = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        texture2D.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture2D.Apply();

        NativeGallery.SaveImageToGallery(texture2D, "Photo in AR", "My image {0}");

        _image.SetActive(true);
    }
}
