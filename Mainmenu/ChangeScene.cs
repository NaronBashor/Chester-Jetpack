using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
        [SerializeField] private string scene;
        [SerializeField] private int level;

        public void SceneSelect()
        {
                if (level == 0)
                {
                        SceneManager.LoadScene(scene);
                }
                        
                else if (level != 0 && PlayerPrefs.GetString("Level" + level + "Unlock") == "True")
                {
                        SceneManager.LoadScene(scene);
                }            
                
                else if (level == -1)
                {
                        SceneManager.LoadScene(scene);
                }
        }
}
