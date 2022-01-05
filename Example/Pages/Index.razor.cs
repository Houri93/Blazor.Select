namespace Example.Pages;

public partial class Index
{
    private List<string> values = new();

    protected override void OnInitialized()
    {
        values.Add("Hello 1");
        values.Add("Hello 2");
        values.Add("Hello 3");
        values.Add("Hello 4");
        values.Add("Hello 5");

        base.OnInitialized();
    }
}
