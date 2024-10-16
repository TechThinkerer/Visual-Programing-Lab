using System;
using System.Collections.Generic;

public enum Status
{
    Available,
    Booked
}

public class Seat
{
    public int Row { get; set; }
    public int Number { get; set; }
    public decimal Price { get; set; }
    public Status Status { get; set; }

    public Seat(int row, int number, decimal price)
    {
        Row = row;
        Number = number;
        Price = price;
        Status = Status.Available;
    }

    public void Book()
    {
        if (Status == Status.Available)
        {
            Status = Status.Booked;
        }
        else
        {
            throw new InvalidOperationException("Seat not available.");
        }
    }
}
[23:09, 16/10/2024] Fasseh: using System;
using System.Collections.Generic;

public enum Status
{
    Available,
    Booked
}

public class User
{
    public int Id { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();
}

public class Booking
{
    public int No { get; set; }
    public Flight Flight { get; set; }
    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Flight
{
    public int Id { get; set; }
    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Seat
{
    public int Row { get; set; }
    public int Number { get; set; }
    public decimal Price { get; set; }
    public Status Status { get; set; }

    public Seat(int row, int number, decimal price)
    {
        Row = row;
        Number = number;
        Price = price;
        Status = Status.Available;
    }

    public void Book()
    {
        if (Status == Status.Available)
        {
            Status = Status.Booked;
        }
        else
        {
            throw new InvalidOperationException("Seat not available.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a new flight
        Flight flight = new Flight();
        flight.Id = 1;

        // Create a new seat
        Seat seat = new Seat(1, 1, 100);
        flight.Seats.Add(seat);

        // Book the seat
        seat.Book();

        Console.WriteLine("Seat booked successfully.");
    }
}

public enum Status
{
    Available,
    Booked
}

public class Seat
{
    public int Row { get; set; }
    public int Number { get; set; }
    public decimal Price { get; set; }
    public Status Status { get; set; }

    public Seat(int row, int number, decimal price)
    {
        Row = row;
        Number = number;
        Price = price;
        Status = Status.Available;
    }

    public void Book()
    {
        if (Status == Status.Available)
        {
            Status = Status.Booked;
        }
        else
        {
            throw new InvalidOperationException("Seat not available.");
        }
    }
}
public enum Status
{
    Available,
    Booked
}

public class User
{
    public int Id { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();
}

public class Booking
{
    public int No { get; set; }
    public Flight Flight { get; set; }
    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Flight
{
    public int Id { get; set; }
    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Seat
{
    public int Row { get; set; }
    public int Number { get; set; }
    public decimal Price { get; set; }
    public Status Status { get; set; }

    public Seat(int row, int number, decimal price)
    {
        Row = row;
        Number = number;
        Price = price;
        Status = Status.Available;
    }

    public void Book()
    {
        if (Status == Status.Available)
        {
            Status = Status.Booked;
        }
        else
        {
            throw new InvalidOperationException("Seat not available.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a new flight
        Flight flight = new Flight();
        flight.Id = 1;

        // Create a new seat
        Seat seat = new Seat(1, 1, 100);
        flight.Seats.Add(seat);

        // Book the seat
        seat.Book();

        Console.WriteLine("Seat booked successfully.");
    }
}