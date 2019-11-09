using System.Collections;
using UnityEngine;


public class BaseWarrior : BaseClassScript
{
    Animator anim;
    public BaseWarrior()
    {
        ClassName = "Warrior";
        Strength = 5;
        Health = 10;
        Intelligent = 2;
        Damage = Strength * 2;
        Shoot = false;
    }

    public void Hit()
    {
        anim = GetComponentInChildren<Animator>();
        anim.SetBool("attack", false);
        StartCoroutine(HitSword());
    }

    IEnumerator HitSword()
    {
        anim.SetBool("attack", true);
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("attack", false);
    }
}
