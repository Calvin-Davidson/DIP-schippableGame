using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject block;
    private Transform spawnPosTrans;
    public Material rainbow;
    private void Start()
    {
        spawnPosTrans = GameObject.Find("SpawnPos").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) // right click
        {
            spawnPosTrans.position = new Vector3(spawnPosTrans.position.x, spawnPosTrans.position.y, 0);
            GameObject spawned = Instantiate(block, spawnPosTrans.position, Quaternion.identity);

            int r = Random.Range(0, 10); // 0-1
            if (r == 0)
            {
                spawned.GetComponent<MeshRenderer>().material = rainbow;
            }
            else
            {
                Color[] colors = new Color[] { Color.red, Color.green, Color.yellow, Color.blue, Color.magenta};

                Color c = colors[Random.Range(0, colors.Length)];
                spawned.GetComponent<MeshRenderer>().material.color = c; 
            }
        }
    }
}