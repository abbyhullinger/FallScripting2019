using UnityEngine;
using Cinemachine;
 
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CineMachineController : MonoBehaviour
{
    public PlayerData playerData;
    private CinemachineVirtualCamera virtualCamera;
   

    private void Awake()
    {
     virtualCamera = GetComponent<CinemachineVirtualCamera>();
     PlayerData.instanceAction = InstanceHandler; 
     PlayerData.InstancePlayer(); 
   }


   private void InstanceHandler(GameObject obj)
   {
       virtualCamera.Follow = obj.transform; 
 }

}
//we are going to put this script on the same object as our virtualcamera.