using System;
class HelloWorld {
  static void Main() {
    int n = 3;
    int[,] twoDimArray = new int[n, n];
    for(int i=0; i<n; i++) {
        for(int j=0; j<n; j++) {
            Console.Write($"twoDimArray[{i},{j}]=");
            twoDimArray[i,j] = Int32.Parse(Console.ReadLine());
        }
    }
    
    int max = twoDimArray[0,0];
    int min = twoDimArray[0,0];
    for(int i=0; i<n; i++) {
        for(int j=0; j<n; j++) {
          if(twoDimArray[i, j] > max) max = twoDimArray[i, j];
          else if(twoDimArray[i, j] < min) min = twoDimArray[i, j];
        }
    }
    
    Console.WriteLine($"the difference between the maximum and minimum is {max - min}");
  }
}