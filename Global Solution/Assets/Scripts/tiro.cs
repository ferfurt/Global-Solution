using UnityEngine;

public class tiro : MonoBehaviour
{
    public float velocidade = 10f;

    void Update()
    {
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);
    }
}
