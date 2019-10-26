
using UnityEngine;

public class BaseWarrior : BaseClassScript
{
    public BaseWarrior()
    {
        ClassName = "Warrior";
        Strength = 5;
        Health = 10;
        Intelligent = 2;
        Damage = Strength * 2;
        Shoot = false;
    }
}
