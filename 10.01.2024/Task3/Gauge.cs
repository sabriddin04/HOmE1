class Gauge
{
    public int value;

    public Gauge()
    {
        value=0;
    }

   public void Enhance(){
     if(value+1<=5){
     value++;
     }
     

   }

public void Decrease(){
       if(value-1>=0){
     value--;
     }

}
public bool Full(){

   if(value==5) return true;
   else return false;


}
}