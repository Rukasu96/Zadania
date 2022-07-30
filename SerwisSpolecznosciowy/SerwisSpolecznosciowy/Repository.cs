using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class Repository
    {
        private List<User> users;
        private List<Post> posts;
        private List<Comment> comments;


        public void AddUser(User user)
        {
            foreach (User _user in users)
            {
                if(user.Email == _user.Email)
                {
                    return;
                }
            }

            users.Add(user);
            //przydzielić id;
        }

        public void AddPost(Post post)
        {
            foreach(User user in users)
            {
                if(post.User.Id == user.Id)
                {
                    posts.Add(post);
                    return;
                }
                //Przydzielić id;
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
                    comments.Add(comment);
                    break;
                }
            }
            //Przydzielić id;
        }

    }
}
