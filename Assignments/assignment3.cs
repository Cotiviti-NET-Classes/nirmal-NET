namespace Animal;
class Wild{
    //default constructor
    public Wild(){
        haveTail = false;
        Console.WriteLine($"Default Constructor {haveTail}");
    }
    //parameterized constructor
    public Wild(string name,int age,string eat){
        Name=name;
        Age=age;
        _eat = eat;
        Console.WriteLine($"{Name}, {Age} and {_eat} are parameters");
    }
    //auto implemented propertiess
    public string? Name{get; set;}
    public int? Age{get; set;}
    //readonly
    private string? _eat;
    public string Eat{
        get{
            return _eat;
        }
    }
    //writeonly
    private bool? _hungry;
    public string Hungry{
        set{
            _hungry=false;
        }
    }
    //compile time
    public const bool liveInJungle = true;
    //runtime
    public readonly bool haveTail = true;
    //enumeration
    enum Environment{
        Jungle,
        Water,
        Food
    }
    
    //method that returns value of two properties
    public (string?, int?) WildAnimal(string name, int age){
        Name=name;
        Age=age;
        return(Name, Age);
    }
}
