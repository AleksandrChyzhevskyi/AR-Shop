using UnityEngine;
using Vuforia;

public class CustomTown : MonoBehaviour
{
    public GameObject fadeTower;
    public PlaneFinderBehaviour planeFinder;

    public void HandleAutometicTest(HitTestResult result)
    {
        var rendererComponents = planeFinder.GetComponentsInChildren<Renderer>(true);
        var colliderComponents = planeFinder.GetComponentsInChildren<Collider>(true);
        var canvasComponents = planeFinder.GetComponentsInChildren<Canvas>(true);
        
        foreach (var component in rendererComponents)
            component.enabled = true;
        
        foreach (var component in colliderComponents)
            component.enabled = true;
        
        foreach (var component in canvasComponents)
            component.enabled = true;

        if (fadeTower.activeSelf)
            fadeTower.SetActive(true);

        fadeTower.transform.position = result.Position;
    }
}
