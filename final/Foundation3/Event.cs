// Base Event class
class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    // Constructor to initialize common event properties
    public Event(string _title, string _description, DateTime _date, TimeSpan _time, Address _address)
    {
        this._title = _title;
        this._description = _description;
        this._date = _date;
        this._time = _time;
        this._address = _address;
    }

    // Methods for generating standard details, full details, and short descriptions
    public string GenerateStandardDetails()
    {
        return $"Standard Details: {_title}, {_description}, {_date.ToShortDateString()}, {_time.ToString(@"hh\:mm")}, {_address}";
    }

    // Virtual method for generating full details, to be overridden by derived classes
    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public string GenerateShortDescription()
    {
        return $"Short Description: {GetType().Name}, {_title}, {_date.ToShortDateString()}";
    }
}