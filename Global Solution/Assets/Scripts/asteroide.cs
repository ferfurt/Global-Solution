using UnityEngine;

public class asteroide : MonoBehaviour
{
    public float velocidade = 1.5f;

    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        print("meteorito destruido");
    }

}
