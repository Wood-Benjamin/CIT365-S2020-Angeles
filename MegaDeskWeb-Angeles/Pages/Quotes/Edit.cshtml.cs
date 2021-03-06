﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb_Angeles.Data;
using MegaDeskWeb_Angeles.Models;

namespace MegaDeskWeb_Angeles.Pages.Quotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskWeb_Angeles.Data.MegaDeskWeb_AngelesContext _context;

        public EditModel(MegaDeskWeb_Angeles.Data.MegaDeskWeb_AngelesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.DrawerCost = DeskQuote.calcDrawerCost();
            DeskQuote.MaterialCost = DeskQuote.calcMaterialCost();
            DeskQuote.SurfaceAreaCost = DeskQuote.calcSurfaceAreaCost();
            DeskQuote.RushCost = DeskQuote.calcRushOrderCost();
            DeskQuote.QuoteTotal = DeskQuote.calcQuoteTotal();

            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.ID == id);
        }
    }
}
