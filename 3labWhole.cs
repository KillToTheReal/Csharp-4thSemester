//Вариант 7

using System;
class HelloWorld {
  static void Main() {
     Random rand = new Random();
     
     /*
      //Задание 1. Найти наибольший по модулю элемент в массиве.
      
    double[] numbers = new double[10];
    for(int i=0;i<9;i++)
    {
        numbers[i]= rand.NextDouble()*10;
    }
    
    double max = -1000;
    
    foreach(double num in numbers){
        
      Console.Write($" {num}");
      if(Math.Abs(num) > max)
      {
          max = num;
      }
    }
    
    Console.Write($"\n{max}");
    
    */
    
    //Задание 2. Найти сумму элементов массива распологающихся между первым и вторым положительными элементами.
    /*
    int sum = 0;
    int first = -1;
    int second = -1;
   
    
    int[] arr = {2,-2,-5,-5,-5,-23,8};
    
  //for(int i =0; i<10;i++){
   //     arr[i] = rand.Next(-1,1);
   // }
    

    while(first<0){
        int j=0;
        if(arr[j]>0){
            first = j;
        }
        j=j+1;
        if(j>10){
        break;
        }
    }
    
    int h = first +1;
    
    while(second<0){
        if(arr[h] > 0){
            second = h;}
            
        h=h+1;
        
        if(h>10){
        break;}
    }
    
    foreach( int num in arr){
        Console.Write($"  {num}");
    }
    Console.Write($"\n  Место первого положительного элемента: {first}. \n Место второго положительного элемента: {second}. ");
    
    for(int g =first+1; g<second; g++){
        sum = sum+arr[g];
    }
    
    Console.Write($" \n Сумма элементов между первым и вторым положительным элементами: {sum}");
    
      */
      
    //Задание 3. Сделать так,чтобы в массиве нули стояли после всех элементов.
    /*
    int[] mas = {0,2,5,9,0,0,7,5,3,2,0,0,2};
    int size= mas.Length;
    
    Console.Write($"Размер массива: {size}");
    
    for(int i1=0;i1< size;i1++){
        for(int i2 = 0; i2<size-1;i2++){
            if(mas[i2] == 0)
            {
                int tmp = 0;
                tmp = mas[i2];
                mas[i2] = mas[i2+1];
                mas[i2+1]=tmp;
            }
        }
    }
    
    Console.Write("\n Массив после преобразования.");
    foreach(int ms in mas ){
        Console.Write($"  {ms}");
    }
    
    */
  }
}
