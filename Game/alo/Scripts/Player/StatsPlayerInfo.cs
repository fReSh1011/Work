using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsPlayerInfo : MonoBehaviour
{

    public StatsPlayer player;
    public TextMeshProUGUI[] stats;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInfo();
    }

    // Update is called once per frame
    public void PlayerInfo()
    {
        stats[0].text = player.healthMax.ToString();
        stats[1].text = player.healthReg.ToString();
        stats[2].text = player.manaMax.ToString();
        stats[3].text = player.manaReg.ToString();
        stats[4].text = (player.expMax - player.expNow).ToString();
        stats[5].text = player.lvl.ToString();
        stats[6].text = player.damage.ToString();
    }
}
