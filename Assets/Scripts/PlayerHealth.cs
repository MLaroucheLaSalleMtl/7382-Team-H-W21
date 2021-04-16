using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PlayerHPTxt;
    private int PlayerMaxHP = 100;
    public int PlayerCurHP;
    private int PlayerMinHP = 0;
    public Animator mAnimator;
    public Image PlayerHPSlider;
    public GameObject MenuUI;//to show a death screen
    public bool IsDead; // add a boolean state to tell if play is dead
    public Pause defeated;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCurHP = PlayerMaxHP;
    }

    // Update is called once per frame
    bool death;
    float timeD;
    void Update()
    {
        PlayerHPSlider.fillAmount = PlayerCurHP / 100f;
        PlayerHPTxt.text = PlayerCurHP + "/" + PlayerMaxHP;
        if(death)
        {
            timeD += Time.deltaTime;
            if(timeD >= 0.1f)
            {
                death = false;
                timeD = 0;
                mAnimator.SetBool("die", false);
                
            }
            
        }
    }

    //If the player is detected by Enemy's Weapon get 10 damage
    private void OnTriggerEnter(Collider other)
    {
        if (IsDead) { return; }//if player dead, no use for later code
        if (other.tag == "EnemyWeapon")//when sphere on enemy's hand touches the player, it register the attack
        {
            PlayerCurHP -= 5;
            MinHealth();//check for lowered health
            CheckDead();//check if dead
        }
    }

    //If the player get potion restore 30HP
    public void PotionHP()
    {
        if (IsDead) { return; }
        PlayerCurHP += 30;
        MaxHealth();
        CheckDead();
    }

    public void MaxHealth()
    {
        if (PlayerCurHP > PlayerMaxHP)//make sure health keeps updating
        {
            PlayerCurHP = PlayerMaxHP;
        }
    }

    private void MinHealth()
    {
        if (PlayerCurHP < PlayerMinHP)//make sure health keeps updating
        {
            PlayerCurHP = PlayerMinHP;
        }
    }
    void CheckDead()//check if player is dead
    {
        if (PlayerCurHP <= 0)
        {            
            IsDead = true;
            mAnimator.SetBool("die", true);
            Debug.Log(gameObject.name);
            death = true;
            
            defeated.Defeat();
        }
    }
}