using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppSundhed.Components.Pages.Bmi
{
    public class BmiCreateViewModel
    {
        [Range(100, 250)]
        public double? Height {  get; set; }

        [Range(40, 250)]
        public double? Weigth { get; set; }
    }
}
