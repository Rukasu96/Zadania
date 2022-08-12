﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SerwisSpolecznosciowy
{
    internal class Repository : IPredicate
    {
        private List<User> users;
        private List<Post> posts;
        private List<Comment> comments;
        private List<int> usedID;
        public event Action<Post> Predicate;


        public Repository()
        {
            users = new List<User>();
            posts = new List<Post>();
            comments = new List<Comment>();
            usedID = new List<int>();
        }

        public void AddUser(User user)
        {
            foreach (User _user in users)
            {
                if(user.Email == _user.Email)
                {
                    return;
                }
            }
            users.Where(x => x.Email != user.Email).ToList().Add(user);
            user.Id = DrawID();

        }

        public void AddPost(Post post)
        {
            foreach(User user in users)
            {

                posts.Where(x => x.User.Id == user.Id).ToList().Add(post);

                if(post.User.Id == user.Id)
                {
                    post.Id = DrawID();
                    user.numberPosts.Add(post);
                    posts.Add(post);
                    return;
                }
            }

           
        }

        public void AddComment(Comment comment)
        {
            foreach(User user in users)
            {
                if(comment.User.Id == user.Id)
                {
                    break;
                }
            }
            foreach(Post post in posts)
            {
                if(comment.Post.Id == post.Id)
                {
                    comment.Id = DrawID();
                    post.Comments.Add(comment);
                    comments.Add(comment);
                    break;
                }
            }

        }

        

        private int DrawID()
        {
            Random rand = new Random();
            int ID = rand.Next(0, 999);
            while(usedID.Contains(ID))
            {
                ID = rand.Next(0, 999);
            }
            usedID.Add(ID);

            return ID;
        }

        public Post FindFirstPost(Predicate<Post> predicate)
        {
            foreach(Post post in posts)
            {
                if(predicate(post))
                {
                    return post;
                }
            }
            return null;
        }

        public void wyswietl()
        {
            foreach(User user in users)
            {
                Console.WriteLine(user);
            }

            foreach(Post post in posts)
            {
                Console.WriteLine(post);
            }

            foreach(Comment comment in comments)
            {
                Console.WriteLine(comment);
            }
        }

        
    }
}
