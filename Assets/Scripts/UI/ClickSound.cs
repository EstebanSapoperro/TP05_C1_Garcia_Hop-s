using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{
    [SerializeField] private Button buttonSelected;
    public AudioSource source;

    private void Awake()
    {
        buttonSelected.onClick.AddListener(OnClick);
        source = GetComponent<AudioSource>();
    }

    private void OnClick() 
    {
        source.Play();
    }

}
