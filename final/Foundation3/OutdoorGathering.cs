// Derived OutdoorGathering class
class OutdoorGathering : Event
{
    private string _weatherStatement;

    // Constructor to initialize outdoor gathering-specific properties
    public OutdoorGathering(string _title, string _description, DateTime _date, TimeSpan _time, Address _address, string _weatherStatement)
        : base(_title, _description, _date, _time, _address)
    {
        this._weatherStatement = _weatherStatement;
    }

    // Override method for generating full details, including outdoor gathering-specific information
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}, Type: Outdoor Gathering, Weather: {_weatherStatement}";
    }
}
