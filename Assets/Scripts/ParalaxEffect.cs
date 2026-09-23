using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    [SerializeField] private GameObject Background;
    [SerializeField] private ParalaxSo data;
    private Material paralax;
    private float velocity;
    private float limits;
    private float relocation;

    private void Start()
    {

        paralax = GetComponent<Renderer>().material;
        velocity = data.velocity;
        //limits = data.limits;
        //relocation = data.relocation;
        
    }

    private void Update()
    {
        paralax.mainTextureOffset += new Vector2(velocity * Time.deltaTime,0);

        //Background.transform.localPosition = new Vector3(Background.transform.localPosition.x + -velocity * Time.deltaTime, Background.transform.localPosition.y, Background.transform.localPosition.z);
        //if (Background.transform.localPosition.x <= limits) 
        //{
        //    Background.transform.localPosition = new Vector3(relocation , Background.transform.localPosition.y, Background.transform.localPosition.z);
        //}
    }
}
