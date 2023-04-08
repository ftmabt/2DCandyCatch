using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField] float _speed;
    
    GameManager gm;
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Update()
    {
        transform.position += Vector3.down * _speed * Time.deltaTime;
        if (transform.position.y <-5)
        {
            Destroy(gameObject);
            gm.life--;
        }
    }
}
