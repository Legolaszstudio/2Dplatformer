using UnityEngine;

public class BaseRanger : BaseClassScript
{
    public BaseRanger()
    {
        ClassName = "Ranger";
        Strenght = 4;
        Health = 3;
        Intelligent = 4;
        Damage = Strenght * 2;
        Shoot = true;
    }
}
