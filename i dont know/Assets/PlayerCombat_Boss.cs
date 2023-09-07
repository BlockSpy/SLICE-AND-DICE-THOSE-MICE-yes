using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat_Boss : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 2;
    public LayerMask enemyLayers;
    public LayerMask bossLayers;

    public int attackDamage = 50;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Attack();
            Debug.Log("z");
        }
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        Collider2D[] hitBosses = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, bossLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            Destroy(enemy.gameObject);
        }
        foreach (Collider2D boss in hitBosses)
        {
            boss.GetComponent<Boss_Health>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
