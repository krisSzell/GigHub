﻿using GigHub.Dtos;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class FollowingsController : ApiController
    {

        private readonly ApplicationDbContext _context;

        public FollowingsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var followerId = User.Identity.GetUserId();

            if (_context.Followings.Any(f => f.FollowerId == followerId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("You already follow this artist.");

            var following = new Following
            {
                FollowerId = followerId,
                FolloweeId = followingDto.FolloweeId
            };

            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            var userId = User.Identity.GetUserId();

            var following = _context.Followings.SingleOrDefault(f => f.FolloweeId == id && f.FollowerId == userId);

            if (following == null)
                return NotFound();

            _context.Followings.Remove(following);
            _context.SaveChanges();

            return Ok(id);
        }

    }
}
