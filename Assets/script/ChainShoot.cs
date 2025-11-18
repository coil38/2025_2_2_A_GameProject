using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainShoot : MonoBehaviour
{
    [SerializeField] float refreshRate = 0.1f;
    [SerializeField][Range(1, 10)] int maximunEnemiesInChain = 3;
}
