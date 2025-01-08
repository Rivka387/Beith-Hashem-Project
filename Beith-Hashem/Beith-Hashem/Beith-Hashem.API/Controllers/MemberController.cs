
using Beith_Hashem.Core.Entities;
using Beith_Hashem.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Beith_Hashem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }


        // GET: api/<MemberController>
        [HttpGet]
        public ActionResult Get()
        {
           
            return Ok(_memberService.GetService());
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            var member = _memberService.GetByIdService(id);
            if (member == null) { return NotFound(); }
            return Ok(member);
        }

        // POST api/<MemberController>
        [HttpPost]
        public ActionResult Post([FromBody] Member value)
        {
            return Ok(_memberService.AddMember(value));

        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Member m)
        {
            return Ok(_memberService.UpdateMemberService(m,id));

        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_memberService.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
