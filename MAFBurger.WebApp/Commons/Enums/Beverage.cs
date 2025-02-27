using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Commons.Enums
{
    public enum Beverage
    {
        [Display(Name = "Coca Cola")]
        CocaCola =1,
        [Display(Name = "Fanta")]
        Fanta =2,
        [Display(Name = "Sprite")]
        Sprite =3,
        [Display(Name = "Ice Tea")]
        IceTea =4,
        [Display(Name = "Ayran")]
        Ayran =5,

    }
}
