namespace InterfaceExercise;

public interface IVehicle // create interface
{
    // add four members that a truck, car, and SUV would have in common
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string NumberOfWheels { get; set; } // first member
    public string NumberOfSeats { get; set; } // second member
    public string NumberOfDoors { get; set; } // third member
    public bool IsAutomatic { get; set; } // fourth member
    
}