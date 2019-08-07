using BusinessLayer;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
namespace KeepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INotemanagement notemanagement;
        public NoteController(INotemanagement _notemanagement)
        {
            notemanagement = _notemanagement;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(notemanagement.GetNote());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(notemanagement.GetNoteById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Note note)
        {
            try
            {
                return Created("api/note", notemanagement.CreatNote(note));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Note note)
        {
            try
            {
                return Ok(notemanagement.UpdateNote(note));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(notemanagement.RemoveNote(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}