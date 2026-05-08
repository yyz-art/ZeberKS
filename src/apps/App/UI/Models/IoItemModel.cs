using ZC.Mvvm;

namespace ZitApp.Models;


[ObservableObject(RequiredGenerate = true)]
public partial class IoItemModel : ObservableObject
{

    public partial string Name { get; set; } = "";
    

    public partial string Direction { get; set; } = "PLC->PC";
    

    public partial string Address { get; set; } = "";
    

    public partial string Value { get; set; } = "0";
    

    public partial string Remark { get; set; } = "";

    public partial string WriteValue { get; set; } = "";

    public string DataType { get; set; } = "short"; 
}
