using System;

public class main {
  static public int Main() {
    HelloWorld hello = new HelloWorld();
     if (hello.message() != "Hello, world") {
       Console.WriteLine("Test failed");
       return 1;
     }
     return 0;
  }
}
