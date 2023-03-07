using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Sample3 : MonoBehaviour
{
    public int val = 10;
    public List<int> valList = new List<int>();


    // Start is called before the first frame update
    void Start()
    {
        valList.Add(1);
        valList.Add(2);
        valList.Add(3);
        valList.Add(4);
        valList.Add(5);
        
        Debug.Log("Sample3에 대한 기능 테스트");
        Debug.Log("Sample3에 대한 기능 테스트 추가 수정");


        StartCoroutine("GetGoogle");
    }

    private IEnumerator GetGoogle()
    {
        using (var uwr = UnityWebRequest.Get("https://google.com"))
        {
            yield return uwr.SendWebRequest();

            if (uwr.error != null)
            {
                
            }
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
