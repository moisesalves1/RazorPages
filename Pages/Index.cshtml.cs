using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet()
        {
            await Task.Delay(5000);
            for (var i=0; i<= 100; i++)
            {
                Categories.Add(new Category(i, $"Categoria {i}", i * 18.95M));
            }
        }

        public void OnPost()
        {
        }
    }
}

public record Category( int Id, 
                        string Title, 
                        decimal Price)
{

}