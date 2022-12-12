using UnityEngine;

public class engelSpawner : MonoBehaviour
{
    public GameObject prefabs;
    public GameObject[] prefabs2;
    

    public float spawnoran = 1f;
    public float minHeight = -1f;

    public float maxHeight = 1f;

    int randomnumber;
    private void spawn()
    {

        randomnumber = Random.Range(0, prefabs2.Length);
        GameObject engel = Instantiate(prefabs2[randomnumber], transform.position,Quaternion.identity);
       

        engel.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        
    }
    private void OnEnable()
    {
       
        InvokeRepeating(nameof(spawn), spawnoran, spawnoran);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(spawn));
    }
}
