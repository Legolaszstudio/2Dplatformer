
using UnityEngine;

public class BaseWizardScript : BaseClassScript
{
    public BaseWizardScript()
    {
        ClassName = "Wizard";
        Strength = 5;
        Health = 8;
        Intelligent = 5;
        Damage = Strength * 2;
        Shoot = false;
    }
}
