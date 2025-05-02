using UnityEngine;

[ExecuteAlways]
public class CameraScaler : MonoBehaviour
{
    private const float REFERENCE_WIDTH = 1080f;
    private const float REFERENCE_HEIGHT = 1920f;
    private const float INITIAL_ORTHOGRAPHIC_SIZE = 5f;
    private const float REFERENCE_ASPECT = REFERENCE_WIDTH / REFERENCE_HEIGHT;

    [SerializeField]
    private Camera cam;

    private void Update()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        if (currentAspect >= REFERENCE_ASPECT)
        {
            this.cam.orthographicSize = INITIAL_ORTHOGRAPHIC_SIZE;
        }
        else
        {
            float sizeRatio = REFERENCE_ASPECT / currentAspect;
            this.cam.orthographicSize = INITIAL_ORTHOGRAPHIC_SIZE * sizeRatio;
        }
    }
}