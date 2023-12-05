// Derived Reception class
class Reception : Event
{
    private string _rsvpEmail;

    // Constructor with underscore prefix to initialize reception-specific properties
    public Reception(string _title, string _description, DateTime _date, TimeSpan _time, Address _address, string _rsvpEmail)
        : base(_title, _description, _date, _time, _address)
    {
        this._rsvpEmail = _rsvpEmail;
    }

    // Override method for generating full details, including reception-specific information
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}, Type: Reception, RSVP Email: {_rsvpEmail}";
    }
}