﻿using Module02Homework03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module02Homework03.Controllers
{
    public class PostsController : Controller
    {
        static List<Post> Posts = new List<Post>()
        {
            new Post() { Id = 1, UserId = 1, TimeOfPosting = new DateTime(2008, 7, 10, 20, 23, 30), Message = "Salut", PostType = PostType.Text, IsSticky = true, Priority = 1},
            new Post() { Id = 2, UserId = 2, TimeOfPosting = new DateTime(2008, 7, 13, 22, 54, 59), Message = "Noroc. Ce faci?", PostType = PostType.Text, IsSticky = false, Priority = 2 },
            new Post() { Id = 3, UserId = 1, TimeOfPosting = new DateTime(2008, 8, 16, 10, 10, 10), Message = "Ma uit la semifinala", PostType = PostType.Text, IsSticky = true, Priority = 2 }
        };

        // GET: Posts
        public ActionResult Index()
        {
            ViewBag.MyFirstViewBag = DateTime.Now;
            return View(Posts);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            var post = Posts.Where(p => p.Id == id).FirstOrDefault();

            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (string.IsNullOrEmpty(post.Message))
            {
                return new HttpNotFoundResult();
            }
            else
            {
                Posts.Add(post);

                return View("Details", post);
            }
        }

        public ActionResult Delete(int id)
        {
            Post post = Posts.Find(p => p.Id == id);

            if (post == null)
            {
                return new HttpNotFoundResult();
            }

            Posts.Remove(post);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Post post = Posts.Find(p => p.Id == id);

            if (post == null)
            {
                return new HttpNotFoundResult();
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            Post postFromList = Posts.Find(p => p.Id == post.Id);

            postFromList.UserId = post.UserId;
            postFromList.TimeOfPosting = post.TimeOfPosting;
            postFromList.Message = post.Message;
            postFromList.PostType = post.PostType;
            postFromList.IsSticky = post.IsSticky;
            postFromList.Priority = post.Priority;

            return RedirectToAction("Index");
        }
    }
}
