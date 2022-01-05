namespace Example.Pages;

public partial class Index
{
    private List<int> strings = new();

    protected override void OnInitialized()
    {
        for (int i = 0; i < 10; i++)
        {
            strings.Add(i);
        }

        base.OnInitialized();
    }
}
