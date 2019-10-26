using UnityEngine;

public class BaseWarrior : BaseClassScript
{
    public BaseWarrior()
    {
        ClassName = "Warrior";
        Strenght = 5;
        Health = 10;
        Intelligent = 2;
        Damage = Strenght * 2;
        Shoot = false;
    }
}
