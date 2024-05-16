using IGadiYami.Models;
namespace IGadiYami.Views;


public partial class StartGardeningPage : ContentPage
{
    // public List<StartGardeningMenuPage> GardeningOptions { get; set; }
    private List<StartGardeningMenuPage> _startGardeningMenuPages;

    public List<StartGardeningMenuPage> GardeningOptions
    {
        get { return _startGardeningMenuPages; }
        set { _startGardeningMenuPages = value; }
    }


    public StartGardeningPage()
    {
        StartGardeningMenuOptionCollections();
        BindingContext = this;
    }

    void StartGardeningMenuOptionCollections()
    {
        GardeningOptions = new List<StartGardeningMenuPage>
            {

                new StartGardeningMenuPage
                {
                    Name = "Onions",
                    Description = "A cold-season crop, easy to grow and a staple in most gardens.",
                    Image = "onions.jpg"
                },
                new StartGardeningMenuPage
                {
                    Name = "Potatoes",
                    Description = "A versatile root vegetable, rich in vitamins C, B6, and other nutrients.",
                    Image = "potatoes.jpg"
                },
                new StartGardeningMenuPage
                {
                    Name = "Spinach",
                    Description = "A nutrient-rich leafy green vegetable, originated in Persia.",
                    Image = "spinach.jpg"
                },
                new StartGardeningMenuPage
                {
                    Name = "Tomatoes",
                    Description = " A major source of antioxidant lycopene, linked to many health benefits.",
                    Image = "tomatoes.jpg"
                },
                new StartGardeningMenuPage
                {
                    Name = "Carrots",
                    Description = "Rich in beta carotene, fiber, and antioxidants, known for numerous health benefits.",
                    Image = "carrot.jpg"
                }
            };
    }
}
