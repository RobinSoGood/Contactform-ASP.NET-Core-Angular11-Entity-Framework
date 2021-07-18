using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactformAPI.Models;

namespace ContactformAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactformDbController : ControllerBase
    {
        private readonly ContactformDetailContext _context;

        public ContactformDbController(ContactformDetailContext context)
        {
            _context = context;
        }

        // GET: api/ContactformDetail/id
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactformDb>> GetContactformDb(int id)
        {
            var contactformDb = await _context.ContactformDbs.FindAsync(id);

            if (contactformDb == null)
            {
                return NotFound();
            }
            
            return contactformDb;
        }
      
        
        // POST: api/ContactformDetail
        [HttpPost]
        public async Task<ActionResult<ContactformDetail>> PostContactformDetail(ContactformDetail contactformDetail)
        {
            var finduser = _context.UserContactforms.Where(f => f.UserTelephone == contactformDetail.Telephone && f.UserEmail == contactformDetail.Email).Select(i => i.Id).ToList();
            if (finduser.Count == 0)
            {
                ContactformDb contactformdb = new()
                {
                    ContactformDbId = contactformDetail.ContactformDetailId,
                    Theme = contactformDetail.Theme,
                    DbMessage = contactformDetail.Message,
                    UserContactformId = 0
                };
                UserContactform usercontactform = new()
                {
                    Id = contactformDetail.ContactformDetailId,
                    UserName = contactformDetail.Name,
                    UserEmail = contactformDetail.Email,
                    UserTelephone = contactformDetail.Telephone
                };
                _context.UserContactforms.Add(usercontactform);
                await _context.SaveChangesAsync();
                contactformdb.UserContactformId = usercontactform.Id;

                _context.ContactformDbs.Add(contactformdb);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetContactformDb", new { id = contactformdb.UserContactformId }, contactformdb);
            }
            else
            {
                ContactformDb contactformdb = new()
                {
                    ContactformDbId = contactformDetail.ContactformDetailId,
                    Theme = contactformDetail.Theme,
                    DbMessage = contactformDetail.Message,
                    UserContactformId = 0
                };
                var findid = finduser[0];
                contactformdb.UserContactformId = findid;

                _context.ContactformDbs.Update(contactformdb);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetContactformDb", new { id = contactformdb.UserContactformId }, contactformdb);
            }

           
        }

    }
}
