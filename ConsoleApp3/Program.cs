using System.Reflection.PortableExecutable;

class Car1
{
    public void OperationA()
    {
    }
}


class Car2
{
    public void OperationB()
    {
    }
}

class Car3
{
    public void OperationC()
    {

    }
}

class Facade
{
    private Car1 car1;
    private Car2 car2;
    private Car3 car3;

    public Facade()
    {
        car1 = new Car1();
        car2 = new Car2();
        car3 = new Car3();
    }

    public void Operation()
    {
        car1.OperationA();
        car2.OperationB();
        car3.OperationC();
    }
}
