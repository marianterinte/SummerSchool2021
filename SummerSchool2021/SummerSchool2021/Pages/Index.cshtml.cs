using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Collections.Generic;


namespace SummerSchool2021.Pages
{
    public class IndexModel : PageModel
    {
        public List<Phone> phones;

        public void OnGet()
        {
            var iPhone = new Phone("Iphone", "3", "Blue", "2400");
            var samsungPhone = new Phone("Samsung", "s3", "Silver", "2000");
            phones = new List<Phone>() { iPhone , samsungPhone };
        }
    }
}
