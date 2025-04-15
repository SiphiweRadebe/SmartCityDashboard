using SmartCityDashboard.Data;

public class TrafficService
{
    private readonly HttpClient _http;
    private readonly AppDbContext _context;
    private const string apiKey = "YOUR_API_KEY"; // 👈 Replace with actual key

    public TrafficService(HttpClient http, AppDbContext context)
    {
        _http = http;
        _context = context;
    }

    public async Task<List<TrafficEvent>> FetchAndSaveEventsAsync()
    {
        var url = $"https://www.i-traffic.co.za/api/GetEvents?key={apiKey}&format=json";
        var events = await _http.GetFromJsonAsync<List<TrafficEvent>>(url);

        if (events != null)
        {
            foreach (var evt in events)
            {
                var exists = _context.TrafficEvents.Any(e => e.ID == evt.ID);
                if (!exists)
                    _context.TrafficEvents.Add(evt);
            }
            await _context.SaveChangesAsync();
        }

        return events;
    }

    public List<TrafficEvent> GetAllEventsFromDb()
    {
        return _context.TrafficEvents.ToList();
    }
}
