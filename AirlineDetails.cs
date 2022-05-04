using System;

public class AirlineDetails
{
	public AirlineDetails()
	{
    public string FlightName { get; set; }
    public string FromPlace { get; set; }
    public string ToPlace { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Blocked { get; set; }
    public string ScheduledDay { get; set; }
    public int FlightNumber { get; set; }
    public string InstrumentUsed { get; set; }
    public int BusinessClassSeats { get; set; }
    public int NonBusinessClassSeats { get; set; }
    public int TicketCost { get; set; }
    public int NoOfRows { get; set; }
    public string Meal { get; set; }

}
}
