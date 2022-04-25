using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Testeo : MonoBehaviour
{
    public int speed;
    public int hp;
    public int gems;
    // Start is called before the first frame update
    public abstract void Attack();

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }


    


}

public class test : Testeo
{
    public override void Attack() {


        Debug.Log("Atacko");
            }

    public virtual void Die()
    {
        Debug.Log("me muero");
        base.Die();
    }
}
