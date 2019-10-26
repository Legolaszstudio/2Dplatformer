using UnityEngine;

public class BaseRanger : BaseClassScript
{
    public BaseRanger()
    {
        ClassName = "Ranger";
        Strength = 4;
        Health = 3;
        Intelligent = 4;
        Damage = Strength * 2;
        Shoot = true;
    }
}
