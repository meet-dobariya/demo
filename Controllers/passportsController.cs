using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using core_passport5.Data;
using core_passport5.Models;

namespace core_passport5.Controllers
{
    public class passportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public passportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: passports
        public async Task<IActionResult> Index()
        {
            return View(await _context.details.ToListAsync());
        }

        // GET: passports/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passport = await _context.details
                .FirstOrDefaultAsync(m => m.fnum == id);
            if (passport == null)
            {
                return NotFound();
            }

            return View(passport);
        }

        // GET: passports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: passports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("fnum,Applyingfor,ifreissue,ifchange,txt1,toa14,topb15,vr16,photo,sign,anm,ali22,cnm23,dob24,pob25,dt25,st25,reg25,gen26,mst27,czn28,pan29,vt210,emp211,onm212,pnt213,edu214,cat215,vdm216,an217,fnm31,mnm32,lnm33,snm34,fpn35,fnt35,mpn35,mnt35,st41,ct42,dt43,plcstn,st44,pin45,eml46,mob47,tel48,isadd42,address,mno,tno,mail2,passno61,doi62,doe63,poi64,isapp62,filenumber,monthandyear,poffice,f711,f712,f713,f714,f715,f716,f717,f718,f719,f720,f721,f722,f723,f724,f725,fee,ddnum,issuedate,expirydate,bankname,branchname,ec1,spot,todaydate,sign2")] passport passport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passport);
        }

        // GET: passports/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passport = await _context.details.FindAsync(id);
            if (passport == null)
            {
                return NotFound();
            }
            return View(passport);
        }

        // POST: passports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("fnum,Applyingfor,ifreissue,ifchange,txt1,toa14,topb15,vr16,photo,sign,anm,ali22,cnm23,dob24,pob25,dt25,st25,reg25,gen26,mst27,czn28,pan29,vt210,emp211,onm212,pnt213,edu214,cat215,vdm216,an217,fnm31,mnm32,lnm33,snm34,fpn35,fnt35,mpn35,mnt35,st41,ct42,dt43,plcstn,st44,pin45,eml46,mob47,tel48,isadd42,address,mno,tno,mail2,passno61,doi62,doe63,poi64,isapp62,filenumber,monthandyear,poffice,f711,f712,f713,f714,f715,f716,f717,f718,f719,f720,f721,f722,f723,f724,f725,fee,ddnum,issuedate,expirydate,bankname,branchname,ec1,spot,todaydate,sign2")] passport passport)
        {
            if (id != passport.fnum)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!passportExists(passport.fnum))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(passport);
        }

        // GET: passports/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passport = await _context.details
                .FirstOrDefaultAsync(m => m.fnum == id);
            if (passport == null)
            {
                return NotFound();
            }

            return View(passport);
        }

        // POST: passports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var passport = await _context.details.FindAsync(id);
            _context.details.Remove(passport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool passportExists(string id)
        {
            return _context.details.Any(e => e.fnum == id);
        }
    }
}
