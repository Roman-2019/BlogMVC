using AutoMapper;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CommentController : ApiController
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController()
        {

        }

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var comments = _commentService.GetAll();

            return Ok(comments);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var comment = _commentService.GetById(id);

            return Ok(comment);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]CommentApiModel commentApiModel)
        {
            var commentModel = _mapper.Map<CommentModel>(commentApiModel);

            _commentService.Add(commentModel);

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody]CommentApiModel commentApiModel)
        {
            var commentModel = _mapper.Map<CommentModel>(commentApiModel);

            _commentService.Update(commentModel);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _commentService.Remove(id);

            return Ok();
        }
    }
}
