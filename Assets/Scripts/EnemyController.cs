using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyController : MonoBehaviour
{
    [SerializeField] string[] collidableTags;
    [SerializeField] float timeBeforeDealingDamage;
    bool canDealDamage = true;
    private void OnTriggerEnter(Collider collision)
    {
        if (!canDealDamage) return;
        GameObject other = collision.gameObject;
        if (collidableTags.Contains(other.tag))
        {
            health h = other.GetComponent<health>();
            if (h != null)
            {
                h.TakeDamage(1);
                StartCoroutine(WaitToDealDamage());
            }
        }
    }

    IEnumerator WaitToDealDamage()
    {
        canDealDamage = false;
        yield return new WaitForSeconds(timeBeforeDealingDamage);
        canDealDamage = true;
        Debug.Log("Can deal damage again");
    }
}
