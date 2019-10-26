using UnityEngine;

public class BaseClassScript : MonoBehaviour
{
    private string className;
    private int strenght, health, intelligent, damage;
    private bool shoot;

    public string ClassName {
        get { return className;}
        set { className = value;}
    }

    public int Strenght
    {
        get { return strenght; }
        set { strenght = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Intelligent
    {
        get { return intelligent; }
        set { intelligent = value; }
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public bool Shoot
    {
        get { return shoot; }
        set { shoot = value; }
    }
}
