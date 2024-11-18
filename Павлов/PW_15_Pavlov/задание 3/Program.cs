class Person
{
    private string _name;
    private int _age;

    public Person()
    {
    }

    public Person(string name)
    {
        _name = name;
        _age = 18;
    }

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}

class Employee : Person
{
    private string _company;

    public Employee() : base()
    {
    }

    public Employee(string name, int age, string company) : base(name, age)
    {
        _company = company;
    }
}