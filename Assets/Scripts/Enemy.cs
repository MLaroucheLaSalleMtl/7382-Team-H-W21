using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    const int MaxHp = 100;
    public int Hp = 100;
    public Slider mSlider;
    public bool IsDead;//to tell if enemy is dead
    public Animator mAnimator;
    private EnemyLeft enemyleft;

    float mDeadTick;
    // Update is called once per frame

     private void Awake()
    {
        enemyleft = FindObjectOfType<EnemyLeft>();
    }


    void Update()
    {
        if (isAttacking)
        {
            mAttackTick += Time.deltaTime;
            if (mAttackTick >= 1f)///during the attack, other colliders may touch enemies, so a timer here stops enemy from being attacked 
                //again for 1 second
            {
                mAttackTick = 0;// after 2 second, isattacking is false
                isAttacking = false;
            }
        }
        if (IsDead)
        {
           
            mDeadTick += Time.deltaTime;
            if (mDeadTick >= 2)//after enemy died, wait for two second to play the death animation, then destroy the object
            {
                
                Destroy(gameObject);
            }
        }
    }
    bool isAttacking = false;
    float mAttackTick = 0;
    public void ReduceHp()
    {
        // this is the part to reduce enemy health
        if (IsDead) { return; }//if the enemy is dead, ignore the code below
        if (isAttacking == false)
        {
            
            Hp -= 20;
            if (Hp < 0) { Hp = 0; }
            mSlider.value = Hp / 1.0f / MaxHp;//put values calculated above into the slider

            if (Hp <= 0)//if health reaches zero
            {
                IsDead = true;
                mDeadTick = 0;
                mAnimator.SetTrigger("die");
                mSlider.gameObject.SetActive(false);
               
                
                GetComponent<EnemyAI>().enabled = false;
                GetComponent<Collider>().enabled = false;
                GetComponent<Rigidbody>().isKinematic = true;//components on enemy should now be disabled
                EnemySpawnManager.Instance.CreateEnemy();//when an enemy dies, we need to call create enemy to creat one from one of the spawn points
                enemyleft.enemykilled();
            }
            else
            {
                mAnimator.SetTrigger("attacked");//if he is not dead, play the react animation
            }
            isAttacking = true;
            mAttackTick = 0;
        }
    }
}
