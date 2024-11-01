using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciocan_Felicia_Lab2.Data;
using Ciocan_Felicia_Lab2.Models;

namespace Ciocan_Felicia_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Ciocan_Felicia_Lab2.Data.Ciocan_Felicia_Lab2Context _context;

        public IndexModel(Ciocan_Felicia_Lab2.Data.Ciocan_Felicia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Ciocan_Felicia_Lab2.Models.Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Authors = await _context.Authors
                .ToListAsync();
        }
    }
}
