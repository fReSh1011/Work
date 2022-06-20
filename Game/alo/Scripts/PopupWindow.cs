using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupWindow : MonoBehaviour
{
    public GameObject[] pupup;
    public GameObject pupupWindows;
    public StatsPlayer player;
    private int i = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            i++;
            if (i==1)
            {
                pupup[0].SetActive(false);
                pupup[1].SetActive(true);
            }
            else if (i == 2)
            {
                pupup[1].SetActive(false);
                pupup[2].SetActive(true);
            }
            else if (i == 3)
            {
                pupup[2].SetActive(false);
                pupup[3].SetActive(true);
            }
            else if (i == 4)
            {
                pupup[3].SetActive(false);
                pupup[4].SetActive(true);
            }
            else if (i == 5)
            {
                pupupWindows.SetActive(false);
            }
        }
    }
}
