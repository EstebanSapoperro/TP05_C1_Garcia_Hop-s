using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    [SerializeField] private GameObject Background;
    [SerializeField] private ParalaxSo data;
    private float velocity;
    private float limits;
    private float relocation;

    private void Start()
    {

        velocity = data.velocity;
        limits = data.limits;
        relocation = data.relocation;
        
    }

    private void Update()
    {
        Background.transform.localPosition = new Vector3(Background.transform.localPosition.x + -velocity * Time.deltaTime, Background.transform.localPosition.y, Background.transform.localPosition.z);
        if (Background.transform.localPosition.x <= limits) 
        {
            Background.transform.localPosition = new Vector3(relocation , Background.transform.localPosition.y, Background.transform.localPosition.z);
        }
    }
}
