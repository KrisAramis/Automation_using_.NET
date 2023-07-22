namespace Kristina_Kulich_application.Kristina_Kulich_application.CSharpCollections1;

using System.Collections;

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
    }

    return сountryCapitalCity;
    }
    public void ReturnCountriesCapitals(Dictionary<string, string> сountryCapitalCity)
    {
        foreach (KeyValuePair<string, string> kvp in сountryCapitalCity)
        {
            //CountryCapitalCity.Add();
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }

    public void ReturnCapitalsCountries(Dictionary<string, string> сountryCapitalCity)
    {
        List<string> countries = сountryCapitalCity.Keys.ToList();
        List<string> cities = сountryCapitalCity.Values.ToList();
        Dictionary<string, string> updatedCountryCapitalCity = new Dictionary<string, string>();
        for (int i = 0; i < сountryCapitalCity.Count; i++)
        {
            updatedCountryCapitalCity.Add(cities[i], countries[i]);
        }
        foreach (KeyValuePair<string, string> kvp in updatedCountryCapitalCity)
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }
}
