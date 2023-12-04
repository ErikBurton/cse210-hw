// Derived Lecture class
class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor to initialize lecture-specific properties
    public Lecture(string _title, string _description, DateTime _date, TimeSpan _time, Address _address, string _speaker, int _capacity)
        : base(_title, _description, _date, _time, _address)
    {
        this._speaker = _speaker;
        this._capacity = _capacity;
    }

    // Override method for generating full details, including lecture-specific information
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}, Type: Lecture, Speaker: {_speaker}, Capacity: {_capacity}";
    }
}
