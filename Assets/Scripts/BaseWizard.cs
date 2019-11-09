using UnityEngine;

public class BaseWizard : BaseClassScript
{
    public BaseWizard()
    {
        ClassName = "Wizard";
        Strength = 5;
        Health = 8;
        Intelligent = 5;
        Damage = Strength * 2;
        Shoot = false;
    }
}
