namespace Day3;
abstract class Animal{
    public virtual void Walk(){
        Console.WriteLine("Animal Walks");
    }
    public void Type(){
        Console.WriteLine("All animals are mammal");
    }
}
class Bird{
    protected string bird = "parrot";
    public virtual void Egg(){
        Console.WriteLine("Birds lay egg");
    }
}
interface IWild{
    void Live();
}
interface IMove{
    void Fly();
}
class Tiger:Animal,IWild{
    public void Live(){
        Console.WriteLine("Tiger is a wild animal");
    }
    public override void Walk(){
        Console.WriteLine("Tiger walk with 4 legs");
    }
    public new void Type(){
        Console.WriteLine("Tiger is a mammal");
    }
}
sealed class Cubs:Tiger{
    public void Baby(){
        Console.WriteLine("Cubs are the baby of tiger");
    }
}
class Eagle:Bird,IWild,IMove{
    
    public override void Egg(){
        string bird="Eagle";
        Console.WriteLine($"{bird} lay egg");
    }
    public void Live(){
        Console.WriteLine("Eagle is a wild bird");
    }
    public void Fly(){
        Console.WriteLine("Eagle can fly high");
    }
    public void Eat(){
        Console.WriteLine("Eagle eat flesh");
    }

}
class Sparrow:Bird,IMove{
    public override void Egg(){
        Console.WriteLine("Sparrow lay egg");
    }
    public void Fly(){
        Console.WriteLine("Sparrow can fly");
    }
}