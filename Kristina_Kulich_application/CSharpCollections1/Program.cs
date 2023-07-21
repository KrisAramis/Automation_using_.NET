// See https://aka.ms/new-console-template for more information
using Kristina_Kulich_application.Kristina_Kulich_application.CSharpCollections1;

        #region Separate massive into 2

        int[] numbers = new[] { 1, 3, 3, 17, 8, 6, 7 };

        Collections.CalculateMassiveLength(numbers);
        Collections.DevideInEvenUnevenMassives(numbers);
        #endregion

        #region Find Difference Max Min in Array

        Collections.FindDifferenceMaxMin(numbers);

        #endregion

        #region Sort Lastnames

        List<string> lastnames = new List<string> { "Brouka", "Karatkevich", "Yulivan", "Sibebbry", "Anilevicz" };
        Collections.SortLastnames(lastnames);
        #endregion

        #region Citizens
        List<Citizen> citizensofBobruisk = new List<Citizen>();
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Malinowski Henric Vladzimiravich", HomeAddress = "Malinava 24",
                BirthDate = new(2011, 6, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Macej Grink Aliaksandravich", HomeAddress = "Hrusheva 84",
                BirthDate = new(1991, 3, 8)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Teodorovich Jupiter Vasily", HomeAddress = "Malinava 4",
                BirthDate = new(2001, 2, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Slimov James Adamovich", HomeAddress = "Malinava 4",
                BirthDate = new(2015, 6, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Girov Henry Iosifovich", HomeAddress = "Malinava 4",
                BirthDate = new(1991, 6, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Strepov Konrad Borisovich", HomeAddress = "Malinava 4",
                BirthDate = new(1991, 4, 10)
            });


            //tried to do with extencion but don't know how to call it later
            //List<Citizen> malinava4 = 
             //citizensofBobruisk.Where(citizensofBobruisk => (citizensofBobruisk.HomeAddress == "Malinava 4")).ToList().OrderBy(citizensofBobruisk => citizensofBobruisk.LastnameNameFathername);

            citizensofBobruisk.Where(HomeAddress => HomeAddress.Equals("Malinava 24"));
            var query = from citizen in citizensofBobruisk
                where citizen.HomeAddress.Equals("Malinava 4") && DateTime.Today.Year - citizen.BirthDate.Year >=18
                orderby citizen.LastnameNameFathername
                select citizen;
            List<Citizen> votersMalinava4 = query.ToList();

            foreach (var citizen in query)
            {
                Console.WriteLine("{0} - {1}", citizen.LastnameNameFathername, citizen.BirthDate);
            }

            #endregion*/

        #region Dictionary
            System.Console.WriteLine("Write 5 City-Country combinations in following format: Country:Capital City");
            string[] InputCountries = Console.ReadLine().Split(' ');

            CapitalCities europeCities = new CapitalCities();
            Dictionary<string, string> dict = europeCities.CreateDictionary(InputCountries);
            europeCities.ReturnCountriesCapitals(dict);
            europeCities.ReturnCapitalsCountries(dict);
            #endregion