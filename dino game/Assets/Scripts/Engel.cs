using UnityEngine;

public class Engel : MonoBehaviour
{
    public float speed = 5.61f;

    private float ArkadaKalanlar;

    void Start()
    {
        ArkadaKalanlar = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < ArkadaKalanlar)
        {
            Destroy(gameObject);
        }
    }
}
