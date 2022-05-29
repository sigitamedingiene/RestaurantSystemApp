namespace Business_Class
{
    public class Table    {
        public int Number { get; }
        public int SeatCount { get; set; }
        public bool IsOcupied { get; set; }
        public Table(int number, int seatCount, bool isOcupied)
        {
            Number = number;
            SeatCount = seatCount;
            IsOcupied = isOcupied;
        }
    }
}
