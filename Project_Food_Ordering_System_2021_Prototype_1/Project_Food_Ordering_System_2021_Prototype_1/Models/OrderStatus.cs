
using System.ComponentModel;


namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    //How to use enum
    //MyEnum myLocal = MyEnum.V1;
    //print(myLocal.ToDescriptionString());
    public enum OrderStatus
    {
        [Description("Pending")]
        PENDING,
        [Description("Paid")]
        PAID,
        [Description("Fullfilled")]
        FULLFILLED,
        [Description("Done")]
        DONE        
         
    }
}