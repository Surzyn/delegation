using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DelegationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelegationController : ControllerBase
    {
        IDelegationItemRepository _delegationItemRepository;

        public DelegationController(IDelegationItemRepository delegationItemRepository)
        {
            _delegationItemRepository = delegationItemRepository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            Thread.Sleep(2000);
            return Ok(_delegationItemRepository.GetAll());
        }

        [HttpGet("base")]
        public ActionResult GetBaseData()
        {
            Thread.Sleep(2000);
            return Ok(_delegationItemRepository.GetBaseData());
        }

        [HttpPost]
        public ActionResult Post(DelegationItem item)
        {
            if (String.IsNullOrWhiteSpace(item.FirstName))
            {
                return BadRequest("firstName can't be empty");
            }

            _delegationItemRepository.SaveItem(item);
            return Ok();
        }
    }
}