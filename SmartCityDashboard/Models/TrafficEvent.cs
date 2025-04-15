public class TrafficEvent
{
    public int Id { get; set; } // Local DB Id (Primary Key)

    public string EventId { get; set; } // From API: "ID"
    public string RegionName { get; set; }
    public string CountyName { get; set; }
    public string Severity { get; set; }
    public string RoadwayName { get; set; }
    public string DirectionOfTravel { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string LanesAffected { get; set; }
    public string LanesStatus { get; set; }
    public string PrimaryLocation { get; set; }
    public string SecondaryLocation { get; set; }
    public string FirstArticleCity { get; set; }
    public string SecondCity { get; set; }
    public string EventType { get; set; }
    public string EventSubType { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public DateTime? PlannedEndDate { get; set; }
    public DateTime? Reported { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? LastUpdated { get; set; }
}
