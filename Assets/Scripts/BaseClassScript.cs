using UnityEngine;

public class BaseClassScript : MonoBehaviour
{
    private string className;
    private int strength, health, intelligent, damage;
    private bool shoot;
    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
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
