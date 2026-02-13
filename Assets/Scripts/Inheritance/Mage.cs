using UnityEngine;

public class Mage : Character
{
    void Start()
    {
        Damage = 15f;

        Debug.Log($"{Name} on valmis taisteluun! HP: {Health}");

        Attack();
    }
    void Update()
    {
        
    }

    public override void Attack()
    {
        Debug.Log($"{Name} heitt‰‰ tulipallon");
    }
}
