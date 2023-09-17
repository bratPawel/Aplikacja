

    
        string name = "Paweł";
        string gender = "kobieta";
        int age = 9;



        if (name == "Paweł" && age >= 18)
        {
            Console.WriteLine("Możesz kupić piwo");
        }

        else if (gender != "kobieta" || age <= 18)
        {
            Console.WriteLine("Niepełnoletni mężczyzna");
        }
        else
        {
            Console.WriteLine("nie możesz kupić piwa");
        }
    
