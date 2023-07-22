namespace Kristina_Kulich_application.Kristina_Kulich_application.CSharpCollections1;

public class Citizen
{
    public string LastnameNameFathername { get; set; }
    public string HomeAddress { get; set; }
    public DateTime BirthDate { get; set; }

    //interesting where such methods are placed because they are referring to list but not purely class

    public void SortCitizensAlphabetically(List<Citizen> citizens)
    {
        IEnumerable<string> query = from citizen in citizens 
            orderby  LastnameNameFathername
            select LastnameNameFathername;  

        foreach (string lastname in query)  
            Console.WriteLine(lastname);  
    }
}