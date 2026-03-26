using UnityEngine;
using System;

public class TimeSystem : MonoBehaviour
{
    private const float DAY_LENGTH = 24f; // Length of the day in hours
    private float currentTime; // Current time in hours
    private Light sun;

    void Start()
    {
        currentTime = 0f; // Start at 0 hours
        sun = GetComponent<Light>(); // Assuming a Light component is attached
    }

    void Update()
    {
        UpdateTime();
        UpdateSunPosition();
        UpdateLighting();
    }

    private void UpdateTime()
    {
        currentTime += Time.deltaTime / (DAY_LENGTH * 3600f); // Update time based on time passed
        if (currentTime >= 24f)
        {
            currentTime -= 24f; // Reset time after a day
        }
    }

    private void UpdateSunPosition()
    {
        // Calculate sun's angle based on the current time
        float sunAngle = (currentTime / DAY_LENGTH) * 360f;
        sun.transform.localRotation = Quaternion.Euler(sunAngle - 90, 170, 0);
    }

    private void UpdateLighting()
    {
        float intensity = Mathf.Clamp01(1f - Mathf.Abs((currentTime - 12f) / 12f)); // Mimic day/night cycles
        sun.intensity = intensity;
    }

    public float GetCurrentTime()
    {
        return currentTime;
    }
}