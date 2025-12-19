namespace Task4.Entities;

public class Temperature
{
    private int _c;
    private int _f;
    public int C
    {
        get => _c;
        set
        {
            _c = value;
            _f = CToF(value);
        }
    }

    public int F
    {
        get => _f;
        set
        {
            _f = value;
            _c = FToC(value);
        }
    }

    private int CToF(int c) => c * 9 / 5 + 32;
    private int FToC(int f) => (f - 32) * 5 / 9;

}