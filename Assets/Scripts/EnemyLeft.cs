using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI enemyleftTxt;
    public Image EnemyLeftbar;
    public int enemycount;
    public Pause complete;

    public void Start()
    {
        enemycount = 30;
    }

    private void Update()
    {
        
        EnemyLeftbar.fillAmount = enemycount / 30f;
        enemyleftTxt.text = enemycount.ToString() + "/30";

        if(enemycount == 0)
        {
            Time.timeScale = 1;
            complete.Completed();
        }



    }

    public void enemykilled()
    {
        enemycount -= 1;
       
    }

}
