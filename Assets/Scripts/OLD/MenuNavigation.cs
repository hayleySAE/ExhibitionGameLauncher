using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNavigation : MonoBehaviour
{
    public GameObject projectInfo0;
    public GameObject projectInfo1; 
    public GameObject projectInfo2;
    public GameObject projectInfo3;
    public GameObject projectInfo4;
    public GameObject projectInfo5;
    public GameObject projectInfo6;
    public GameObject projectInfo7;
    public GameObject projectInfo8;
    public GameObject projectInfo9;


    private void Start()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Project0()
    {
        projectInfo0.SetActive(true);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project1()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(true);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project2()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(true);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project3()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(true);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project4()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(true);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project5()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(true);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project6()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(true);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project7()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(true);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(false);
    }
    public void Project8()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(true);
        projectInfo9.SetActive(false);
    }
    public void Project9()
    {
        projectInfo0.SetActive(false);
        projectInfo1.SetActive(false);
        projectInfo2.SetActive(false);
        projectInfo3.SetActive(false);
        projectInfo4.SetActive(false);
        projectInfo5.SetActive(false);
        projectInfo6.SetActive(false);
        projectInfo7.SetActive(false);
        projectInfo8.SetActive(false);
        projectInfo9.SetActive(true);
    }
}
