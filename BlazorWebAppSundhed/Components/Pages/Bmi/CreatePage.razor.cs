using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Sundhed.Bmi.Application.Command;
using System.ComponentModel;
using System.Web.Http.ModelBinding;


namespace BlazorWebAppSundhed.Components.Pages.Bmi
{
    public partial class CreatePage : PageModel
    {
        private readonly ICreateBmiCommand _command;
        public CreatePage(ICreateBmiCommand createBmiCommand)
        {
            _command = createBmiCommand;
        }

        // binding property
        [BindProperty]
        public BmiCreateViewModel BmiModel { get; set; } = new();

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if(!ModelState.isvalid) return;

            var dto = new BmiCreateRequestDto { Height = BmiModel.Height.Value, Weight = BmiModel.Weigth.Value };
            _command.Create(dto);

            new RedirectToPageResult("Bmi/Index");
        }

    }
}
