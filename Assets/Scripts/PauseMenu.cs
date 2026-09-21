using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private KeyCode Pause = KeyCode.Escape;
    [SerializeField] private GameObject Pausepanel;
    [SerializeField] private GameObject timePanel;

    void Update()
    {
        if (DataGameManager.isFinished == false)
        {
            if (Input.GetKeyDown(Pause) && Time.timeScale == 0)
            {
                Time.timeScale = 1;

            }
            else if (Input.GetKeyDown(Pause) && Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }

            if (Input.GetKeyDown(Pause))
            {

                Pausepanel.SetActive(!Pausepanel.activeSelf);

                if (timePanel != null)
                {
                    timePanel.SetActive(!timePanel.activeSelf);
                }
            }


        }

    }
}
