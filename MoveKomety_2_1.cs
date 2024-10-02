using UnityEngine;

public class MoveKomety_2_1 : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 15f;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);

        if (transform.position.y <= -6.5f)
        {
            Destroy(gameObject);
        }
    }
}
