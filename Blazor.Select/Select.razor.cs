
using Microsoft.AspNetCore.Components;

namespace Blazor.Select;

public partial class Select<DataType>
{
    public event Action<Select<DataType>> OnClick;
    public event Action<Select<DataType>, int, DataType> OptionOnClick;

    internal IEnumerable<DataType> FilteredItems => string.IsNullOrEmpty(FilterText) ? Values : Values.Where(a => (a is null ? string.Empty : a.ToString()).ToLowerInvariant().Contains(FilterText.ToLowerInvariant()));

    [Parameter]
    public string Class { get; set; } = string.Empty;

    [Parameter]
    public string FilterText { get; set; }

    [Parameter]
    public RenderFragment<DataType> Template { get; set; }

    [Parameter]
    public bool Filter { get; set; } = true;

    [Parameter]
    public DataType SelectedValue { get; set; }

    [Parameter]
    public int SelectedIndex { get; set; }

    [Parameter]
    [EditorRequired]
    public List<DataType> Values { get; set; }

    [Parameter]
    public bool Open { get; set; }

    protected override void OnInitialized()
    {
        if (SelectedValue is null || SelectedValue.Equals(default(DataType)))
        {
            SelectedValue = Values.FirstOrDefault();
        }

        base.OnInitialized();
    }

    private void SelectClicked()
    {
        if (Open)
        {
            return;
        }
        Open = !Open;
        OnClick?.Invoke(this);
    }
    private void OptionClicked(int i, DataType value)
    {
        SelectedValue = value;
        SelectedIndex = i;

        OptionOnClick?.Invoke(this, i, value);
    }

}
