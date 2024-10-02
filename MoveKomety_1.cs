using UnityEngine;

public class MoveKomety_1 : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= -6.5f)
        {
            Destroy(gameObject);
        }
    }
}
