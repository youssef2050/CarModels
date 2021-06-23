using System;

class MainClass {
  public static void Main (string[] args) {
    int[] models =new int [10];
    Random rnd = new Random();
    int oldModel = 2022;
    int countModel2002To2010 = 0;
    for(int i=0;i<10;i++){
      models[i] =  rnd.Next(1900, 2022);
      if(models[i]< oldModel){
        oldModel = models[i];
      }
      if(models[i]>=2002 && models[i]<2010){
        countModel2002To2010++;
      }
      Console.WriteLine (models[i]);
    } 

    Console.WriteLine ("old model : "+ oldModel);
    Console.WriteLine ("count Model 2002 To 2010 : "+ countModel2002To2010);
  }
}