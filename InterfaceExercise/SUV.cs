namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public bool HasFoldableCargoSpace { get; set; }
    public int SeatRows { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string NumberOfWheels { get; set; }
    public string NumberOfSeats { get; set; }
    public string NumberOfDoors { get; set; }
    public bool IsAutomatic { get; set; }
    public string Logo { get; set; }
    public string Location { get; set; }
}