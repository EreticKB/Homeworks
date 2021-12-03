using UnityEngine;
using Random = System.Random;

public class LevelGenerate : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float DistanceBetweenPlatforms;
    public Transform CylinderRoot;
    public Game Seed;

    private float _cylinderScale = 1f;

    private void Awake()
    {
        Random random = new Random(Seed.LevelIndex);
        int CurrentPlaforms = RandomRange(random, MinPlatforms, MaxPlatforms + 1);
        for (int i=1; i <= CurrentPlaforms; i++)
        {
            int platformIndex = RandomRange(random, 1, PlatformPrefabs.Length);
            GameObject platform = Instantiate(PlatformPrefabs[platformIndex], transform);
            platform.transform.localPosition = new Vector3(0, -DistanceBetweenPlatforms * i, 0);
            platform.transform.rotation = Quaternion.Euler(0, RandomRange(random, 0f, 360f), 0);
        }
        PlatformPrefabs[0].transform.localPosition = new Vector3(0, -DistanceBetweenPlatforms * (CurrentPlaforms + 1), 0);
        CylinderRoot.localScale = new Vector3(1, (CurrentPlaforms + 2) * _cylinderScale, 1);
    }

    private int RandomRange(Random random, int Min, int MaxExclusive)
    {
        return random.Next(Min, MaxExclusive);
    }

    private float RandomRange(Random random, float Min, float Max)
    {
        float t = (float)random.NextDouble();
        return Mathf.Lerp(Min, Max, t);
    }
}
