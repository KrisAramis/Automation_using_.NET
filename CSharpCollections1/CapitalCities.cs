using System.Collections;

namespace Kristina_Kulich__Application.CSharpCollections1;

public class CapitalCities
{
    public Dictionary<string, string> CreateDictionary(string[] InputCountries)
    {
    string[] Countries = new string[InputCountries.Length];
    string[] Cities = new string[InputCountries.Length];
    Dictionary<string, string> сountryCapitalCity = new Dictionary<string, string>();

        for (int i = 0; i < InputCountries.Length; i++)
    {
        Countries[i]=InputCountries[i].Substring(0,InputCountries[i].IndexOf(':'));
        Console.WriteLine(Countries[i]);
    }
for (int i = 0; i < InputCountries.Length; i++)
{
    Cities[i]=InputCountries[i].Substring(InputCountries[i].IndexOf(':')+1);
    Console.WriteLine(Cities[i]);
}
for (int i = 0; i < InputCountries.Length; i++)
{
    сountryCapitalCity.Add(Countries[i], Cities[i]); 
    //When I get iside by debugging get this error below
    //An IL variable is not available at the current native IP. The error code is CORDBG_E_IL_VAR_NOT_AVAILABLE, or 0x80131304.
}

return сountryCapitalCity;
    }
    public void ReturnCountriesCapitals(string[] InputCountries)
    {        
        /*string[] Countries = new string[InputCountries.Length];
        string[] Cities = new string[InputCountries.Length];
        Dictionary<string, string> сountryCapitalCity = new Dictionary<string, string>();

        for (int i = 0; i < InputCountries.Length; i++)
    {
        Countries[i]=InputCountries[i].Substring(0,InputCountries[i].IndexOf(':'));
        Console.WriteLine(Countries[i]);
    }
        for (int i = 0; i < InputCountries.Length; i++)
    {
        Cities[i]=InputCountries[i].Substring(InputCountries[i].IndexOf(':')+1);
        Console.WriteLine(Cities[i]);
    }
        for (int i = 0; i < InputCountries.Length; i++)
    {
        сountryCapitalCity.Add(Countries[i], Cities[i]); 
        //When I get iside by debugging get this error below
        //An IL variable is not available at the current native IP. The error code is CORDBG_E_IL_VAR_NOT_AVAILABLE, or 0x80131304.
    }*/

        foreach (KeyValuePair<string, string> kvp in сountryCapitalCity)
        {
            //CountryCapitalCity.Add();
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }

    public void ReturnCapitalsCountries(Dictionary<string, string> сountryCapitalCity)
    {
        List<string> keys = сountryCapitalCity.Keys.ToList();
        List<string> values = сountryCapitalCity.Values.ToList();
        Dictionary<string, string> updatedCountryCapitalCity = new Dictionary<string, string>();
        updatedCountryCapitalCity.Add(values, keys);

    }

}