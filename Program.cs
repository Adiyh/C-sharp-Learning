using Typesofconstructor;

class Monday
{

    int k;
        static int a;
    public Monday(int k)
    {
        this.k =k;
    }
    
    static void Main(string[] args) // Fixed parameter name to args
    {
        //First t1 = new First(3, 4);
        //First t2 = new First();
        //t1.firstmethod();
        //car newcar = new car();

        //NewCar car = new NewCar();
        //car.display();
        //Console.WriteLine("Main method is called");
        Console.WriteLine(a);
        Monday f1;//varible of a class
        f1 = new Monday(45);//f1 is a instance of a class Monday
        Monday f2 = f1; // f2 is a reference of an Instance f1
        Console.WriteLine(f1.k);
        Console.WriteLine(f2.k);       

    }
}
