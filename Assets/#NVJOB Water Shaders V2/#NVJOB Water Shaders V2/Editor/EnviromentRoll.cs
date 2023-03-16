using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentRoll : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Layer1 ;
    GameObject Layer1D ;
    GameObject lengthObject;
    public string GBname;
    public string GBnameD;
    public string GLname;
    public float speedX;
    public float speedY;
    public float speedZ;
    public float DestinationX;
    public float DestinationY;
    public float DestinationZ;
    public bool Dbase;
    Vector3 originpos;
    Vector3 originposD;
    void Start()
    {
        //Debug.Log("Hello");
        Layer1 = GameObject.Find(GBname);
        Layer1D = GameObject.Find(GBnameD);
        lengthObject =GameObject.Find(GLname);
        if(Layer1 != null){
            Debug.Log(Layer1.name +"Found");
            originpos = Layer1.transform.position;
        }
        if(Layer1D != null){
            Debug.Log(Layer1D.name +"Found");
            originposD = Layer1D.transform.position;
        }
        if(lengthObject !=null){
            Debug.Log( "size found: "+lengthObject.GetComponent<MeshRenderer>().bounds.size.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Time.deltaTime * speedX;
        float deltaY = Time.deltaTime * speedY;
        float deltaZ = Time.deltaTime * speedZ;
        Layer1.transform.Translate(new Vector3(deltaX,deltaY,deltaZ));
        Layer1D.transform.Translate(new Vector3(deltaX,deltaY,deltaZ));
        if(Dbase){
            if(Layer1.transform.position.x > DestinationX && speedX>0 ){
                Layer1.transform.position = originposD;
            }else if (Layer1.transform.position.y > DestinationY && speedY>0){
                Layer1.transform.position = originposD;
            }else if (Layer1.transform.position.z > DestinationZ && speedZ>0) {
                Layer1.transform.position = originposD;
            }
            if(Layer1.transform.position.x < DestinationX && speedX<0 ){
                Layer1.transform.position = originposD;
            }else if (Layer1.transform.position.y < DestinationY && speedY<0){
                Layer1.transform.position = originposD;
            }else if (Layer1.transform.position.z < DestinationZ && speedZ<0) {
                Layer1.transform.position = originposD;
            }
            if(Layer1D.transform.position.x > DestinationX && speedX>0 ){
                Layer1D.transform.position = originposD;
            }else if (Layer1D.transform.position.y > DestinationY && speedY>0){
                Layer1D.transform.position = originposD;
            }else if (Layer1D.transform.position.z > DestinationZ && speedZ>0) {
                Layer1D.transform.position = originposD;
            }
            if(Layer1D.transform.position.x < DestinationX && speedX<0 ){
                Layer1D.transform.position = originposD;
            }else if (Layer1D.transform.position.y < DestinationY && speedY<0){
                Layer1D.transform.position = originposD;
            }else if (Layer1D.transform.position.z < DestinationZ && speedZ<0) {
                Layer1D.transform.position = originposD;
            }
        }else{
            if(Layer1.transform.position.x > DestinationX && speedX>0 ){
                Layer1.transform.position = originpos;
            }else if (Layer1.transform.position.y > DestinationY && speedY>0){
                Layer1.transform.position = originpos;
            }else if (Layer1.transform.position.z > DestinationZ && speedZ>0) {
                Layer1.transform.position = originpos;
            }
            if(Layer1.transform.position.x < DestinationX && speedX<0 ){
                Layer1.transform.position = originpos;
            }else if (Layer1.transform.position.y < DestinationY && speedY<0){
                Layer1.transform.position = originpos;
            }else if (Layer1.transform.position.z < DestinationZ && speedZ<0) {
                Layer1.transform.position = originpos;
            }
            if(Layer1D.transform.position.x > DestinationX && speedX>0 ){
                Layer1D.transform.position = originpos;
            }else if (Layer1D.transform.position.y > DestinationY && speedY>0){
                Layer1D.transform.position = originpos;
            }else if (Layer1D.transform.position.z > DestinationZ && speedZ>0) {
                Layer1D.transform.position = originpos;
            }
            if(Layer1D.transform.position.x < DestinationX && speedX<0 ){
                Layer1D.transform.position = originpos;
            }else if (Layer1D.transform.position.y < DestinationY && speedY<0){
                Layer1D.transform.position = originpos;
            }else if (Layer1D.transform.position.z < DestinationZ && speedZ<0) {
                Layer1D.transform.position = originpos;
            }
        }
        
    }
}
