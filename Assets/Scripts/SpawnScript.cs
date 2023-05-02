using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject TubePrefab;

    private float spawnTime;
    private float leftTime;

    private void Start()
    {
        spawnTime = 3f; // 3 sec
        leftTime = 0f;
    }

    private void Update()
    {
        leftTime -= Time.deltaTime;

        if (leftTime <= 0f)
        {
            // spawn
            GameObject.Instantiate(
                TubePrefab,
                this.transform.position + Vector3.up * Random.Range(-2.6f, 2.6f),
                Quaternion.identity);
            
            leftTime = spawnTime; // следующий отсчет
        }
    }
}
