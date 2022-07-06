using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);

        text.text = $"прошло времени { Time.realtimeSinceStartup }";
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
