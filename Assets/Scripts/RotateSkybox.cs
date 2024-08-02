using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    private float rotationSpeed = 1.0f;
    public Material skyboxMaterial;

    private Gyroscope gyro;

    void Start()
    {
        gyro = Input.gyro;

        if (SystemInfo.supportsGyroscope)
        {
            gyro.enabled = true;
        }
    }

    void Update()
    {
        if (gyro.enabled)
        {
            skyboxMaterial.SetVector("_Rotation", gyro.attitude.eulerAngles);
        }
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
