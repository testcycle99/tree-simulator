using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public enum BiomeType
    {
        FOREST,
        RIVERSIDE,
        LAKESIDE,
        MOUNTAINS
    }

    public BiomeType currentBiome;

    void Start()
    {
        AdjustLighting(currentBiome);
    }

    void AdjustLighting(BiomeType biome)
    {
        switch (biome)
        {
            case BiomeType.FOREST:
                RenderSettings.ambientLight = Color.green;
                break;
            case BiomeType.RIVERSIDE:
                RenderSettings.ambientLight = Color.blue;
                break;
            case BiomeType.LAKESIDE:
                RenderSettings.ambientLight = new Color(0.5f, 0.7f, 1.0f);
                break;
            case BiomeType.MOUNTAINS:
                RenderSettings.ambientLight = new Color(0.6f, 0.6f, 0.6f);
                break;
        }
    }
}