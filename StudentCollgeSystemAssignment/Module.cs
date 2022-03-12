// See https://aka.ms/new-console-template for more information

public class Module : IModule
{
    List<ModuleInfo> modules = new List<ModuleInfo>();
    string s = new string('-', 70);


    public void AddModule(ModuleInfo moduleInfo)
    {
        modules.Add(moduleInfo);
    }

    public void AddModule()
    {

        Console.WriteLine("Enter name : ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter Description : ");
        var description = Console.ReadLine();

        Console.WriteLine("Enter Course Fees : ");
        var courseFeesText = Console.ReadLine();

        Console.WriteLine("Enter Startdate : ");
        var startDateText = Console.ReadLine();

        ModuleInfo module = new ModuleInfo(name, description, double.Parse(courseFeesText), DateTime.Parse(startDateText));
        modules.Add(module);
    }

    public void DisplayAllModule()
    {
        Console.WriteLine(s);
        Console.WriteLine("\t\tModule Listing Report");
        Console.WriteLine(s);
        Console.WriteLine("|Name           |Description              |Fees      |Start Date     |");
        Console.WriteLine(s);

        foreach (var module in modules)
        {
            Console.WriteLine($"|{module.Name,-15}|{module.Discription,-25}|{module.Fees,10:N}|{module.DateTime,-15:dd-MMM-yyyy}|");
        }

        Console.WriteLine(s);
    }

    public void DisplayAnyModule()
    {
        Console.WriteLine(s);
        Console.Write("Enter module name to search : ");
        string searchModule = Console.ReadLine();   

        foreach(var module in modules)
        {
            if (searchModule == module.Name)
            {
                module.DisplaySingleModule();
            }
        }
        Console.WriteLine(s);
    }

    public void UpdateModule()
    {
        throw new NotImplementedException();
    }
}