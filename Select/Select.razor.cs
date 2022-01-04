
using Microsoft.AspNetCore.Components;

namespace Blazor.Select;

public partial class Select<DataType>
{
    public event Action<Select<DataType>> OnClick;
    public event Action<Select<DataType>, DataType> OptionOnClick;

    internal IEnumerable<DataType> FilteredItems => Values.Where(a => (a is null ? string.Empty : a.ToString()).ToLowerInvariant().Contains(FilterText.ToLowerInvariant()));

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


    private void SelectClicked()
    {
        OnClick?.Invoke(this);
    }
    private void OptionClicked(int i, DataType value)
    {

    }
}
