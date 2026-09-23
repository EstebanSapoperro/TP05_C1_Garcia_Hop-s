using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    [SerializeField] private GameObject Background;
    [SerializeField] private ParalaxSo data;
    private Material paralax;
    private float velocity;

    private void Start()
    {

        paralax = GetComponent<Renderer>().material;
        velocity = data.velocity;
    }

    private void Update()
    {
        paralax.mainTextureOffset += new Vector2(velocity * Time.deltaTime,0);
    }
}
