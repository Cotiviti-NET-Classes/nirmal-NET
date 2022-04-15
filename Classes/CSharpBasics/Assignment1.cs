// Write a function which takes array of numbers as parameter and returns average and sum of those numbers.

namespace  Day2;
class Assignment
{
    public (int sum, float avg) Solution( params int[] val){
        int sum=0;
        for(int i=0; i<val.Length; i++){
            sum=sum+val[i];
        }
        float avg = (float) sum/val.Length;
        return (sum,avg);
    }
    
}