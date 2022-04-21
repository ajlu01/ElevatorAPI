namespace ElevatorAPI
{
    public class Elevator
    {
        int currentFloor { get; set; }
        public Elevator()
        {
            currentFloor;
            NextFloor = null;
            FloorQueue = null;

        }

        public int? NextFloor { get; set; }
        public List<int>? FloorQueue { get; set; }

    }
}