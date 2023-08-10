namespace Nuget.Models;

public class DomainModel
{
    public DomainModel(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}