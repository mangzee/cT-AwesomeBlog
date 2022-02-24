using cT.Api.Managers.Interface;
using cT.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace cT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostManager postManager;

        public PostController(IPostManager postManager)
        {
            this.postManager = postManager;
        }

        [HttpGet]
        [Route("/api/posts")]
        public IActionResult Get()
        {
            return Ok(postManager.List());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(postManager.Get(id));
        }

        [HttpGet("{tag}")]
        public IActionResult GetByTag(string tag)
        {
            throw new NotImplementedException("Get all Posts based on tag name");
            //TODO: please add implementation here
            //Get all Posts having the tag
            //If not posts available return NotFound.
        }

        [HttpPost]
        public IActionResult Post(PostDetailsModel postDetailsModel)
        {
            postManager.Save(postDetailsModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            postManager.Remove(id);
            return Ok();
        }
    }
}