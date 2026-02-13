using UnityEngine;

public class Warrior : Character
{
    void Start()
    {
        Damage = 20f;

        Debug.Log($"{Name} on valmis taisteluun! HP: {Health}");

        Attack();
    }
    void Update()
    {

    }
    public override void Attack()
    {
        Debug.Log($"{Name} lyö miekalla!");
    }
}
