using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] float zoomSensitivity = 0.1f;
    private Camera camera;
    private Actions actions;
    void Start()
    {
        camera = gameObject.GetComponent<Camera>();
    }
    void Awake()
    {
        actions = new Actions();
        actions.camera.zoom.performed += ZoomUpdate;
    }
    void OnEnable()
    {
        actions.Enable();
    }

    void ZoomUpdate(InputAction.CallbackContext context)
    {
        float value = context.ReadValue<float>();
        camera.fieldOfView  += value * zoomSensitivity;
    }
}
