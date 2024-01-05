var p = new Person
{
    Name = "Otabek",
    Age = 21
};

void PassReferenceByRef(ref Person p) 
{
    p.Name = "Og'abek";
    p = new Person {Name="Anvar", Age = 23};
}

Console.WriteLine(p);
PassReferenceByRef(ref p);
Console.WriteLine(p);
