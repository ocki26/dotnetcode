// See https://aka.ms/new-console-template for more information
using System;
class pet {
    public String name {get;set;}
    public int age {get;set;}
    public String Sould {get;set;}
    public pet(String name, int age, String Sould){
        this.name = name;
        this.age = age;
        this.Sould = Sould;
    }
  }
  class dog :pet{
    public dog(String name, int age, String Sould) : base(name, age, Sould){
        this.name = name;
        this.age = age;
        this.Sould = Sould;
    }
    public void bark(){
        Console.WriteLine("Bark");
    }
  }
  class cat :pet{
    public cat(String name, int age, String Sould) : base(name, age, Sould){
        this.name = name;
        this.age = age;
        this.Sould = Sould;
    }
    public void meow(){
        Console.WriteLine("Meow");
    }
  }
class Program{
  static void Main(string[] args){
    dog d = new dog("dog", 2, "bark");
    cat c = new cat("cat", 3, "meow");
    Console.WriteLine(d.name + " " + d.age + " " + d.Sould);
    Console.WriteLine(c.name + " " + c.age + " " + c.Sould);
    d.bark();
    c.meow();
  }
}