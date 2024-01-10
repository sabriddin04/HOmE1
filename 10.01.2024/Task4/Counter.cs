public class Counter
{
    public int StartValue;
    public Counter(int StartValue)
    {
        this.StartValue=StartValue;
    }

    public Counter()
    {
        StartValue=0;
    }
     public void Increase(){
        StartValue++;
     }
     public void Decrease(){
         StartValue--;
     }
     
     public void Increase(int increaseBy){
        if(increaseBy>0){
        StartValue+=increaseBy;
        }
     }
     public void Decrease(int decreaseBy) {
         if(decreaseBy>0){
        StartValue-=decreaseBy;
        }
     }
    
}