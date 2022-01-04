namespace Example.Pages;

public partial class Index
{
    private List<string> strings = new();

    protected override void OnInitialized()
    {
        strings.Add("Hello 1");
        strings.Add("Hello 2");
        strings.Add("Hello 3");
        strings.Add("Hello 4");
        strings.Add("Hello 5");

        base.OnInitialized();
    }
}
