using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Text lifeTxt;
    [SerializeField]
    Text scoreTxt;

    public float score = 0;
    public float life = 3;

    private void Update()
    {
        lifeTxt.text = life.ToString();
        scoreTxt.text = score.ToString();
    }
}
