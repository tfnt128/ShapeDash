using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public Camera orthographicCamera;
    public Camera perspectiveCamera;

    public float transitionDuration = 2.0f;
    private float transitionTimer = 0.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCameraTransition();
        }

        if (transitionTimer < transitionDuration)
        {
            transitionTimer += Time.deltaTime;

            float t = Mathf.Clamp01(transitionTimer / transitionDuration);

            orthographicCamera.orthographicSize = Mathf.Lerp(orthographicCamera.orthographicSize, 0, t);
            perspectiveCamera.fieldOfView = Mathf.Lerp(perspectiveCamera.fieldOfView, 60, t);
        }
    }

    public void StartCameraTransition()
    {
        transitionTimer = 0.0f;
    }
}
