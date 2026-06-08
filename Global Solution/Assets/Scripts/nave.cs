using UnityEngine;

public class nave : MonoBehaviour
{
    float speed = 5f;

    public GameObject tiro;

    void Start()
    {
        print("jogo começou!");
    }

    void Update()
    {
        float move_x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float move_y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(move_x, move_y, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject novoTiro = Instantiate(
                tiro,
                transform.position + Vector3.up * 0.5f,
                Quaternion.identity
            );

            novoTiro.SetActive(true);
        }
    }
}

