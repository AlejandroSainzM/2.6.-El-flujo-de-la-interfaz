using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] private Animator bubble01;
    [SerializeField] private Animator bubble02;
    [SerializeField] private Animator bubble03;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name != "fire") return;

        bubble01.SetBool("isBubbling", true);
        bubble02.SetBool("isBubbling", true);
        bubble03.SetBool("isBubbling", true);
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.name != "fire") return;

        bubble01.SetBool("isBubbling", false);
        bubble02.SetBool("isBubbling", false);
        bubble03.SetBool("isBubbling", false);
    }
}