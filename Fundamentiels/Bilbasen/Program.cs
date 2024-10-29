
public class Car
{
    public string Brand;
    public string Model;
    public int Year;
    public string Color;
    public int HorsePower;
    public int NumberOfCylinders;
    // Constructor
    public Car(string brand, string model, int year, string color, int horsePower, int numberOfCylinders)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        HorsePower = horsePower;
        NumberOfCylinders = numberOfCylinders;
    }
}

public class Program
{
    static void Main()
    {
        Car[] cars = new Car[]
        {
        new Car("Ford", "Mustang", 1963, "Red", 430, 8),
        new Car("Toyota", "Camry", 2020, "Blue", 200, 6),
        new Car("Chevrolet", "Corvette", 2022, "Silver", 650, 8),
        new Car("BMW", "X5", 2021, "Black", 450, 6),
        new Car("Honda", "Civic", 2018, "White", 158, 4),
        new Car("Nissan", "Altima", 2019, "Gray", 188, 4),
        new Car("Volkswagen", "Golf", 2015, "Blue", 170, 4),
        new Car("Audi", "A4", 2017, "Red", 252, 4),
        new Car("Mercedes", "E-Class", 2016, "Silver", 302, 6),
        new Car("Volvo", "XC90", 2018, "Black", 316, 4),
        new Car("Ford", "Focus", 2019, "White", 160, 4),
        new Car("Toyota", "Corolla", 2017, "Green", 132, 4),
        new Car("Chevrolet", "Malibu", 2020, "Silver", 160, 4),
        new Car("BMW", "3 Series", 2014, "Blue", 180, 4),
        new Car("Honda", "Accord", 2015, "Gray", 185, 4),
        new Car("Nissan", "Sentra", 2018, "Red", 149, 4),
        new Car("Volkswagen", "Passat", 2016, "Blue", 174, 4),
        new Car("Audi", "Q7", 2020, "Black", 335, 6),
        new Car("Mercedes", "GLC", 2019, "White", 255, 4),
        new Car("Volvo", "S60", 2021, "Gray", 250, 4),
        new Car("Ford", "Explorer", 2017, "Red", 290, 6),
        new Car("Toyota", "Highlander", 2018, "Silver", 295, 6),
        new Car("Chevrolet", "Tahoe", 2021, "Blue", 355, 8),
        new Car("BMW", "5 Series", 2019, "Black", 248, 6),
        new Car("Honda", "HR-V", 2020, "Green", 141, 4),
        new Car("Nissan", "Rogue", 2021, "Silver", 181, 4),
        new Car("Volkswagen", "Jetta", 2015, "White", 170, 4),
        new Car("Audi", "A3", 2018, "Red", 228, 4),
        new Car("Mercedes", "CLA", 2017, "Gray", 208, 4),
        new Car("Volvo", "V90", 2018, "Black", 316, 4),
        new Car("Ford", "Ranger", 2020, "Blue", 270, 4),
        new Car("Toyota", "Tacoma", 2019, "White", 278, 6),
        new Car("Chevrolet", "Silverado", 2020, "Red", 420, 8),
        new Car("BMW", "X3", 2019, "Silver", 248, 4),
        new Car("Honda", "Pilot", 2020, "Black", 280, 6),
        new Car("Nissan", "Murano", 2021, "Gray", 260, 6),
        new Car("Volkswagen", "Tiguan", 2018, "Blue", 184, 4),
        new Car("Audi", "Q5", 2021, "White", 261, 4),
        new Car("Mercedes", "GLA", 2020, "Silver", 221, 4),
        new Car("Volvo", "XC40", 2019, "Red", 248, 4),
        new Car("Ford", "F-150", 2017, "Blue", 450, 8),
        new Car("Toyota", "RAV4", 2018, "White", 203, 4),
        new Car("Chevrolet", "Blazer", 2021, "Gray", 308, 6),
        new Car("BMW", "X1", 2020, "Silver", 228, 4),
        new Car("Honda", "CR-V", 2019, "Black", 190, 4),
        new Car("Nissan", "Kicks", 2020, "White", 125, 4),
        new Car("Volkswagen", "Arteon", 2021, "Red", 268, 4),
        new Car("Audi", "A6", 2017, "Gray", 335, 6),
        new Car("Mercedes", "S-Class", 2016, "Blue", 449, 8),
        new Car("Volvo", "S90", 2018, "Black", 316, 4),
        new Car("Volvo", "XC70", 2019, "Green", 316, 4),
        new Car("Ford", "Edge", 2021, "Silver", 250, 4),
        new Car("Toyota", "Avalon", 2019, "Black", 301, 6),
        new Car("Chevrolet", "Impala", 2017, "Blue", 305, 6),
        new Car("BMW", "7 Series", 2021, "Gray", 335, 6),
        new Car("Honda", "Insight", 2018, "White", 151, 4),
        new Car("Nissan", "Pathfinder", 2020, "Red", 284, 6),
        new Car("Volkswagen", "Atlas", 2019, "Silver", 276, 6),
        new Car("Audi", "A8", 2016, "Black", 333, 8),
        new Car("Mercedes", "GLB", 2021, "White", 221, 4),
        new Car("Volvo", "S70", 2017, "Red", 240, 4),
        new Car("Ford", "Bronco", 2022, "Green", 300, 6),
        new Car("Toyota", "4Runner", 2015, "Blue", 270, 6),
        new Car("Chevrolet", "Equinox", 2018, "Gray", 252, 4),
        new Car("BMW", "X6", 2019, "Silver", 335, 6),
        new Car("Honda", "Passport", 2020, "Black", 280, 6),
        new Car("Nissan", "Armada", 2021, "Red", 400, 8),
        new Car("Volkswagen", "Touareg", 2017, "White", 276, 6),
        new Car("Audi", "SQ5", 2022, "Gray", 349, 6),
        new Car("Mercedes", "AMG C", 2020, "Blue", 385, 4),
        new Car("Volvo", "V60", 2018, "Green", 250, 4),
        new Car("Ford", "Expedition", 2019, "Silver", 375, 6),
        new Car("Toyota", "Land Cruiser", 2021, "Black", 381, 8),
        new Car("Chevrolet", "Traverse", 2020, "White", 310, 6),
        new Car("BMW", "M4", 2018, "Gray", 425, 6),
        new Car("Honda", "Odyssey", 2017, "Blue", 280, 6),
        new Car("Nissan", "Maxima", 2022, "Silver", 300, 6),
        new Car("Volkswagen", "Beetle", 2019, "Red", 174, 4),
        new Car("Audi", "TT", 2020, "Black", 228, 4),
        new Car("Mercedes", "GLE", 2018, "White", 385, 6),
        new Car("Volvo", "C30", 2019, "Green", 248, 4),
        new Car("Ford", "Fusion", 2020, "Silver", 245, 4),
        new Car("Toyota", "Sequoia", 2021, "Gray", 381, 8),
        new Car("Chevrolet", "Spark", 2016, "Red", 98, 4),
        new Car("BMW", "Z4", 2017, "Blue", 255, 4),
        new Car("Honda", "Fit", 2018, "Gray", 130, 4),
        new Car("Nissan", "Versa", 2021, "Silver", 122, 4),
        new Car("Volkswagen", "CC", 2015, "Black", 200, 4),
        new Car("Audi", "RS3", 2018, "White", 400, 5),
        new Car("Mercedes", "AMG GLE", 2022, "Gray", 429, 8),
        new Car("Volvo", "XC60", 2017, "Red", 316, 4),
        new Car("Ford", "Maverick", 2022, "Blue", 250, 4),
        new Car("Toyota", "Venza", 2021, "Black", 219, 4),
        new Car("Chevrolet", "Trailblazer", 2019, "Silver", 155, 3),
        new Car("BMW", "8 Series", 2020, "White", 335, 6),
        new Car("Honda", "Element", 2011, "Green", 166, 4),
        new Car("Nissan", "Frontier", 2020, "Gray", 310, 6),
        new Car("Volkswagen", "Scirocco", 2016, "Red", 210, 4),
        new Car("Audi", "Allroad", 2019, "Blue", 248, 4),
        new Car("Mercedes", "AMG GT S", 2016, "Silver", 523, 8),
        new Car("Volvo", "XC20", 2021, "Gray", 248, 4)
    };

        string filter_brand = "Ford";
        int filter_horsepower = 200;
        string filter_color = "Red";
        int filter_ÿear_start = 1980;
        int filter_ÿear_end = 1999;






        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].Brand == filter_brand)
            {
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}");
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}, Årgang: {cars[i].Year}, Farve: {cars[i].Color}, Hestekræfter: {cars[i].HorsePower}");
            }
        }


        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].HorsePower > filter_horsepower)
            {
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}");
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}, Årgang: {cars[i].Year}, Farve: {cars[i].Color}, Hestekræfter: {cars[i].HorsePower}");
            }
        }


        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].Color == filter_color)
            {
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}");
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}, Årgang: {cars[i].Year}, Farve: {cars[i].Color}, Hestekræfter: {cars[i].HorsePower}");
            }
        }

        int count_brand = 0;
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].Brand == filter_brand)
            {
                count_brand++;
            }

        }
        //Console.WriteLine($"{count_brand}");





        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].Year >= filter_ÿear_start && (cars[i].Year <= filter_ÿear_end))
            {
                //Console.WriteLine($"{cars[i].Brand} {cars[i].Model}");
                Console.WriteLine($"{cars[i].Brand} {cars[i].Model}, Årgang: {cars[i].Year}, Farve: {cars[i].Color}, Hestekræfter: {cars[i].HorsePower}");
            }
        }
    }
}