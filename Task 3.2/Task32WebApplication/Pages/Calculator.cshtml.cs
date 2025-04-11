using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task32WebApplication.Pages
{
    public class CalculatorModel : PageModel {
        [BindProperty]
        public double Num1 { get; set; }

        [BindProperty]
        public double Num2 { get; set; }

        [BindProperty]
        public string Operation { get; set; }

        public double Result { get; set; }

        public void OnGet() {
            Num1 = 0;
            Num2 = 0;
            Operation = "+";
        }

        public IActionResult OnPost() {
            switch (Operation) {
                case "+":
                    Result = Num1 + Num2;
                    break;
                case "-":
                    Result = Num1 - Num2;
                    break;
                case "*":
                    Result = Num1 * Num2;
                    break;
                case "/":
                    Result = Num2 != 0 ? Num1 / Num2 : double.NaN;
                    break;
            }

            return Page();
        }
    }
}
