using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.Networking;
using UnityEngine.UI;

public class jsonDataController : MonoBehaviour
{
    private string url = "https://ashok17kumaravel.github.io/Test/db.json";

 
    public Text myText;
    public InputField x;

    public void getRequest() {
        StartCoroutine(makeRequest());
    }

    public void ClearText()
    {
        myText.text = "";
    }

    IEnumerator makeRequest() {

        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            var students_data_json = JsonConvert.DeserializeObject<jsonDataClass>(request.downloadHandler.text);
            //string myString_Data = student_data_json.students;

            int value = int.Parse(x.text);
           
            myText.text = myText.text + "\n" +
                          "name: " + students_data_json.Items[value].EmployeeName + "\n" +

                          "\n";


            

        }

         
    }

    
}
