using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float x;
    [SerializeField] float speed;
    [SerializeField] float max;
    GameManager gm;
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(x * speed * Time.deltaTime, 0f));

        float xPos = Mathf.Clamp(transform.position.x, -max, max);
        transform.position = new Vector2(xPos, -3.5f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        gm.score++;
    }
}
