using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    private IEnumerator Start()
    {
        Health health = GetComponent<Health>();
        Level level = GetComponent<Level>();
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log($"EXP: {level.GetExperience()},Level: {level.Getlevel()},Health:{health.GetHealth()}");

        }
    }
}
