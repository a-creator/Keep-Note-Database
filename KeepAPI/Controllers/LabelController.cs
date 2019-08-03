using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KeepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelManagement labelmanagement;
        public LabelController(ILabelManagement service)
        {
            labelmanagement = service;
        }
        // GET: api/Label
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(labelmanagement.GetLabel());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Label label)
        {
            return Ok(labelmanagement.CreatLabel(label));
        }
        // PUT: api/Label/5
        [HttpPut]
        public IActionResult Put([FromBody] Label label)
        {
            return Ok(labelmanagement.UpdateLabel(label));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(labelmanagement.RemoveLabel(id));
        }
    }
}