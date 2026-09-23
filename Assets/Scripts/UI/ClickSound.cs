using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{
    private Button buttonSelected;
    private AudioSource source;
    public AudioClip audioClip;

    private void Awake()
    {
        buttonSelected = GetComponent<Button>();
        buttonSelected.onClick.AddListener(OnClick);
        source = GetComponent<AudioSource>();
    }

    private void OnClick() 
    {
        source.Play(audioClip);
        Debug.Log("se ejecuto el click");
    }

}
