using System;

class MainClass {
  public static void Main (string[] args) {
    double area, Base, altura;
    
    Console.WriteLine ("Vamos calcular a área do retângulo!");
    
    Console.WriteLine ("Digite a base deste retângulo abaixo: ");
    Base = double.Parse (Console.ReadLine ());
    
    Console.WriteLine ("E agora digite a altura do retângulo: ");
    altura = double.Parse (Console.ReadLine ());
    
    area = Base * altura;
    
    Console.WriteLine ("A área do retângulo é: "+area);
    
    Console.ReadKey ();
  }
}